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

        public void insere_cliente(Cliente cliente)
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            try
            {
                connection.Open();
                command.CommandText = "insert into tb_cliente(nome,telefone_tipo_cliente,cpf,data_nascimento,data_cadastro) values('" +
                    cliente.Nome +"','" + cliente.Telefone + "','" + cliente.Tipo_cliente + "','" + cliente.Cpf + "','" + cliente.Data_nascimento
                    + "','" +cliente.Data_cadastro + "')";
                command.ExecuteNonQuery();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally{
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
                while (result.Read()) {
                    cliente.Id = result.GetInt32("id");
                    cliente.Nome = result.GetString("nome");
                    cliente.Telefone = result.GetString("telefone");
                    cliente.Tipo_cliente = result.GetString("tipo_cliente");
                    cliente.Cpf = result.GetString("cpf");
                    cliente.Data_nascimento = result.GetString("data_nascimento");
                    cliente.Data_cadastro = result.GetString("data_cadastro");

                }
                return cliente;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();
            }

            return null;
        }
    }
}
