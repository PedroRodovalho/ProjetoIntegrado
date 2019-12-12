
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppDesktop.DAO;
using MySql.Data.MySqlClient;

namespace AppDesktop
{
    class VendaDAO : ITransaction
    {

        MySqlTransaction transaction;
        MySqlConnection conn;
        Conversor conversor = new Conversor();
        Config conexao = new Config();

        //INSERCAO DE NOVA VENDA
        public MySqlTransaction InsereVenda(Venda venda)
        {

            conn = Conecta();
            this.transaction = CriaTransacao(conn);
            MySqlCommand command = conn.CreateCommand();
            command.Transaction = transaction;


            try
            {
                command.CommandText = "insert into tb_venda(data_venda,valor_total,valor_final,quantidade_itens,regra_aplicada) values(@data,@valor_total," +
                    "@valor_final,@quantidade_itens,@regra_aplicada)";

                /*
                 CREATE TABLE tb_venda(id int not null auto_increment,
                     data varchar(50) not null,
                     valor_total double not null,
                     valor_final double not null,
                     quantidade_itens int not null,
                     regra_aplicada int not null,
                     primary key(id)));

                  */

                command.Parameters.AddWithValue("@data", venda.Data);
                command.Parameters.AddWithValue("@valor_total", conversor.toDoubleDB(venda.Valor_total.ToString()));
                command.Parameters.AddWithValue("@valor_final", conversor.toDoubleDB(venda.Valor_final.ToString()));
                command.Parameters.AddWithValue("@quantidade_itens", venda.Quantidade_itens);
                command.Parameters.AddWithValue("@regra_aplicada", venda.Regra_aplicada);



                command.ExecuteNonQuery();

                //int last_id = conversor.ToInt32(command.LastInsertedId.ToString());
                return transaction;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Não foi possivel registrar lancamento, desfazendo alterações" + ex.Message, "Erro");
                try
                {
                    transaction.Rollback();
                }
                catch (MySqlException mEx)
                {
                    MessageBox.Show("Erro ao realizar Rollback " + mEx.Message);

                }

            }

            return null;
        }

        internal List<ItemVenda> ListaItensVenda()
        {
            conn = Conecta();

            MySqlCommand command = conn.CreateCommand();

            try
            {
                command.CommandText = "SELECT p.produto, iv.* from tb_estoque p ,tb_item_venda iv where p.id = iv.id_produto";
                var result = command.ExecuteReader();
                List<ItemVenda> itens = new List<ItemVenda>();
                while (result.Read())
                {
                    ItemVenda iv = new ItemVenda();

                    iv.Id = result.GetInt32("id");
                    iv.Id_venda = result.GetInt32("id_venda");
                    iv.Id_produto = result.GetInt32("id_produto");
                    iv.Item = result.GetString("produto");
                    iv.Id_promocao = result.GetInt32("id_promocao");
                    iv.Preco = result.GetDouble("preco");
                    iv.Quantidade = result.GetInt32("quantidade");

                    itens.Add(iv);

                    
                }
                return itens;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO A " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) Desconecta();
            }
            
            return null;

        }

        public void atualizaVFVenda(Venda venda)
        {

            conn = Conecta();

            MySqlCommand command = conn.CreateCommand();



            try
            {
                command.CommandText = "update tb_venda set valor_final = '" + conversor.toDoubleDB(venda.Valor_final.ToString()) + "', regra_aplicada =" + venda.Regra_aplicada + " where id=" + venda.Id;
                command.ExecuteNonQuery();



            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERRO AO ATULIZAR " + ex.Message);

            }


        }

