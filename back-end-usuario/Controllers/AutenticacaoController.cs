using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using GISA.Helper;
using GISA.Model;
using GISA.Repository;
using GISA.Repository.Interfaces;
using GISA.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace GISA.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class AutenticacaoController : ControllerBase
    {
        private IConfiguration _config;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMunicipioRepository _municipioRepository;
        private readonly IUsuarioMunicipioRepository _usuarioMunicipioRepository;
        private readonly IPerfilRepository _perfilRepository;
        private readonly ILogRepository _logRepository;

        public AutenticacaoController(IConfiguration config,
            IUsuarioRepository usuarioRepository,
            IMunicipioRepository municipioRepository,
            IUsuarioMunicipioRepository usuarioMunicipioRepository,
            IPerfilRepository perfilRepository,
            ILogRepository logRepository)
        {
            _config = config;
            _usuarioRepository = usuarioRepository;
            _municipioRepository = municipioRepository;
            _usuarioMunicipioRepository = usuarioMunicipioRepository;
            _perfilRepository = perfilRepository;
            _logRepository = logRepository;
        }

        [HttpPost(Name = "Login")]
        public IActionResult Login([FromBody] LoginViewModel usuario)
        {
            if (usuario == null)
            {
                return BadRequest("Usuário inválido");
            }

            var usuarioViewModel = _usuarioRepository.ValidarLoginSenha(usuario.Login, usuario.Senha);
            if (usuarioViewModel?.UsuarioId > 0)
            {
                var _secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
                var _issuer = _config["Jwt:Issuer"];
                var _audience = _config["Jwt:Audience"];

                var signinCredentials = new SigningCredentials(_secretKey, SecurityAlgorithms.HmacSha256);

                var claims = new List<Claim>();
                claims.Add(new Claim("UsuarioId", Convert.ToString(usuarioViewModel.UsuarioId)));
                claims.Add(new Claim("UsuarioPerfilId", Convert.ToString(usuarioViewModel.PerfilId)));

                var tokeOptions = new JwtSecurityToken(
                    issuer: _issuer,
                    audience: _audience,
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(Convert.ToInt32(_config["Jwt:Expire"])),
                    signingCredentials: signinCredentials);

                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);

                var municipioUsuario = _usuarioMunicipioRepository.BuscarPorUsuarioId(usuarioViewModel.UsuarioId);
                var municipio = _municipioRepository.BuscarPorId(municipioUsuario.MunicipioId);
                var perfil = _perfilRepository.BuscarPorId(usuarioViewModel.PerfilId);
                var usuarioRepo = _usuarioRepository.BuscarPorId(usuarioViewModel.UsuarioId);

                //log
                _logRepository.Criar(new ViewModel.GisaLog.LogViewModel()
                {
                    TipoEvento = "U",
                    NomeEvento = "Login",
                    UsuarioId = usuarioViewModel.UsuarioId,
                    DataEvento = DateTime.Now.GetCurrentDateTimeInBrazil(),
                    DescricaoEvento = ""
                });

                return Ok(new { Token = tokenString, Usuario = usuarioRepo, Municipio = municipio, Perfil = perfil });

            }
            else
            {
                return Unauthorized();
            }
        }
    }
}