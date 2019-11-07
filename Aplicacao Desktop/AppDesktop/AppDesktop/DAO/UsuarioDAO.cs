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
    class UsuarioDAO : ITransaction
    {
        Config config = new Config();
        public Usuario validaLogin(Usuario user)
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            try
            {
                connection.Open();


                command.CommandText = "select * from tb_usuario where login='" + user.Login + "' and senha='" + user.Senha +
                    "'";
                var result = command.ExecuteReader();

                if (result.Read())
                {
                    user.Id = result.GetInt32("id");

                    return user;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();

            }
            return null;
        }

        internal Usuario BuscaUsuario(string login)
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            try
            {
                connection.Open();


                command.CommandText = "select * from tb_usuario where login='" + login + "'";
                var result = command.ExecuteReader();
                Usuario usuario = new Usuario();
                if (result.Read())
                {
                    usuario.Id = result.GetInt32("id");
                    usuario.Login = result.GetString("login");
                    usuario.Senha = result.GetString("senha");
                    return usuario;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("OCORREU UM ERRO AO BUSCAR USUARIO");
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();

            }
            return null;

        }

        internal bool VerificaPrimeiroLogin(Usuario user)
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            try
            {
                connection.Open();


                command.CommandText = "SELECT * FROM tb_usuario_acesso where id_usuario=" + user.Id;
                var result = command.ExecuteReader();
                if (result.Read())
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro ao cadastrar usuário!" + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();

            }

            return false;
        }

        public void CriaLogin(Usuario user)
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            try
            {
                connection.Open();


                command.CommandText = "insert into tb_usuario(login,senha) values('" + user.Login + "','" + user.Senha +
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

        internal void RemovePrimeiroAcesso(Usuario user)
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            try
            {
                connection.Open();


                command.CommandText = "delete from tb_usuario_acesso where id_usuario =" + user.Id;
                command.ExecuteNonQuery();
               


            }
            catch (Exception ex)
            {
                MessageBox.Show("Desculpe, um erro inesperado ocorreu!" + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();

            }
        }

        internal void RedefineSenha(string nova_senha, int id)
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            try
            {
                connection.Open();


                command.CommandText = "update tb_usuario set senha='" + nova_senha + "' where id =" + id;
                command.ExecuteNonQuery();
                MessageBox.Show("SHOW! Sua senha foi redefinida!");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Desculpe, um erro inesperado ocorreu e não foi possivel redefinir sua senha!" + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();

            }
        }
        internal void AtualizaEmailUsuario(Usuario usuario)
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            try
            {
                connection.Open();


                command.CommandText = "update tb_usuario set email='" + usuario.Email + "' where id =" + usuario.Id;
                command.ExecuteNonQuery();
               


            }
            catch (Exception ex)
            {
                MessageBox.Show("Desculpe, um erro inesperado ocorreu e não foi possivel salvar suas informações!" + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();

            }
        }

        public MySqlConnection Conecta()
        {
            throw new NotImplementedException();
        }

        public MySqlTransaction CriaTransaction(MySqlConnection conn)
        {
            throw new NotImplementedException();
        }

    }
}
