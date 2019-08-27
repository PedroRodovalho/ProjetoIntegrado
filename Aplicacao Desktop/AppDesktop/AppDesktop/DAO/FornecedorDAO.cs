using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace AppDesktop.DAO
{
    class FornecedorDAO
    {
        Config config = new Config();
        public void Cadastra_fornecedor(Fornecedor fornecedor)
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            try
            {
                connection.Open();
                command.CommandText = "insert into tb_fornecedor(codigo,nome,tel,email) values('" + fornecedor.Codigo + "','" + fornecedor.Nome + "','" + fornecedor.Tel + "','" + fornecedor.Email + "'";
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open) connection.Close();
            }


        }

        public List<Fornecedor> Lista_fornecedores()
        {

            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            try
            {
                connection.Open();
                command.CommandText = "select * from tb_fornecedor";
                var result = command.ExecuteReader();
                List<Fornecedor> fornecedores = new List<Fornecedor>();
                while (result.Read())
                {
                    Fornecedor fornecedor = new Fornecedor();
                    fornecedor.Id = result.GetInt32("id");
                    fornecedor.Codigo = result.GetInt32("codigo");
                    fornecedor.Nome = result.GetString("nome");
                    fornecedor.Tel = result.GetString("tel");
                    fornecedor.Email = result.GetString("email");

                    fornecedores.Add(fornecedor);
                }
                return fornecedores;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open) connection.Close();
            }

            return null;
        }
    }

}
