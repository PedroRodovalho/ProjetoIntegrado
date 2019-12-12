using MySql.Data.MySqlClient;

namespace AppDesktop.BEATMAIL.DAO
{
    internal interface IConexao
    {
        MySqlConnection Conecta();
    }
}