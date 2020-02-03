using Dapper;
using Konatus.ABCD_Airlines.Core.Entity;
using Konatus.ABCD_Airlines.Core.Interfaces.Repository;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Konatus.ABCD_Airlines.Infra.Repository
{
    public class RelatorioRepository: IRelatorioRepository
    {
        protected string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=AircraftControl;Integrated Security=SSPI";

        public RelatorioRepository()
        {

        }

        public IEnumerable<Aeronave> ObterTodasAeronavesAtivas()
        {
            var query = $"select * from Aeronave where Active = 1";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                return connection.Query<Aeronave>(query);
            };
        }
    }
}
