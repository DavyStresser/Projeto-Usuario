using GISA.Model;
using GISA.ViewModel;
using GISA.ViewModel.Usuario;

namespace GISA.Repository.Interfaces
{
    public interface IUsuarioRepository
    {
        List<UsuarioViewModel> Buscar();
        UsuarioViewModel BuscarPorId(int usuarioId);
        ResultadoViewModel Criar(UsuarioViewModel usuarioViewModel);
        ResultadoViewModel Atualizar(UsuarioViewModel usuarioViewModel);
        ResultadoViewModel Excluir(UsuarioViewModel usuarioViewModel);
        UsuarioViewModel ValidarLoginSenha(string login, string senha);
        List<UsuarioViewModel> BuscarPorMunicipioId(int municipioId);
        void EncriptarTodasAsSenhas();
    }
}
