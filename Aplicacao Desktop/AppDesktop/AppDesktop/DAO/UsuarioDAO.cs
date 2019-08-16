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
    class UsuarioDAO
    {
        Config config = new Config();
        public Usuario validaLogin(Usuario user)
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            try
            {
                connection.Open();
                

                command.CommandText = "select * from tb_usuario where login='"+user.Login+"' and senha='"+user.Senha+
                    "'";
                var result = command.ExecuteReader();

                if (result.Read())
                {
                    user.Id = result.GetInt32("id");

                    return user;
                }
            }
            catch(Exception ex) {

            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();

            }
            return null;
        }
        public void criaLogin(Usuario user)
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            try
            {
                connection.Open();


                command.CommandText = "insert into tb_usuario(login,senha) values('"+user.Login +"','"+ user.Senha +
                    "'";
                command.ExecuteNonQuery();

             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro ao cadastrar usuário!" + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();

            }
            
        }
    
    }
}
