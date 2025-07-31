using System;
using System.Threading;
using System.Threading.Tasks;
using GISA.Repository.Interfaces;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace GISA.Worker
{
    public class SqlWorker : BackgroundService
    {
        private readonly ILogger<SqlWorker> _logger;
        private TimeSpan _tempoParaExecutar;
        protected readonly ISqlRepository _sqlRepository;

        public SqlWorker(ILogger<SqlWorker> logger, ISqlRepository sqlRepository)
        {
            _logger = logger;
            _tempoParaExecutar = TimeSpan.FromDays(1);
            _sqlRepository = sqlRepository;
        }

        protected override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                var agora = DateTime.Now;
                var proximaExecucao = new DateTime(agora.Year, agora.Month, agora.Day, 1, 0, 0);

                if (agora > proximaExecucao)
                {
                    proximaExecucao = proximaExecucao.AddDays(1);
                }

                var tempoAteProximaExecucao = proximaExecucao - agora;

                await Task.Delay(tempoAteProximaExecucao, cancellationToken);

                await _sqlRepository.IniciarProcessoAsync();
            }
        }
    }
}
