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
    Conversor conversor = new Conversor();
    Config conexao = new Config();
        //INSERCAO DE NOVA VENDA
        public int InsereVenda(Venda venda)
        {

            MySqlConnection conn = Conecta();
            this.transaction = CriaTransacao(conn);
            MySqlCommand command = conn.CreateCommand();
            command.Transaction = transaction;
            

            try
            {
                command.CommandText = "insert into tb_venda(data_venda,valor_total,valor_final,quantidade_itens,regra_aplicada) values(@id_pagamento,@data,@valor_total," +
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

                int last_id = conversor.ToInt32(command.LastInsertedId.ToString());
                return last_id;
            }
            catch (Exception ex)
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

            return 0;
        }

        public void InsereItensVenda(List<Item_Caixa> itens)
        {

        }

        public void InserePagamento(Pagamento pagamento)
        {
            MySqlConnection conn = Conecta();
            MySqlCommand command = conn.CreateCommand();
            
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
                try
                {
                    transaction.Rollback();
                }
                catch (MySqlException mEx)
                {
                    MessageBox.Show("Erro ao realizar Rollback " + mEx.Message);

                }

            }
        }

        //CONSULTAS//

        public List<Venda> ListarVendas()
        {
            MySqlConnection conn = Conecta();
            MySqlCommand command = conn.CreateCommand();
            List<Venda> vendas = new List<Venda>();
            try
            {
                command.CommandText = "select * from tb_venda";
                var result = command.ExecuteReader();
                while (result.Read())
                {


                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void CommitTransaction(MySqlTransaction transaction, MySqlConnection conn)
        {
            try
            {
                transaction.Commit();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro ao commitar:" + ex.Message);
            }
            conn.Close();
        }

        public void insereHistoricoCliente(int id_venda)
        {
            MySqlConnection conn = Conecta();
            MySqlCommand command = conn.CreateCommand();

            try
            {
                command.CommandText = "insert into tb_historico_venda_cliente(id_venda) values(@id_venda)";
                command.Parameters.AddWithValue("@id_venda", id_venda);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Venda não registrada ao historico do cliente");
            }


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

