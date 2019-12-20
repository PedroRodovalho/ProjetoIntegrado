using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using AppDesktop.DAO;
using MySql.Data.MySqlClient;

namespace AppDesktop 
{
    
    class BancoDAO : ITransaction
    {
        MySqlConnection conn;
        Config conexao = new Config();


        public void NovoBanco(Banco banco)
        {
            conn = Conecta();
            MySqlCommand command = conn.CreateCommand();
            try
            {
                command.CommandText = "insert into tb_banco_financeiro values(0,@banco,@cod)";
                
                command.Parameters.AddWithValue("@banco", banco.Nome);
                command.Parameters.AddWithValue("@cod", banco.Cod);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO INSERIR NOVO BANCO " + ex.Message);

            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }

        }
        public List<Banco> ListaBancos()
        {

            conn = Conecta();
            MySqlCommand command = conn.CreateCommand();
            List<Banco> bancos = new List<Banco>();
            try
            {
                command.CommandText = "select * from tb_banco_financeiro";
                var result = command.ExecuteReader();
                while (result.Read())
                {
                    Banco banco = new Banco();
                    banco.Id = result.GetInt32("id");
                    banco.Nome = result.GetString("banco");
                    banco.Cod = result.GetInt32("cod");
                    bancos.Add(banco);
                }
                return bancos;
            }catch(Exception ex)
            {
                MessageBox.Show("Houve um erro na listagem de bancos " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return null;
        }
        public MySqlConnection Conecta()
        {
            string connString = conexao.getConexao();
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            return conn;
        }

        public MySqlTransaction CriaTransaction(MySqlConnection conn)
        {
            throw new NotImplementedException();
        }

        internal Banco BuscaBanco(int id_banco)
        {
            conn = Conecta();
            MySqlCommand command = conn.CreateCommand();
            Banco banco = new Banco();
            try
            {
                command.CommandText = "select * from tb_banco_financeiro where id="+id_banco;
                var result = command.ExecuteReader();
                
                while (result.Read())
                {
                    
                    banco.Id = result.GetInt32("id");
                    banco.Nome = result.GetString("banco");
                    banco.Cod = result.GetInt32("cod");
                    
                }
                return banco;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro na listagem de bancos " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return banco;
        }
    }
    
}
