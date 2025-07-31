using GISA.ViewModel.Whatsapp;

namespace GISA.Repository.Interfaces
{
    public interface IWhatsappRepository
    {
        Task InserirAsync(WhatsappModel model);
        Task<IEnumerable<WhatsappModel>> ListarTodosAsync(int? idWhatsapp = null);
        Task DesativarAsync(int idWhatsapp);
        Task AtualizarAsync(WhatsappModel model);

    }
}
