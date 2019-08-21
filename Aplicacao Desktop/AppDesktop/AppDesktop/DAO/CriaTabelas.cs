using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDesktop.DAO
{
    class CriaTabelas
    {
        Config config = new Config();
        Boolean tb_usuario = false;


        public void verificaTabelas()
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            Boolean t = false;
            try
            {
                connection.Open();
                command.CommandText = "show tables like '%tb_usuario%'";
                var result = command.ExecuteReader();
                if (!result.Read())
                {
                    tabela_usuario();
                }
                connection.Close();
                connection.Open();
                command.CommandText = "show tables like '%tb_perfil_usuario%'";
                result = command.ExecuteReader();
                if (!result.Read())
                {
                    tabela_perfil();
                }

                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um problema ao verificar tabelas:" + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();
            }

            
        }
        public void tabela_usuario()
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            try
            {
                connection.Open();

                command.CommandText = "create table tb_usuario(id int not null auto_increment," +
                    "login varchar(50) not null," +
                    "senha varchar(50) not null," +
                    "primary key(id))";
                command.ExecuteNonQuery();

            
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();
            }
        }

        public void tabela_perfil()
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            try
            {
                connection.Open();

                command.CommandText = "create table tb_perfil(id int not null auto_increment," +
                    "id_usuario int not null,"+
                    "nome varchar(50) not null," +
                    "permissao int not null," +
                    "ativo bool not null,"+
                    "primary key(id))";
                command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();
            }
        }
    }
}
    
