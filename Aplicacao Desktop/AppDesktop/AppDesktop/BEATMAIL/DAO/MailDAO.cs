using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AppDesktop.BEATMAIL.DAO
{
    class MailDAO : IConexao
    {

        ConnMail conexao = new ConnMail();

        public void EnviaMensagem(Mensagem mensagem)
        {
            MySqlConnection conn = Conecta();
            MySqlCommand command = conn.CreateCommand();

            try
            {
                //command.CommandText = "insert into mensagem values(0,"",""
            }
            catch
            {

            }
        }


        public MySqlConnection Conecta()
        {
            string connString = conexao.getConexao();
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            return conn;
        }
    }


}
