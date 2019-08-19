using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDesktop.DAO
{
    class Config
    {
        public string conexao;
        public Config()
        {

            string server = Properties.Settings.Default.ip_banco;
            string database = Properties.Settings.Default.database;
            string user = Properties.Settings.Default.usuario_banco;
            string senha = Properties.Settings.Default.senha_banco;

            
            conexao = "Server=" + server + ";DataBase=" + database + ";Uid=" + user + ";Password=" + senha;
            

        }

        public string getConexao()
        {
            return conexao;
        }

        public Boolean verificaConexao()
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
