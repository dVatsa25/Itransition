using Dapper;
using Npgsql;

namespace ITransition.ELearning.DataAccessLayer
{
    public class TestDataLayer
    {
        private NpgsqlConnection connection;
        string Connection = "Server=127.0.0.1;Port=5432;Database=SampleDB;User Id=postgres;Password=sa1;";
        public  async Task TestConnection()
        {
            connection = new NpgsqlConnection(Connection);
           await connection.OpenAsync();
            string commandText = $"SELECT * FROM company";
            var games = await connection.QueryAsync<TestCompamny>(commandText);

        }

  }

    public class TestCompamny
    { 
    public long Id { get; set; }
    }
}