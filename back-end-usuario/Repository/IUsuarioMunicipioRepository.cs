using GISA.Model;
using GISA.ViewModel;
using GISA.ViewModel.Usuario;

namespace GISA.Repository.Interfaces
{
    public interface IUsuarioMunicipioRepository
    {
        UsuarioMunicipioViewModel BuscarPorUsuarioId(int usuarioId);
        ResultadoViewModel Criar(UsuarioMunicipioViewModel usuarioMunicipioViewModel);
        ResultadoViewModel Atualizar(UsuarioMunicipioViewModel usuarioMunicipioViewModel);
        ResultadoViewModel Excluir(UsuarioMunicipioViewModel usuarioMunicipioViewModel);
    }
}
