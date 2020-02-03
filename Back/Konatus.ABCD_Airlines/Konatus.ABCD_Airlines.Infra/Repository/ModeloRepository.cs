using Dapper;
using Konatus.ABCD_Airlines.Core.Entity;
using Konatus.ABCD_Airlines.Core.Interfaces.Repository;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Konatus.ABCD_Airlines.Infra.Repository
{
    public class ModeloAeronaveRepository : IModeloAeronaveRepository
    {
        protected string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=AircraftControl;Integrated Security=SSPI;";

        public ModeloAeronaveRepository( ) 
        {

        }

        public ModeloAeronave Adicionar(ModeloAeronave modeloAeronave)
        {
            var query = $"insert into ModeloAeronave (Code, AlternativeCode, MaxDepartureWeight, MaxLandingWeight ) values (@Code, @AlternativeCode, @MaxDepartureWeight, @MaxLandingWeight)";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                connection.Execute(query, modeloAeronave);
                return modeloAeronave;
            }
        }

        public void Atualizar(ModeloAeronave modeloAeronave)
        {
            var query = $"update ModeloAeronave set Code = @Code, AlternativeCode = @AlternativeCode, MaxDepartureWeight = @MaxDepartureWeight, MaxLandingWeight = @MaxLandingWeight where id = @Id";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                connection.Execute(query, modeloAeronave);
            }
        }

        public ModeloAeronave ObterPorId(int Id)
        {
            var query = $"select * from ModeloAeronave where Id = "+ Id;

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                return connection.QueryFirstOrDefault<ModeloAeronave>(query);
            }
        }

        public IEnumerable<ModeloAeronave> ObterTodos()
        {
            var query = $"select * from ModeloAeronave ";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                return connection.Query<ModeloAeronave>(query);
            }
        }

        public void Remover(int id)
        {
            var query = $"delete from ModeloAeronave where Id = @Id";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                connection.Execute(query, id);
            }
        }
    }
}
