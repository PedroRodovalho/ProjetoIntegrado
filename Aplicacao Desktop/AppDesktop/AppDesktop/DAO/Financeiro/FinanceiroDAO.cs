using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using AppDesktop.DAO;
using MySql.Data.MySqlClient;

namespace AppDesktop
{
    internal class FinanceiroDAO : ITransaction

    {

        MySqlConnection conn;
        Config conexao = new Config();
        Conversor conversor = new Conversor();

        internal void NovaConta(Conta conta)
        {
            conn = Conecta();
            MySqlCommand command = conn.CreateCommand();
            try
            {

                command.CommandText = "insert into tb_conta values(0,@cod,@id_favorecido,@id_banco,@id_devedor,@forma_pagamento" +
                            ",@valor,@data_criacao,@hora_criacao,@data_vencimento,@tipo,@sub_tipo,@descricao,@tipo_debito)";

                command.Parameters.AddWithValue("@cod", conta.Cod);
                command.Parameters.AddWithValue("@id_favorecido", conta.Id_favorecido);
                command.Parameters.AddWithValue("@id_banco", conta.Id_banco);
                command.Parameters.AddWithValue("@id_devedor", conta.Id_devedor);
                command.Parameters.AddWithValue("@forma_pagamento", conta.Forma_pagamento);
                command.Parameters.AddWithValue("@valor", conversor.toDoubleDB(conta.Id_banco.ToString()));
                command.Parameters.AddWithValue("@data_criacao", conversor.toDateTimeDB(conta.Data_criacao));
                command.Parameters.AddWithValue("@hora_criacao", conta.Hora_criacao);
                command.Parameters.AddWithValue("@data_vencimento", conversor.toDateTimeDB(conta.Data_vencimento));
                command.Parameters.AddWithValue("@tipo", conta.Tipo);
                command.Parameters.AddWithValue("@sub_tipo", conta.Sub_tipo);
                command.Parameters.AddWithValue("@descricao", conta.Descricao);
                command.Parameters.AddWithValue("@tipo_debito", conta.Tipo_debito);
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

        internal bool AutenticaPermissao(int id)
        {
            conn = Conecta();
            MySqlCommand command = conn.CreateCommand();
            try
            {
                command.CommandText = "SELECT * FROM tb_financeiro_usuario where fk_usuario=" + id;
                var result = command.ExecuteReader();
                if (result.Read())
                {
                    return true;
                }
            }
            catch
            {

                MessageBox.Show("Erro ao buscar permissao");
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return false;
        }
        public MySqlConnection Conecta()
        {
            string connString = conexao.getConexao();
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            return conn;
        }
        internal MySqlDataReader ListarContasResultSet()
        {
            conn = Conecta();

            MySqlCommand command = conn.CreateCommand();
            List<Conta> contas = new List<Conta>();
            try
            {
                command.CommandText = "SELECT 	c.*, fav.nome as favorecido,    dev.nome as devedor FROM tb_conta c,	tb_favorecido fav, tb_favorecido dev WHERE fav.id = c.id_favorecido and dev.id = c.id_devedor;";
                var result = command.ExecuteReader();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao listar contas" + ex.Message);
            }

            return null;
        }
        internal List<Conta> ListarContas()
        {
            conn = Conecta();

            MySqlCommand command = conn.CreateCommand();
            List<Conta> contas = new List<Conta>();
            try
            {
                command.CommandText = "SELECT * from tb_conta";
                var result = command.ExecuteReader();

                while (result.Read())
                {

                    Conta conta = new Conta();

                    conta.Id = result.GetInt32("id");

                    conta.Id_banco = result.GetInt32("id_banco");

                    conta.Id_devedor = result.GetInt32("id_devedor");
                    conta.Id_favorecido = result.GetInt32("id_favorecido");
                    conta.Descricao = result.GetString("descricao");
                    conta.Forma_pagamento = result.GetString("forma_pagamento");

                    conta.Data_vencimento = conversor.toDateTimeBR(result.GetMySqlDateTime("data_vencimento"));
                    conta.Data_criacao = conversor.toDateTimeBR(result.GetMySqlDateTime("data_criacao"));

                    conta.Hora_criacao = result.GetString("hora_criacao");
                    conta.Tipo = result.GetString("tipo");
                    conta.Sub_tipo = result.GetString("sub_tipo");
                    conta.Valor = result.GetDouble("valor");
                    conta.Tipo_debito = result.GetString("tipo_debito");
                    conta.Status = result.GetString("status");
                    contas.Add(conta);

                }
                return contas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao listar contas" + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return contas;
        }

        internal MySqlDataReader ListarContasLikeFavorecidoDevedor(string pesquisa)
        {
            conn = Conecta();

            MySqlCommand command = conn.CreateCommand();
            List<Conta> contas = new List<Conta>();
            try
            {
                command.CommandText = "SELECT c.*, fav.nome as favorecido, dev.nome as devedor,f.id " +
                    "FROM tb_conta c, tb_favorecido f, tb_favorecido fav, tb_favorecido dev " +
                    "WHERE (c.id_favorecido = f.id AND f.nome LIKE('%" + pesquisa + "%') and fav.id = c.id_favorecido and dev.id = c.id_devedor)" +
                    "OR(c.id_devedor = f.id AND f.nome LIKE('%" + pesquisa + "%') and fav.id = c.id_favorecido and dev.id = c.id_devedor)";

                var result = command.ExecuteReader();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao realizar consulta de lista de contas" + ex.Message);
            }

            return null;
        }

        public MySqlTransaction CriaTransaction(MySqlConnection conn)
        {
            throw new NotImplementedException();
        }

        internal double SomaValorReceberByData(string v)
        {
            conn = Conecta();
            double soma = 0;
            MySqlCommand command = conn.CreateCommand();
            try
            {
                command.CommandText = "SELECT sum(valor) as soma from tb_conta where data_vencimento = '" + conversor.toDateTimeDB(v) + "' and tipo_debito = 'CREDITO'";
                var result = command.ExecuteReader();
                if (result.Read())
                {
                    soma = result.GetDouble("soma");
                }
                return soma;
            }
            catch
            {

            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }

            return soma;

        }

        internal void Desconecta()
        {
            conn.Close();
        }

        internal void NovoLancamento(Lancamento lancamento)
        {
            conn = Conecta();

            MySqlCommand command = conn.CreateCommand();
            try
            {
                command.CommandText = "Insert into tb_lancamento values(0,@cod_conta,@data_pag)";
                command.Parameters.AddWithValue("@cod_conta", lancamento.Cod_conta);
                command.Parameters.AddWithValue("@data_pag", conversor.toDateTimeDB(lancamento.Data_lancamento));

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro ao incluir lançamento: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }



        internal double SomaValorPagarByData(string v)
        {
            conn = Conecta();
            double soma = 0;
            MySqlCommand command = conn.CreateCommand();
            try
            {
                command.CommandText = "SELECT sum(valor) as soma from tb_conta where data_vencimento = '" + conversor.toDateTimeDB(v) + "' and tipo_debito = 'DEBITO'";
                var result = command.ExecuteReader();
                if (result.Read())
                {
                    soma = result.GetDouble("soma");
                }
                return soma;
            }
            catch
            {

            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }

            return soma;
        }

        internal MySqlDataReader ListarContasReceberByData_ResultSet(string v)
        {
            conn = Conecta();

            MySqlCommand command = conn.CreateCommand();
            List<Conta> contas = new List<Conta>();
            try
            {
               command.CommandText = "SELECT * from tb_conta where data_vencimento = '" + conversor.toDateTimeDB(v) + "' and tipo_debito = 'CREDITO'";

                var result = command.ExecuteReader();
                return result;
            }
            catch(Exception ex) { MessageBox.Show("Houve um erro ao listar grid " + ex.Message); }

            return null;
        }
        internal List<Conta> ListarContasReceberByData(string v)
        {
            conn = Conecta();

            MySqlCommand command = conn.CreateCommand();
            List<Conta> contas = new List<Conta>();
            try
            {
                command.CommandText = "SELECT * from tb_conta where data_vencimento = '" + conversor.toDateTimeDB(v) + "' and tipo_debito = 'CREDITO'";
                var result = command.ExecuteReader();
                while (result.Read())
                {
                    Conta conta = new Conta();
                    conta.Id = result.GetInt32("id");
                    conta.Id_banco = result.GetInt32("id_banco");
                    conta.Id_devedor = result.GetInt32("id_devedor");
                    conta.Id_favorecido = result.GetInt32("id_favorecido");
                    conta.Descricao = result.GetString("descricao");
                    conta.Forma_pagamento = result.GetString("forma_pagamento");
                    conta.Data_vencimento = conversor.toDateTimeBR(result.GetMySqlDateTime("data_vencimento"));
                    conta.Data_criacao = conversor.toDateTimeBR(result.GetMySqlDateTime("data_criacao"));
                    conta.Hora_criacao = result.GetString("hora_criacao");
                    conta.Tipo = result.GetString("tipo");
                    conta.Sub_tipo = result.GetString("sub_tipo");
                    conta.Valor = result.GetDouble("valor");
                    conta.Tipo_debito = result.GetString("tipo_debito");
                    contas.Add(conta);

                }
                return contas;
            }
            catch
            {

            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }

            return contas;
        }
        
        internal Conta BuscaContaByCod(int cod)
        {
            conn = Conecta();

            MySqlCommand command = conn.CreateCommand();

            Conta conta = null;
            try
            {
                conta = new Conta();
                command.CommandText = "SELECT * from tb_conta where cod =" + cod;
                var result = command.ExecuteReader();
                if (result.Read())
                {
                    conta.Id = result.GetInt32("id");
                    conta.Id_banco = result.GetInt32("id_banco");
                    conta.Id_devedor = result.GetInt32("id_devedor");
                    conta.Id_favorecido = result.GetInt32("id_favorecido");
                    conta.Descricao = result.GetString("descricao");
                    conta.Forma_pagamento = result.GetString("forma_pagamento");
                    conta.Data_vencimento = conversor.toDateTimeBR(result.GetMySqlDateTime("data_vencimento"));
                    conta.Data_criacao = conversor.toDateTimeBR(result.GetMySqlDateTime("data_criacao"));
                    conta.Hora_criacao = result.GetString("hora_criacao");
                    conta.Tipo = result.GetString("tipo");
                    conta.Sub_tipo = result.GetString("sub_tipo");
                    conta.Valor = result.GetDouble("valor");
                    conta.Tipo_debito = result.GetString("tipo_debito");
                    conta.Status = result.GetString("status");
                    return conta;

                }

            }
            catch
            {

            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }

            return null;
        }

        internal void AtualizaLancamento(object lancamento)
        {
            throw new NotImplementedException();
        }

        internal void AtualizaConta(Conta conta)
        {
            throw new NotImplementedException();
        }

        internal Lancamento BuscaLancamento(int cod)
        {
            conn = Conecta();

            MySqlCommand command = conn.CreateCommand();
            try
            {
                Lancamento lancamento = new Lancamento();
                command.CommandText = "SELECT * from tb_lancamento where cod_conta =" + cod;

                var result = command.ExecuteReader();
                if (result.Read())
                {
                    lancamento.Cod_conta = cod;
                    lancamento.Data_lancamento = conversor.toDateTimeBR(result.GetMySqlDateTime("data_lancamento"));

                    return lancamento;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro ao buscar lancamento da conta especificada : " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }

            return null;
        }
        internal MySqlDataReader ListarContasPagarByData_ResultSet(string v)
        {
            conn = Conecta();

            MySqlCommand command = conn.CreateCommand();
            List<Conta> contas = new List<Conta>();
            try
            {
                command.CommandText = "SELECT * from tb_conta where data_vencimento = '" + conversor.toDateTimeDB(v) + "' and tipo_debito = 'DEBITO'";
                var result = command.ExecuteReader();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro ao consultar tabela de contas" + ex.Message);

            }
            return null;
        }
        internal List<Conta> ListarContasPagarByData(string v)
        {
            conn = Conecta();

            MySqlCommand command = conn.CreateCommand();
            List<Conta> contas = new List<Conta>();
            try
            {
                command.CommandText = "SELECT * from tb_conta where data_vencimento = '" + conversor.toDateTimeDB(v) + "' and tipo_debito = 'DEBITO'";
                var result = command.ExecuteReader();
                while (result.Read())
                {
                    Conta conta = new Conta();
                    conta.Id = result.GetInt32("id");
                    conta.Id_banco = result.GetInt32("id_banco");
                    conta.Id_devedor = result.GetInt32("id_devedor");
                    conta.Id_favorecido = result.GetInt32("id_favorecido");
                    conta.Descricao = result.GetString("descricao");
                    conta.Forma_pagamento = result.GetString("forma_pagamento");
                    conta.Data_vencimento = conversor.toDateTimeBR(result.GetMySqlDateTime("data_vencimento"));
                    conta.Data_criacao = conversor.toDateTimeBR(result.GetMySqlDateTime("data_criacao"));
                    conta.Hora_criacao = result.GetString("hora_criacao");
                    conta.Tipo = result.GetString("tipo");
                    conta.Sub_tipo = result.GetString("sub_tipo");
                    conta.Valor = result.GetDouble("valor");
                    conta.Tipo_debito = result.GetString("tipo_debito");
                    contas.Add(conta);

                }
                return contas;
            }
            catch
            {

            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }

            return contas;
        }
    }
}