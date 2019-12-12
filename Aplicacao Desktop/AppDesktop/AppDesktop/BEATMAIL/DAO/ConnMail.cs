using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace AppDesktop.BEATMAIL.DAO
{
    internal class ConnMail
    {
        public string conexao;
        public ConnMail()
        {

            //string server = Properties.Settings.Default.ip_banco;
            //string database = Properties.Settings.Default.database;
            //string user = Properties.Settings.Default.usuario_banco;
            //string senha = Properties.Settings.Default.senha_banco;
            string server = "localhost";
            string database = "beat_mail";
            string user = "root";
            string senha = "";

            conexao = "Server=" + server + ";DataBase=" + database + ";Uid=" + user + ";Password=" + senha;


        }

        public string getConexao()
        {
            return conexao;
        }

        public bool verificaConexao()
        {

            var conn = new MySqlConnection(conexao);

            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {

                    return true;

                }
            }
            catch (Exception ex)
            {

            }

            return false;
        }

    }
}