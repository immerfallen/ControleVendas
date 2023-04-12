using MySql.Data.MySqlClient;
using System.Configuration;

namespace ControleVendas.CONEXAO
{
    public class ConnectionFactory
    {
        public MySqlConnection GetConnection()
        {

            string conexao = ConfigurationManager.ConnectionStrings["bdvendas"].ConnectionString;

            return new MySqlConnection(conexao);
        }
    }
}
