using Dapper;
using GISA.Model;
using GISA.Repository.Interfaces;
using GISA.ViewModel.Whatsapp;
using Microsoft.Extensions.Configuration;
using Npgsql;


namespace GISA.Repository
{
    public class WhatsappRepository : IWhatsappRepository
    {
        private readonly string _connStr;

        public WhatsappRepository(IConfiguration config)
        {
            _connStr = config.GetConnectionString("GisaPostgre");
        }

        public async Task InserirAsync(WhatsappModel model)
        {
            const string sql = @"
        INSERT INTO gi_whatsapp (celular, nome)
        VALUES (@Celular, @Nome);";

            using var conn = new NpgsqlConnection(_connStr);
            await conn.ExecuteAsync(sql, model);
        }

        public async Task<IEnumerable<WhatsappModel>> ListarTodosAsync(int? idWhatsapp = null)
        {
            var sql = @"
        SELECT 
            id_whatsapp AS IdWhatsapp,
            celular     AS Celular,
            nome        AS Nome,
            dt_cadastro AS DtCadastro,
            st_ativo    AS StAtivo
        FROM gi_whatsapp
        WHERE st_ativo = 1";

            if (idWhatsapp.HasValue)
                sql += " AND id_whatsapp = @IdWhatsapp";

            using var conn = new NpgsqlConnection(_connStr);
            return await conn.QueryAsync<WhatsappModel>(sql, new { IdWhatsapp = idWhatsapp });
        }

        public async Task AtualizarAsync(WhatsappModel model)
        {
            const string sql = @"
        UPDATE gi_whatsapp
        SET nome = @Nome,
            celular = @Celular
        WHERE id_whatsapp = @IdWhatsapp";

            using var conn = new NpgsqlConnection(_connStr);
            await conn.ExecuteAsync(sql, model);
        }

        public async Task DesativarAsync(int idWhatsapp)
        {
            const string sql = @"
        UPDATE gi_whatsapp
        SET st_ativo = 0
        WHERE id_whatsapp = @IdWhatsapp";

            using var conn = new NpgsqlConnection(_connStr);
            await conn.ExecuteAsync(sql, new { IdWhatsapp = idWhatsapp });
        }
    }
}
