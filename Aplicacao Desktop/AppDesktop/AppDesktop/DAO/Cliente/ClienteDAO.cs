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
    class ClienteDAO
    {
        Config config = new Config();
        Conversor conversor = new Conversor();
        public int insere_cliente(Cliente cliente)
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            int id = 0;
            try
            {
                connection.Open();
                command.CommandText = "insert into tb_cliente values(0,@nome,@telefone,@tipo_cliente,@cpf,@data_nascimento,@data_cadastro,@ativo)";

                command.Parameters.AddWithValue("@nome", cliente.Nome);
                command.Parameters.AddWithValue("@telefone", cliente.Telefone);
                command.Parameters.AddWithValue("@tipo_cliente", cliente.Tipo_cliente);
                command.Parameters.AddWithValue("@cpf", cliente.Cpf);
                command.Parameters.AddWithValue("@data_nascimento", cliente.Data_nascimento);
                command.Parameters.AddWithValue("@data_cadastro", cliente.Data_cadastro);
                command.Parameters.AddWithValue("@Ativo", cliente.Ativo);


                command.ExecuteNonQuery();

                connection.Close();
                connection.Open();
                command.CommandText = "select MAX(id) from tb_cliente";
                var result = command.ExecuteReader();
                if (result.Read())
                {
                    id = result.GetInt32("MAX(id)");
                }
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();
            }
            return id;

        }

        internal FotoCliente BuscaFoto(int id)
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            try
            {
                connection.Open();
                command.CommandText = "select * from tb_foto_cliente where id_cliente = " + id;
                var result = command.ExecuteReader();
                FotoCliente foto = new FotoCliente();
                if (result.Read())
                {
                    foto.Id = result.GetInt32("id");
                    foto.Id_cliente = id;
                    foto.Caminho_foto = result.GetString("caminho_foto");
                    foto.Nome_foto = result.GetString("nome_foto");
                    return foto;
                }
            }
            catch
            {

            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();
            }
            return null;
        }

        internal void DeletaCliente(int id)
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            try
            {
                connection.Open();
                command.CommandText = "delete from  tb_cliente where id = " + id;
                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve um erro ao excluir cliente" + ex.Message);
            }
        }

        internal void AtualizaCliente(Cliente cliente_upd)
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            try
            {
                connection.Open();
                command.CommandText = "update tb_cliente set nome =@nome,telefone = @telefone,cpf = @cpf,data_nascimento =@data_nascimento,tipo_cliente = @tipo_cliente" +
                    " where id =@id";
                command.Parameters.AddWithValue("@id", cliente_upd.Id);
                command.Parameters.AddWithValue("@nome", cliente_upd.Nome);
                command.Parameters.AddWithValue("@telefone", cliente_upd.Telefone);
                command.Parameters.AddWithValue("@cpf", cliente_upd.Cpf);
                command.Parameters.AddWithValue("@data_nascimento",conversor.toDateTimeDB(cliente_upd.Data_nascimento));
                command.Parameters.AddWithValue("@tipo_cliente", cliente_upd.Tipo_cliente);

                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Houve um erro ao inativar cliente : " + ex.Message);
            }
        }

        internal void DesativaCliente(int id)
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            try
            {
                connection.Open();
                command.CommandText = "update tb_cliente set ativo = 0 where id = " + id;
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Houve um erro ao inativar cliente : " + ex.Message);
            }
        }

        internal void AtivaCliente(int id)
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            try
            {
                connection.Open();
                command.CommandText = "update tb_cliente set ativo = 1 where id = " + id;
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex) 
            {
                MessageBox.Show("Houve um erro ao ativar cliente : " + ex.Message);
            }
        }

        internal List<HistoricoCliente> BuscaHistoricoCliente(int id)
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            List<HistoricoCliente> historico = new List<HistoricoCliente>();
            try
            {
                connection.Open();
                command.CommandText = "SELECT  h.* ,v.valor_final,v.data_venda from  tb_historico_cliente h ,tb_venda v  where h.id_cliente=" + id + " and v.id = h.id_venda;";
                var result = command.ExecuteReader();
                while (result.Read())
                {
                    HistoricoCliente historicoCliente = new HistoricoCliente();
                    historicoCliente.Id_cliente = result.GetInt32("id_cliente");
                    historicoCliente.Id_venda = result.GetInt32("id_venda");
                    historicoCliente.Valor_final = result.GetDouble("valor_final");
                    historicoCliente.Data_venda = conversor.toDateTimeBR(result.GetMySqlDateTime("data_venda"));

                    historico.Add(historicoCliente);
                }
                return historico;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro em listar o historico do cliente! " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();
            }
            return null;

        }
        
        internal Cliente BuscaClienteId(int id)
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM tb_cliente where id=" + id;
                var result = command.ExecuteReader();
                Cliente cliente = new Cliente();
                if (result.Read())
                {
                    cliente.Id = id;
                    cliente.Nome = result.GetString("nome");
                    cliente.Cpf = result.GetString("cpf");
                    cliente.Telefone = result.GetString("telefone");
                    cliente.Tipo_cliente = result.GetString("tipo_cliente");
                    cliente.Data_nascimento = conversor.toDateTimeBR(result.GetMySqlDateTime("data_nascimento"));
                    cliente.Data_cadastro = conversor.toDateTimeBR(result.GetMySqlDateTime("data_cadastro"));
                    cliente.Ativo = result.GetInt32("ativo");
                    return cliente;
                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("PROBLEMAS FORAM ENCONTRADOS! Cancelando solicitação.");
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();
            }
            return null;
        }

        internal void InsereFotoCliente(FotoCliente foto)
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = "insert into tb_foto_cliente values(0,@id_cliente,@caminho_foto,@nome_foto)";
                command.Parameters.AddWithValue("@id_cliente", foto.Id_cliente);
                command.Parameters.AddWithValue("@caminho_foto", foto.Caminho_foto);
                command.Parameters.AddWithValue("@nome_foto", foto.Nome_foto);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar foto do cliente" + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();
            }
        }

        public List<Cliente> lista_cliente()
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                connection.Open();
                command.CommandText = "select * from tb_cliente";
                var result = command.ExecuteReader();

                while (result.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.Id = result.GetInt32("id");
                    cliente.Nome = result.GetString("nome");
                    cliente.Telefone = result.GetString("telefone");
                    cliente.Tipo_cliente = result.GetString("tipo_cliente");
                    cliente.Cpf = result.GetString("cpf");
                    cliente.Data_nascimento = conversor.toDateTimeBR(result.GetMySqlDateTime("data_nascimento"));
                    cliente.Data_cadastro = conversor.toDateTimeBR(result.GetMySqlDateTime("data_cadastro"));

                    clientes.Add(cliente);
                }
                return clientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();
            }

            return clientes;
        }

        public Cliente busca_cliente_cpf(string cpf)
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            try
            {
                connection.Open();
                command.CommandText = "select * from tb_cliente where cpf='" + cpf + "'";
                var result = command.ExecuteReader();
                Cliente cliente = new Cliente();
                while (result.Read())
                {
                    cliente.Id = result.GetInt32("id");
                    cliente.Nome = result.GetString("nome");
                    cliente.Telefone = result.GetString("telefone");
                    cliente.Tipo_cliente = result.GetString("tipo_cliente");
                    cliente.Cpf = result.GetString("cpf");
                    cliente.Data_nascimento = result.GetString("data_nascimento");
                    cliente.Data_cadastro = result.GetString("data_cadastro");

                }
                return cliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();
            }


            return null;
        }
        public List<Cliente> busca_cliente_nome(string nome)
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            try
            {
                connection.Open();
                command.CommandText = "select * from tb_cliente where nome like'" + nome + "%'";
                var result = command.ExecuteReader();
                List<Cliente> clientes = new List<Cliente>();
                while (result.Read())
                {

                    Cliente cliente = new Cliente();
                    cliente.Id = result.GetInt32("id");
                    cliente.Nome = result.GetString("nome");
                    cliente.Telefone = result.GetString("telefone");
                    cliente.Tipo_cliente = result.GetString("tipo_cliente");
                    cliente.Cpf = result.GetString("cpf");
                    cliente.Data_nascimento = result.GetString("data_nascimento");

                    cliente.Data_cadastro = result.GetString("data_cadastro");
                    clientes.Add(cliente);

                }
                return clientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();
            }
            return null;


        }
        public int getLastId()
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            int id = 0;
            try

            {
                connection.Open();
                command.CommandText = "SELECT MAX(id) from tb_cliente";
                var result = command.ExecuteReader();
                while (result.Read())
                {
                    id = result.GetInt32("MAX(id)");
                }


                return id;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();
            }
            return id;
        }

        //Endereços

        public void cadastra_endereco(Endereco endereco)
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            try
            {
                connection.Open();
                command.CommandText = "insert into tb_endereco values(0,@id_cliente,@rua,@numero,@bairro,@cep,@cidade,@uf)";
                command.Parameters.AddWithValue("@id_cliente", endereco.Id_cliente);
                command.Parameters.AddWithValue("@rua", endereco.Rua);
                command.Parameters.AddWithValue("@numero", endereco.Numero);
                command.Parameters.AddWithValue("@bairro", endereco.Bairro);
                command.Parameters.AddWithValue("@cep", endereco.Cep);
                command.Parameters.AddWithValue("@cidade", endereco.Cidade);
                command.Parameters.AddWithValue("@uf", endereco.Uf);

                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao cadastrar endereço" + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();
            }

        }

    }
}
