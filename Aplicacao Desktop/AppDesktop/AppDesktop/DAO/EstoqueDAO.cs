using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace AppDesktop.DAO
{

    
    class EstoqueDAO
    {
        Config config = new Config();
        Conversor conversor = new Conversor();
        public void insere_Estoque(Estoque estoque)
        {
           var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            try
            {
                connection.Open();

                command.CommandText = "Insert into tb_estoque(cod,produto,quantidade,custo,preco,data_entrada,fornecedor,peso,categoria,marca,descricao) values('" +
                    estoque.Cod + "','" + estoque.Produto + "','" + estoque.Quantidade + "','" + conversor.toDoubleDB(estoque.Custo.ToString()) + "','"+ conversor.toDoubleDB(estoque.Preco.ToString()) +"','" +estoque.Data +"','" +
                    estoque.Fornecedor + "','"+ conversor.toDoubleDB(estoque.Peso.ToString()) + "','" + estoque.Categoria + "','"+ estoque.Marca + "','" + estoque.Descricao+"'";
                command.ExecuteNonQuery();

            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();
            }
        }

        public List<Estoque> lista_estoque()
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            try
            {
                connection.Open();
                command.CommandText = "select * from tb_estoque";
                var result = command.ExecuteReader();
                List<Estoque> produtos = new List<Estoque>();
                while (result.Read())
                {
                    Estoque estoque = new Estoque();
                    estoque.Id = result.GetInt32("id");
                    estoque.Cod = result.GetInt32("cod");
                    estoque.Produto = result.GetString("produto");
                    estoque.Quantidade = result.GetInt32("quantidade");
                    estoque.Custo = result.GetDouble("custo");
                    estoque.Preco = result.GetDouble("preco");
                    estoque.Peso = result.GetDouble("peso");
                    estoque.Categoria = result.GetString("categoria");
                    estoque.Fornecedor = result.GetInt32("fornecedor");
                    estoque.Marca = result.GetString("marca");
                    estoque.Descricao = result.GetString("descricao");
                    produtos.Add(estoque);
                }
                return produtos;
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

    }
}
