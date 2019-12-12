using System;
using System.Data;
using System.Windows.Forms;
using AppDesktop.DAO;
using MySql.Data.MySqlClient;

namespace AppDesktop
{
    internal class PermissaoDAO : ITransaction

    {
        MySqlConnection conn;
        Config conexao = new Config();

        internal PermissaoCaixa BuscaPermissaoCaixa(int id_permissao)
        {
            conn = Conecta();
            MySqlCommand command = conn.CreateCommand();
            try
            {
                PermissaoCaixa p = new PermissaoCaixa();
                command.CommandText = "SELECT * FROM tb_permissao where id=" + id_permissao;
                var result = command.ExecuteReader();
                if (result.Read())
                {
                    p.Insert = result.GetInt32("caixa_insert");
                    p.Insert = result.GetInt32("caixa_delete");
                    p.Adm = result.GetInt32("caixa_adm");
                    p.Insert = result.GetInt32("caixa_select");
                    p.Insert = result.GetInt32("caixa_update");
                }
                return p;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO BUSCAR PERMISSAO : " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return null;
        }
        internal Permissao BuscaPermissao(int id_permissao)
        {
            conn = Conecta();
            MySqlCommand command = conn.CreateCommand();
            try
            {
                Permissao p = new Permissao();
                command.CommandText = "SELECT * FROM tb_permissao where id=" + id_permissao;
                var result = command.ExecuteReader();
                if (result.Read())
                {
                    p.Insert = result.GetInt32("insert");
                    p.Insert = result.GetInt32("delete");
                    p.Adm = result.GetInt32("adm");
                    p.Insert = result.GetInt32("select");
                    p.Insert = result.GetInt32("update");
                }
                return p;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO BUSCAR PERMISSAO : " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return null;
        }
        internal PermissaoCliente BuscaPermissaoCliente(int id_permissao)
        {
            conn = Conecta();
            MySqlCommand command = conn.CreateCommand();
            try
            {
                PermissaoCliente p = new PermissaoCliente();
                command.CommandText = "SELECT * FROM tb_permissao where id=" + id_permissao;
                var result = command.ExecuteReader();
                if (result.Read())
                {
                    p.Insert = result.GetInt32("cliente_insert");
                    p.Insert = result.GetInt32("cliente_delete");
                    p.Adm = result.GetInt32("cliente_adm");
                    p.Insert = result.GetInt32("cliente_select");
                    p.Insert = result.GetInt32("cliente_update");
                }
                return p;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO BUSCAR PERMISSAO : " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return null;
        }

        internal PermissaoEstoque BuscaPermissaoEstoque(int id_permissao)
        {
            conn = Conecta();
            MySqlCommand command = conn.CreateCommand();
            try
            {
                PermissaoEstoque p = new PermissaoEstoque();
                command.CommandText = "SELECT * FROM tb_permissao where id=" + id_permissao;
                var result = command.ExecuteReader();
                if (result.Read())
                {
                    p.Insert = result.GetInt32("estoque_insert");
                    p.Delete = result.GetInt32("estoque_delete");
                    p.Adm = result.GetInt32("estoque_adm");
                    p.Select = result.GetInt32("estoque_select");
                    p.Update = result.GetInt32("estoque_update");
                }
                return p;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO BUSCAR PERMISSAO : " + ex.Message);
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
    }
}