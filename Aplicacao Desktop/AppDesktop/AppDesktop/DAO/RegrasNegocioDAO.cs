using AppDesktop.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDesktop
{
    class RegrasNegocioDAO : ITransaction
    {
        Config config = new Config();
        Conversor conversor = new Conversor();
        int id = 0;

        public int CriaRegraNegocio(RegrasNegocio regra)
        {
            MySqlConnection connection = Conecta();
            MySqlCommand command = connection.CreateCommand();
            try
            {
   
                command.CommandText = "INSERT INTO tb_regra_negocio(nome,tipo_venda,tipo,parcela_min,parcela_max,ativa) values('" + regra.Nome + "','" +
                    regra.Tipo_venda + "','" + regra.Tipo + "','" + regra.Parcela_min + "','" + regra.Parcela_max + "','Y')";
                
                command.ExecuteNonQuery();
                connection.Close();
                connection.Open();
                
                command.CommandText = "SELECT max(id) from tb_regra_negocio";
                var result = command.ExecuteReader();
                if (result.Read())
                {
                    id = result.GetInt32(0);
                }
                return id;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open) connection.Close();

            }
            return 0;

        }
        public void InsereRegra_Quantidade(RegraBy_quantidade regra)
        {
            MySqlConnection connection = Conecta();
            MySqlCommand command = connection.CreateCommand();
            try
            {
                command.CommandText = "insert into tb_regra_quantidade(id_regra,condicao,quantidade,desconto) values(@id_regra" +
                    ",@condicao,@quantidade,@desconto)";

                command.Parameters.AddWithValue("@id_regra", id);
              
                command.Parameters.AddWithValue("@condicao", regra.Condicao);
                command.Parameters.AddWithValue("@quantidade", regra.Quantidade);
                command.Parameters.AddWithValue("@desconto", conversor.toDoubleDB(regra.Desconto.ToString()));

                command.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Regra de quantidade não criada " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();
            }
        }

        public void InsereRegra(Regra regra)
        {
            MySqlConnection connection = Conecta();
            MySqlCommand command = connection.CreateCommand();
            try
            {
                command.CommandText = "insert into tb_regra(id_regra,atribuicao,condicao,parametro,desconto) values(@id_regra,@atribuicao" +
                    ",@condicao,@parametro,@desconto)";

                command.Parameters.AddWithValue("@id_regra", id);
                command.Parameters.AddWithValue("@atribuicao", regra.Atribuicao);
               
                command.Parameters.AddWithValue("@condicao", regra.Condicao);
                command.Parameters.AddWithValue("@parametro", regra.Parametro);
                command.Parameters.AddWithValue("@desconto", conversor.toDoubleDB(regra.Desconto.ToString()));

                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Regra valor de produto não criada " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();
            }
        }

        public void InsereRegra_ValorTotal(RegraBy_valorTotal regra)
        {
            MySqlConnection connection = Conecta();
            MySqlCommand command = connection.CreateCommand();
            try
            {
                command.CommandText = "insert into tb_regra_valor_total(id_regra,condicao,valor_total,desconto) values(@id_regra," +
                    ",@condicao,@valor,@desconto)";

                command.Parameters.AddWithValue("@id_regra", id);
               
                command.Parameters.AddWithValue("@condicao", regra.Condicao);
                command.Parameters.AddWithValue("@valor", regra.Valor);
                command.Parameters.AddWithValue("@desconto", conversor.toDoubleDB(regra.Desconto.ToString()));

                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Regra valor total não criada " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();
            }
        }

        internal List<RegrasNegocio> ListaRegras()
        {
            MySqlConnection connection = Conecta();
            MySqlCommand command = connection.CreateCommand();
            List<RegrasNegocio> regras = new List<RegrasNegocio>();
            try
            {
                command.CommandText = "select * from tb_regra_negocio";
                var result = command.ExecuteReader();
                while (result.Read())
                {
                    RegrasNegocio regra = new RegrasNegocio();
                    regra.Id = result.GetInt32("id");
                    regra.Nome = result.GetString("nome");
                    regra.Tipo = result.GetString("tipo");
                    regra.Tipo_venda = result.GetString("tipo_venda");
                    regra.Parcela_max = result.GetInt32("parcela_max");
                    regra.Parcela_min = result.GetInt32("parcela_min");
                    regra.Ativa = result.GetString("ativa");

                    regras.Add(regra);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar regras " + ex.Message);
            }
            finally { if (connection.State == ConnectionState.Open) connection.Close(); }

            return regras;
        }

        public List<Regra> buscaRegrasExistentes(int id)
        {
            MySqlConnection connection = Conecta();
            MySqlCommand command = connection.CreateCommand();
            List<Regra> regras = new List<Regra>();
            try
            {
                command.CommandText = "select * from tb_regra where id_regra="+id;
                var result = command.ExecuteReader();
                
                while (result.Read())
                {
                    Regra regra = new Regra();
                    regra.Id = result.GetInt32("id");
                    regra.Id_regra = result.GetInt32("id_regra");
                    regra.Atribuicao= result.GetString("atribuicao");
                    regra.Condicao = result.GetString("condicao");
                    regra.Parametro = result.GetDouble("parametro");
                    regra.Desconto = result.GetDouble("desconto");

                    regras.Add(regra);
                }

                return regras;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();
            }

            return regras;
        }

        public RegrasNegocio buscaRegraAtiva(string forma_pagamento)
        {
            MySqlConnection connection = Conecta();
            MySqlCommand command = connection.CreateCommand();

            RegrasNegocio regra = new RegrasNegocio() ;
            try
            {
                command.CommandText = "select * from tb_regra_negocio where ativa='Y' and tipo_venda ='"+forma_pagamento+"'";
                var result = command.ExecuteReader();
                if (result.Read())
                {
                    regra.Id = result.GetInt32("id");
                    regra.Nome = result.GetString("nome");
                    regra.Parcela_max = result.GetInt32("parcela_max");
                    regra.Parcela_min = result.GetInt32("parcela_min");
                    regra.Tipo = result.GetString("tipo");
                    regra.Tipo_venda = result.GetString("tipo_venda");
                    


                }

                return regra;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();
            }

            return regra;
        }
    

        
       

        public List<RegrasNegocio> busca_regra()
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            try
            {
                connection.Open();
                command.CommandText = "select * from tb_regra_negocio";

                var result = command.ExecuteReader();
                List<RegrasNegocio> regras = new List<RegrasNegocio>();
                while (result.Read())
                {
                    RegrasNegocio regra_negocio = new RegrasNegocio();

                    regra_negocio.Id = result.GetInt32("id");
                    regra_negocio.Nome = result.GetString("nome");
                    regra_negocio.Tipo = result.GetString("tipo");
                    regra_negocio.Parcela_min = result.GetInt32("parcela_min");
                    regra_negocio.Parcela_max = result.GetInt32("parcela_max");
                    regra_negocio.Tipo_venda = result.GetString("tipo_venda");

                    regras.Add(regra_negocio);

                }

                return regras;
            }
            catch (Exception Ex)
            {



                MessageBox.Show(Ex.Message);
                
                return null;
            }
        }

        public MySqlConnection Conecta()

        {
            string connString = config.getConexao();
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            return conn;
    
        }

        public MySqlTransaction CriaTransaction(MySqlConnection conn)
        {
            if (conn.State != ConnectionState.Open)
            {
                Console.Write("Conexão não esta aberta\n");
                Console.Write("Abrindo conexão");
                conn.Open();
            }

            MySqlTransaction transaction = conn.BeginTransaction();
            return transaction;
    
        }
      
    }
}
