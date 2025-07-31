using GISA.Model;
using GISA.ViewModel;
using GISA.ViewModel.GisaLog;
using GISA.ViewModel.Usuario;

namespace GISA.Repository.Interfaces
{
    public interface ILogRepository
    {
        ResultadoViewModel Criar(LogViewModel log);
        List<LogViewModel> Buscar(LogFiltroViewModel filtro);
    }
}