        public int GetLastIdVenda()
        {
            conn = Conecta();
            MySqlCommand command = conn.CreateCommand();

            try
            {
                command.CommandText = "SELECT MAX(id) from tb_venda";
                var result = command.ExecuteReader();
                if (result.Read()) return result.GetInt32("MAX(id)");

            }
            catch (Exception ex)
            {
                System.Console.Write("Erro: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) Desconecta();
            }
            return 0;

        }

        internal List<Venda> ListarVendasByData(string v)
        {
            conn = Conecta();
            MySqlCommand command = conn.CreateCommand();
            
            List<Venda> vendas = new List<Venda>();
            try
            {
                command.CommandText = "SELECT * from tb_venda where data_venda='" +
                    conversor.toDateTimeDB(v) + "'";
                var result = command.ExecuteReader();
                while (result.Read())
                {
                    Venda venda = new Venda();
                    venda.Id = result.GetInt32("id");
                    venda.Data = conversor.toDateTimeBR(result.GetMySqlDateTime("data_venda"));
                    venda.Valor_final = result.GetDouble("valor_final");
                    venda.Valor_total = result.GetDouble("valor_total");
                    venda.Quantidade_itens = result.GetInt32("quantidade_itens");
                    venda.Regra_aplicada = result.GetInt32("regra_aplicada");

                    vendas.Add(venda);
                }
                return vendas;
            }
            catch
            {

            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return vendas;
        }

        public void InsereItensVenda(List<ItemVenda> itens)
        {
            conn = Conecta();
            MySqlCommand command = conn.CreateCommand();

            try
            {
                //         private int id;
                //private int id_venda;

                //private string produto;
                //private double preco;
                //private int quantidade;
                //private int id_promocao;
                
                
                foreach (ItemVenda item in itens)
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    command.CommandText = "insert into tb_item_venda" +
                                " values(null,'" + item.Id_venda+"','"+ item.Id_produto +"','"+ conversor.toDoubleDB(item.Preco.ToString()) +"','"+ item.Quantidade +"','"+ item.Id_promocao +"')";
                    MessageBox.Show(" B"+item.Id_venda);


                    command.ExecuteNonQuery();
                conn.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel registrar lancamento, desfazendo alterações" + ex.Message, "Erro");
                try
                {
                    //transaction.Rollback();
                }
                catch (MySqlException mEx)
                {
                    MessageBox.Show("Erro ao realizar Rollback " + mEx.Message);

                }

            }
            finally
            {
                if (conn.State == ConnectionState.Open) Desconecta();
            }
        }


        public void InserePagamento(Pagamento pagamento)
        {
            conn = Conecta();
            MySqlCommand command = conn.CreateCommand();

            try
            {
                command.CommandText = "insert into tb_pagamento(id_venda,valor,forma_pagamento,quantidade_parcelas)" +
                    " values(@id_venda,@valor,@forma_pagamento,@quantidade_parcelas)";

                command.Parameters.AddWithValue("@id_venda", pagamento.Id_venda);
                command.Parameters.AddWithValue("@valor", conversor.toDoubleDB(pagamento.Valor.ToString()));
                command.Parameters.AddWithValue("@forma_pagamento", pagamento.Forma_pagamento);
                command.Parameters.AddWithValue("@quantidade_parcelas", pagamento.Quantidade_parcelas);

                command.ExecuteNonQuery();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel registrar lancamento, desfazendo alterações" + ex.Message, "Erro");


            }
            finally
            {
                if (conn.State == ConnectionState.Open) Desconecta();
            }
        }
        public void InserePagamento(List<Pagamento> pagamentos)
        {
            conn = Conecta();
            MySqlCommand command = conn.CreateCommand();
            for (int i = 0; i < pagamentos.Count; i++)
            {
                Pagamento pagamento = pagamentos[i];
                try
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                        
                    command.CommandText = "insert into tb_pagamento(id_venda, valor,forma_pagamento,quantidade_parcelas)" +
                        " values(@id_venda,@valor,@forma_pagamento,@quantidade_parcelas)";

                    command.Parameters.AddWithValue("@id_venda", pagamento.Id_venda);
                    command.Parameters.AddWithValue("@valor", conversor.toDoubleDB(pagamento.Valor.ToString()));
                    command.Parameters.AddWithValue("@forma_pagamento", pagamento.Forma_pagamento);
                    command.Parameters.AddWithValue("@quantidade_parcelas", pagamento.Quantidade_parcelas);

                    command.ExecuteNonQuery();

                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel registrar lancamento, desfazendo alterações" + ex.Message, "Erro");


                }
                finally
                {
                    if (conn.State == ConnectionState.Open) Desconecta();
                }


            }
        }
        //CONSULTAS//

        public List<Venda> ListarVendas()
        {
            conn = Conecta();
            MySqlCommand command = conn.CreateCommand();
            List<Venda> vendas = new List<Venda>();
            try
            {
                command.CommandText = "select * from tb_venda";
                var result = command.ExecuteReader();
                while (result.Read())
                {
                    Venda venda = new Venda();
                    venda.Id = result.GetInt32("id");
                    venda.Data = conversor.toDateTimeBR(result.GetMySqlDateTime("data_venda"));
                    venda.Valor_final = result.GetDouble("valor_final");
                    venda.Valor_total = result.GetDouble("valor_total");
                    venda.Quantidade_itens = result.GetInt32("quantidade_itens");
                    venda.Regra_aplicada = result.GetInt32("regra_aplicada");

                    vendas.Add(venda);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("a"+ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }

            return vendas;

        }

        public List<Venda> listarVendas(string date_start, string date_end)
        {


            conn = Conecta();
            MySqlCommand command = conn.CreateCommand();
            List<Venda> listVenda = null;
            try
            {
                listVenda = new List<Venda>();
                
                command.CommandText = "SELECT * FROM tb_venda WHERE data_venda BETWEEN ('" + date_start + "') AND ('" + date_end + "')";
                var result = command.ExecuteReader();
                while (result.Read())
                {
                    Venda venda = new Venda();
                    venda.Id = result.GetInt32("id");
                    venda.Data = conversor.toDateTimeBR(result.GetMySqlDateTime("data_venda"));
                    venda.Valor_final = result.GetDouble("valor_final");
                    venda.Valor_total = result.GetDouble("valor_total");
                    venda.Quantidade_itens = result.GetInt32("quantidade_itens");
                    venda.Regra_aplicada = result.GetInt32("regra_aplicada");

                    listVenda.Add(venda);
                }
                return listVenda;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na listagem de vendas: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return null;
        }

        internal double SomaVendaFinalByData(string data_venda)
        {
            conn = Conecta();
            MySqlCommand command = conn.CreateCommand();
            double sum = 0;
            try
            {
                command.CommandText = "SELECT sum(valor_final) as soma from tb_venda where data_venda='" +
                    conversor.toDateTimeDB(data_venda)+"'";
                var result = command.ExecuteReader();
                if (result.Read())
                {
                    sum = result.GetDouble("soma");
                }
                return sum;
            }
            catch
            {

            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return sum;
        }

        private MySqlConnection Conecta()
        {
            string connString = conexao.getConexao();
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            return conn;
        }

        private MySqlTransaction CriaTransacao(MySqlConnection conn)
        {
            if (conn.State != ConnectionState.Open)
            {
                Console.Write("Conexão não esta aberta\n");
                Console.Write("Abrindo conexão");
                conn.Open();
            }

            transaction = conn.BeginTransaction();
            return transaction;
        }

        public void CommitTransaction(MySqlTransaction transaction)
        {
            try
            {
                transaction.Commit();
                MessageBox.Show("VENDA REALIZADA COM SUCESSO.");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Houve um erro ao commitar:" + ex.Message);
            }
            finally
            {
                transaction.Connection.Close();
            }

        }

        public void InsereHistoricoCliente(int id_venda, int id_cliente)
        {
            conn = Conecta();
            MySqlCommand command = conn.CreateCommand();

            try
            {
                command.CommandText = "insert into tb_historico_cliente(id_venda,id_cliente) values(@id_venda,@id_cliente)";
                command.Parameters.AddWithValue("@id_venda", id_venda);
                command.Parameters.AddWithValue("@id_cliente", id_cliente);
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Venda não registrada ao historico do cliente" + ex.Message);
            }


        }

        public void Desconecta()
        {
            //conn.Close();
        }

        MySqlConnection ITransaction.Conecta()
        {
            throw new NotImplementedException();
        }

        public MySqlTransaction CriaTransaction(MySqlConnection conn)
        {
            throw new NotImplementedException();
        }
    }

    //TABELAS
    /*create table tb_pagamento(
       id int not null auto_increment,
       valor double not null,
       forma_pagamento varchar(50) not null,
       quantidade_parcelas int not null,
       primary key(id)); */
    //        private int id;
    //private int id_venda;
    //private int valor;
    //private string forma_pagamento;
    //private int quantidade_parcelas;
}

