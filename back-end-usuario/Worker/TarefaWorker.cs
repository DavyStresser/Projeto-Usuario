using GISA.Repository.Interfaces;

namespace GISA.Worker
{
    public class TarefaWorker : BackgroundService
    {
        private readonly ILogger<TarefaWorker> _logger;
        protected readonly IConfiguration _configuration;
        private readonly INotificacaoRepository _notificacaoRepository;

        public TarefaWorker(ILogger<TarefaWorker> logger,
            IConfiguration configuration,
            INotificacaoRepository notificacaoRepository)
        {
            _logger = logger;
            _configuration = configuration;
            _notificacaoRepository = notificacaoRepository;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    _notificacaoRepository.CriarAcaoNoVencimento();
                    _notificacaoRepository.CriarAcaoPorAntesDoVencimento();
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Erro ao processar TarefaWorker");
                }

                await Task.Delay(TimeSpan.FromMinutes(120), stoppingToken);
            }
        }
    }
}
