using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using AppDesktop.DAO;
using MySql.Data.MySqlClient;

namespace AppDesktop
{
    internal class FavorecidoDAO : ITransaction
    {
        MySqlConnection conn;
        Config conexao = new Config();
        public FavorecidoDAO()
        {
        }
        internal void NovoFavorecido(Favorecido favorecido)
        {
            conn = Conecta();
            MySqlCommand command = conn.CreateCommand();
            try
            {
                command.CommandText = "insert into tb_favorecido values(null,@nome,@cpf_cnpj,@id_banco,@agencia,@conta,@classificacao)";
                command.Parameters.AddWithValue("@nome", favorecido.Nome);
                command.Parameters.AddWithValue("@cpf_cnpj", favorecido.Cpf_cpnj);
                command.Parameters.AddWithValue("@id_banco", favorecido.Id_banco);
                command.Parameters.AddWithValue("@agencia", favorecido.Agencia);
                command.Parameters.AddWithValue("@conta", favorecido.Conta);
                command.Parameters.AddWithValue("@classificacao", favorecido.Classificacao);
                command.ExecuteNonQuery();
                MessageBox.Show("Favorecido cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel registrar novo favorecido" + ex.Message, "Erro");
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
        public List<Favorecido> ListaFavorecido()
        {
            conn = Conecta();
            MySqlCommand command = conn.CreateCommand();
            List<Favorecido> favorecidos = new List<Favorecido>();
            try
            {
                command.CommandText = "SELECT * FROM tb_favorecido";
                var result = command.ExecuteReader();
                while (result.Read())
                {
                    Favorecido favorecido = new Favorecido();
                    favorecido.Id = result.GetInt32("id");
                    favorecido.Nome = result.GetString("nome");
                    favorecido.Agencia = result.GetString("agencia");
                    favorecido.Conta = result.GetString("conta");
                    favorecido.Cpf_cpnj = result.GetString("cpf_cnpj");
                    favorecido.Id_banco = result.GetInt32("id_banco");
                    favorecido.Classificacao = result.GetString("classificacao");

                    favorecidos.Add(favorecido);

                }
                return favorecidos;
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERRO AO LISTAR FAVORECIDOS" + ex.Message);
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

        internal Favorecido BuscaFavorecidoById(int id_favorecido)
        {
            conn = Conecta();
            MySqlCommand command = conn.CreateCommand();
            Favorecido favorecido;
            try
            {
                favorecido = new Favorecido();
                command.CommandText = "SELECT * FROM tb_favorecido where id ="+id_favorecido;
                var result = command.ExecuteReader();
                if (result.Read())
                {
                    

                    favorecido.Id = result.GetInt32("id");
                    favorecido.Nome = result.GetString("nome");
                    favorecido.Agencia = result.GetString("agencia");
                    favorecido.Conta = result.GetString("conta");
                    favorecido.Cpf_cpnj = result.GetString("cpf_cnpj");
                    favorecido.Id_banco = result.GetInt32("id_banco");
                    favorecido.Classificacao = result.GetString("classificacao");

                    

                }
                return favorecido;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO LISTAR FAVORECIDOS" + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return null;
        }

        internal Devedor BuscaDevedorById(int id_devedor)
        {
            conn = Conecta();
            MySqlCommand command = conn.CreateCommand();
            Devedor devedor;
            try
            {
                devedor = new Devedor();
                command.CommandText = "SELECT * FROM tb_favorecido where id =" + id_devedor;
                var result = command.ExecuteReader();
                if (result.Read())
                {


                    devedor.Id = result.GetInt32("id");
                    devedor.Nome = result.GetString("nome");
                    devedor.Agencia = result.GetString("agencia");
                    devedor.Conta = result.GetString("conta");
                    devedor.Cpf_cpnj = result.GetString("cpf_cnpj");
                    devedor.Id_banco = result.GetInt32("id_banco");
                    devedor.Classificacao = result.GetString("classificacao");



                }
                return devedor;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO LISTAR FAVORECIDOS" + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return null;
        }
    }
}