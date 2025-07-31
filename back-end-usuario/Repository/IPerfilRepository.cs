using GISA.Model;
using GISA.ViewModel;
using GISA.ViewModel.Perfil;

namespace GISA.Repository.Interfaces
{
    public interface IPerfilRepository
    {
        List<PerfilViewModel> Buscar();
        ResultadoViewModel Criar(PerfilViewModel perfilViewModel);
        ResultadoViewModel Atualizar(PerfilViewModel perfilViewModel);
        ResultadoViewModel Excluir(PerfilViewModel perfilViewModel);
        PerfilViewModel BuscarPorId(int perfilId);
    }
}
