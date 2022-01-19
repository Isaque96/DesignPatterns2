using System.Data;
using System.Data.SqlClient;

namespace DesignPatterns2.Cap1
{
    internal class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            IDbConnection conexao = new SqlConnection();
            conexao.ConnectionString = "User Id=root;Password=;Serverlocalhost;Database=MeuBanco;";
            conexao.Open();

            return conexao;
        }
    }
}
