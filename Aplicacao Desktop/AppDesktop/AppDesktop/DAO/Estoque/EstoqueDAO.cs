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
                command.CommandText = "insert into tb_estoque values(0,@cod,@produto,@quantidade,@custo,@preco,@data_entrada,'1',@peso,@categoria,@marca,@descricao)";
                command.Parameters.AddWithValue("@cod", estoque.Cod);
                command.Parameters.AddWithValue("@produto", estoque.Produto);
                command.Parameters.AddWithValue("@quantidade", estoque.Quantidade);
                command.Parameters.AddWithValue("@custo", conversor.toDoubleDB(estoque.Custo.ToString()));
                command.Parameters.AddWithValue("@preco", conversor.toDoubleDB(estoque.Preco.ToString()));
               
                command.Parameters.AddWithValue("@data_entrada", conversor.toDateTimeDB(estoque.Data));
                command.Parameters.AddWithValue("@fornecedor", estoque.Fornecedor);
                command.Parameters.AddWithValue("@peso", conversor.toDoubleDB(estoque.Peso.ToString()));
                command.Parameters.AddWithValue("@categoria", estoque.Categoria);
                command.Parameters.AddWithValue("@marca", estoque.Marca);
                command.Parameters.AddWithValue("@descricao", estoque.Descricao);
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

        internal List<Fornecedor> ListaFornecedores()
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            try
            {
                connection.Open();
                List<Fornecedor> fornecedores = new List<Fornecedor>();
                command.CommandText = "select * from tb_fornecedor";
                var result = command.ExecuteReader();
                while (result.Read())
                {
                    Fornecedor fornecedor = new Fornecedor();
                    fornecedor.Id = result.GetInt32("id");
                    fornecedor.Nome = result.GetString("nome");
                    fornecedor.Cnpj = result.GetString("cnpj");
                    fornecedor.Email = result.GetString("email");
                    fornecedor.Tel = result.GetString("contato");
                    fornecedores.Add(fornecedor);
                }
                return fornecedores;
                

            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao listar fornecedores: " + ex.Message);
            }

            return null;
        }

        internal void CadastraCategoria(string categoria)
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            try
            {
                connection.Open();

                command.CommandText = "insert into tb_categoria values(null,'"+categoria+"')";
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
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
                    estoque.Data = conversor.toDateTimeBR(result.GetMySqlDateTime("data_entrada")); 
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
        public List<Categoria> ListaCategorias()
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            try
            {
                connection.Open();
                command.CommandText = "select * from tb_categoria";
                var result = command.ExecuteReader();
                List<Categoria> categorias  = new List<Categoria>();
                while (result.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.Id = result.GetInt32("id");
                    categoria.Nome = result.GetString("categoria");
                    categorias.Add(categoria);
                }
                return categorias;
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
    

        public Estoque buscaProdutoByCod(int cod)
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            try
            {
                connection.Open();
                command.CommandText = "select * from tb_estoque where cod='"+cod+"'";
                var result = command.ExecuteReader();
                Estoque estoque = new Estoque();
                while (result.Read())
                {
                    
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
                    
                }
                return estoque;
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

        internal void DeletaProduto(int id)
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            try
            {
                connection.Open();
                command.CommandText = "delete from tb_estoque where id=" + id;
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO DELETAR PRODUTO: " + ex.Message);
            }
        }
    }
}
