using GISA.Model;
using GISA.ViewModel;
using GISA.ViewModel.Acao;

namespace GISA.Repository.Interfaces
{
    public interface IMunicipioRepository
    {
        List<MunicipioViewModel> Buscar();
        MunicipioViewModel BuscarPorId(int municipioId);
    }
}
