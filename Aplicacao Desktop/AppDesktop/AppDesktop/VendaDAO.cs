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

        //public void InsereItensVenda(List<Item_Caixa> itens)
        //{
        //    conn = Conecta();
        //    MySqlCommand command = conn.CreateCommand();

        //    try
        //    {
        //        command.CommandText = "insert into tb_itens_venda(id_venda, valor,forma_pagamento,quantidade_parcelas)" +
        //            " values(@id_venda,@valor,@forma_pagamento,@quantidade_parcelas)";

        //        command.Parameters.AddWithValue("@id_venda", pagamento.Id_venda);
        //        command.Parameters.AddWithValue("@valor", conversor.toDoubleDB(pagamento.Valor.ToString()));
        //        command.Parameters.AddWithValue("@forma_pagamento", pagamento.Forma_pagamento);
        //        command.Parameters.AddWithValue("@quantidade_parcelas", pagamento.Quantidade_parcelas);

        //        command.ExecuteNonQuery();



        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Não foi possivel registrar lancamento, desfazendo alterações" + ex.Message, "Erro");
        //        try
        //        {
        //            transaction.Rollback();
        //        }
        //        catch (MySqlException mEx)
        //        {
        //            MessageBox.Show("Erro ao realizar Rollback " + mEx.Message);

        //        }

        //    }
        //    finally
        //    {
        //        if (conn.State == ConnectionState.Open) Desconecta();
        //    }
        //}
    

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
                    command.CommandText = "insert into tb_pagamento(id_venda, valor,forma_pagamento,quantidade_parcelas)" +
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


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) Desconecta();
            }

            return vendas;

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

        public void InsereHistoricoCliente(int id_venda,int id_cliente)
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

