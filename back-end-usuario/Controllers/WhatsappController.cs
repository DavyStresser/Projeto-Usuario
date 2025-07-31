using GISA.Repository.Interfaces;
using GISA.ViewModel.Whatsapp;
using Microsoft.AspNetCore.Mvc;

namespace GISA.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class WhatsappController : ControllerBase
    {
        private readonly IWhatsappRepository _repo;

        public WhatsappController(IWhatsappRepository repo)
        {
            _repo = repo;
        }

        [HttpPost("Inserir")]
        public async Task<IActionResult> Inserir([FromBody] WhatsappModel model)
        {
            if (string.IsNullOrWhiteSpace(model.Celular))
                return BadRequest(new { sucesso = false, mensagem = "Celular obrigatório." });

            await _repo.InserirAsync(model);
            return Ok(new { sucesso = true, mensagem = "Inserido com sucesso." });
        }

        [HttpGet("listar")]
        public async Task<IActionResult> Listar([FromQuery] int? idWhatsapp)
        {
            var lista = await _repo.ListarTodosAsync(idWhatsapp);
            return Ok(lista);
        }

        [HttpPut("Editar")]
        public async Task<IActionResult> Editar([FromBody] WhatsappModel model)
        {
            if (model.IdWhatsapp <= 0)
                return BadRequest(new { sucesso = false, mensagem = "ID inválido." });

            await _repo.AtualizarAsync(model);
            return Ok(new { sucesso = true, mensagem = "Registro atualizado com sucesso." });
        }

        [HttpDelete("Deletar")]
        public async Task<IActionResult> Desativar([FromQuery] int idWhatsapp)
        {
            await _repo.DesativarAsync(idWhatsapp);
            return Ok(new { sucesso = true, mensagem = $"Registro {idWhatsapp} desativado com sucesso." });
        }
    }
}
