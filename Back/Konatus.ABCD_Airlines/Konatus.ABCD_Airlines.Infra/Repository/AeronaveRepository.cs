using Dapper;
using Konatus.ABCD_Airlines.Core.Entity;
using Konatus.ABCD_Airlines.Core.Interfaces.Repository;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Konatus.ABCD_Airlines.Infra.Repository
{
    public class AeronaveRepository : IAeronaveRepository
    {
        protected string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=AircraftControl;Integrated Security=SSPI";

        public AeronaveRepository()
        {

        }

        public Aeronave Adicionar(Aeronave aeronave)
        {
            var query = $"insert into Aeronave  (Prefix, MaxDepartureWeight, MaxLandingWeight, Active, AircraftModel ) values (@Prefix, @MaxDepartureWeight, @MaxLandingWeight, @Active, @AircraftModel)";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                connection.Execute(query, aeronave);
                return aeronave;
            }
        }

        public void Atualizar(Aeronave aeronave)
        {
            var query = $"update Aeronave set Prefix = @Prefix , MaxDepartureWeight = @MaxDepartureWeight, MaxLandingWeight = @MaxLandingWeight, Active = @Active, AircraftModel = @AircraftModel  where Id = @Id";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                connection.Execute(query, aeronave);
            }
        }

        public Aeronave ObterPorId(int Id)
        {
            var query = $"select * from Aeronave where Id = " + Id;

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var aeronave = connection.QueryFirstOrDefault<Aeronave>(query);
                var query2 = $"select * from ModeloAeronave where Id = " + aeronave.AircraftModelId;
                var modelo = connection.QueryFirstOrDefault<ModeloAeronave>(query2);
                aeronave.Modelo = new ModeloAeronave()
                {
                    Id = modelo.Id,
                    Code = modelo.Code,
                    AlternativeCode = modelo.AlternativeCode,
                    MaxDepartureWeight = modelo.MaxDepartureWeight,
                    MaxLandingWeight = modelo.MaxLandingWeight
                };
                return aeronave;
            }

        }

        public IEnumerable<Aeronave> ObterTodos()
        {
            var query = $"select * from Aeronave ";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                return connection.Query<Aeronave>(query);
            }
        }

        public void Remover(int id)
        {
            var query = $"delete from Aeronave where Id = @Id";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                connection.Execute(query, id);
            }
        }
    }
}
