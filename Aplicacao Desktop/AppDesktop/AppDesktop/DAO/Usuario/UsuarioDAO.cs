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
        Conversor conversor = new Conversor();
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
                    user.Id_permissao = result.GetInt32("id_permissao");
                    user.Ativo = result.GetInt32("ativo");
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

        internal void EnviaNotificacao(Notificacao notificacao)
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            
            try
            {
                connection.Open();
                command.CommandText = "insert into tb_notificacao values(0,@id_remetente,@id_destinatario,@assunto,@mensagem,@tipo,'NÃO VISUALIZADA')";
                command.Parameters.AddWithValue("@id_remetente", notificacao.Id_remetente);
                command.Parameters.AddWithValue("@id_destinatario", notificacao.Id_destinatario);
                command.Parameters.AddWithValue("@assunto", notificacao.Assunto);
                command.Parameters.AddWithValue("@mensagem", notificacao.Mensagem);
                command.Parameters.AddWithValue("@tipo", notificacao.Tipo);
                command.ExecuteNonQuery();

            } catch(MySqlException ex) {
                MessageBox.Show("Não foi possivel enviar notificacão! " +ex.SqlState);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();

            }
        }
        internal List<PerfilAcesso> ListaPerfisAcesso()
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            List<PerfilAcesso> perfilAcessos = new List<PerfilAcesso>();
            try
            {
                connection.Open();


                command.CommandText = "select * from tb_perfil_acesso";
                var result = command.ExecuteReader();
                while (result.Read())
                {
                    PerfilAcesso perfilAcesso = new PerfilAcesso();
                    perfilAcesso.Id = result.GetInt32("id");
                    perfilAcesso.NomeAcesso = result.GetString("nome_acesso");
                    perfilAcesso.Status = result.GetString("status");

                    perfilAcessos.Add(perfilAcesso);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("HOUVE UM ERRO LISTAR PERFIS DE ACESSO: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();

            }


            return perfilAcessos;
        }

        internal List<PerfilAcessoUsuario> BuscaPerfilAcessoUsuario(int id)
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            List<PerfilAcessoUsuario> perfilAcessos = new List<PerfilAcessoUsuario>();
            try
            {
                connection.Open();


                command.CommandText = "select u.*,p.nome_acesso from tb_perfil_acesso_usuario u, tb_perfil_acesso p where u.id_usuario=" + id + " and u.fk_perfil_acesso = p.id";
                var result = command.ExecuteReader();
                while (result.Read())
                {
                    PerfilAcessoUsuario perfilAcessoUsuario = new PerfilAcessoUsuario();
                    perfilAcessoUsuario.Id = result.GetInt32("fk_perfil_acesso");
                    perfilAcessoUsuario.Id_usuario = result.GetInt32("id_usuario");
                    perfilAcessoUsuario.NomeAcesso = result.GetString("nome_acesso");
                    perfilAcessoUsuario.Status = result.GetString("status");

                    perfilAcessos.Add(perfilAcessoUsuario);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("HOUVE UM ERRO LISTAR PERFIS DE ACESSO: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();

            }


            return perfilAcessos;
        }

        internal void InserePerfilAcesso(int id_perfil_acesso, int id_usuario, string status)
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            try
            {
                connection.Open();
                command.CommandText = "insert into tb_perfil_acesso_usuario values(0,@id_usuario,@fk_perfil_acesso,@status) ";
                command.Parameters.AddWithValue("@id_usuario", id_usuario);
                command.Parameters.AddWithValue("@fk_perfil_acesso", id_perfil_acesso);
                command.Parameters.AddWithValue("@status", status);
                command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro ao inserir perfil de acesso para o usuario" + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();

            }
        }

        internal void BloqueiaUsuario(int id)
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            try
            {
                connection.Open();
                command.CommandText = "update tb_usuario set ativo = 0 where id=" + id;
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel inativar usuário: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();

            }
        }

        internal void DeletaUsuario(int id)
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            try
            {
                connection.Open();
                command.CommandText = "delete from tb_usuario where id=" + id;
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel deletar usuário: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();

            }

        }

        internal void AtualizaUsuario(Usuario usuario_upd)
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            try
            {
                connection.Open();


                command.CommandText = "update tb_usuario set login = @login,senha=@senha,email = @email,nome = @nome_completo, cargo= @cargo where id =" + usuario_upd.Id;
                command.Parameters.AddWithValue("@login", usuario_upd.Login);
                command.Parameters.AddWithValue("@senha", usuario_upd.Senha);
                command.Parameters.AddWithValue("@email", usuario_upd.Email);
                command.Parameters.AddWithValue("@cargo", usuario_upd.Cargo);
                command.Parameters.AddWithValue("@nome_completo", usuario_upd.Nome);

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

        internal List<Usuario> BuscaUsuarioLikeNome(string nome)
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            try
            {
                connection.Open();


                command.CommandText = "select * from tb_usuario where nome_completo like '%" + nome + "%'";

                var result = command.ExecuteReader();
                List<Usuario> usuarios = new List<Usuario>();
                while (result.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.Id = result.GetInt32("id");
                    usuario.Login = result.GetString("login");
                    usuario.Email = result.GetString("email");
                    usuario.Nome = result.GetString("nome_completo");
                    usuario.Cargo = result.GetString("cargo");
                    usuario.Ativo = result.GetInt32("ativo");

                    usuarios.Add(usuario);

                }
                return usuarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar usuário por nome: " + ex.Message);
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
                    usuario.Email = result.GetString("email");
                    usuario.Nome = result.GetString("nome");
                    usuario.Cargo = result.GetString("cargo");
                    usuario.Id_permissao = result.GetInt32("id_permissao");
                    usuario.Ativo = result.GetInt32("ativo");
                    return usuario;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("OCORREU UM ERRO AO BUSCAR USUARIO: " + ex.Message);
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


                command.CommandText = "insert into tb_usuario(login,senha,email,nome_completo,cargo,ativo) values(@login,@senha,@email,@cargo,@nome_completo,@ativo)";
                command.Parameters.AddWithValue("@login", user.Login);
                command.Parameters.AddWithValue("@senha", user.Senha);
                command.Parameters.AddWithValue("@email", user.Email);
                command.Parameters.AddWithValue("@cargo", user.Cargo);
                command.Parameters.AddWithValue("@nome_completo", user.Nome);
                command.Parameters.AddWithValue("@ativo", user.Ativo);
                MessageBox.Show("Usuário cadastrado com sucesso!");
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

        internal Perfil BuscaPerfil(Usuario usuario)
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            try
            {
                connection.Open();
                Perfil p = new Perfil();
                command.CommandText = "SELECT * FROM tb_perfil where id_usuario=" + usuario.Id;
                var result = command.ExecuteReader();
                if (result.Read())
                {
                    p.Id = result.GetInt32("id");
                    p.Nome = result.GetString("nome");
                    p.Telefone = result.GetString("telefone");
                    p.Data_nascimento = conversor.toDateTimeBR(result.GetMySqlDateTime("data_nascimento"));
                    p.Data_cadastro = conversor.toDateTimeBR(result.GetMySqlDateTime("data_entrada"));
                    p.Ativo = result.GetInt32("ativo");
                }
                return p;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO BUSCAR PERMISSAO : " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();
            }
            return null;
        }

        internal List<Notificacao> CarregaNotificacao(int id)
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            List<Notificacao> lista_notificacao = new List<Notificacao>();
            try
            {
                connection.Open();

                command.CommandText = "SELECT n.*,u.nome as nome_remetente FROM tb_notificacao n ,tb_usuario u where n.id_destinatario=@id and n.id_remetente = u.id";
                command.Parameters.AddWithValue("@id", id);
                var result = command.ExecuteReader();
                while (result.Read())
                {
                    Notificacao notificacao = new Notificacao();
                    notificacao.Assunto = result.GetString("assunto");
                    notificacao.Mensagem = result.GetString("mensagem");
                    notificacao.Id_destinatario = result.GetInt32("id_destinatario");
                    notificacao.Id_remetente = result.GetInt32("id_remetente");
                    notificacao.NomeRemetente = result.GetString("nome_remetente");
                    notificacao.Tipo = result.GetString("tipo");
                    notificacao.Status = result.GetString("status");

                    lista_notificacao.Add(notificacao);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro ao carregar notificações! " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();
            }
            return lista_notificacao;
        }
    } 
}
