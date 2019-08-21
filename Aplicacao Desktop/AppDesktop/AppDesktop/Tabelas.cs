using AppDesktop.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDesktop
{
    public partial class Tabelas : Form
    {
        public Tabelas()
        {
            InitializeComponent();
        }
        Config config = new Config();

        private void Tabelas_Load(object sender, EventArgs e)
        {
            if(this.Visible == true)
            {
                verificaTabelas();
            }
            

        }
        public void verificaTabelas()
        {
            var connection = new MySqlConnection(config.getConexao());
            var command = connection.CreateCommand();
            
            try
            {
                connection.Open();
                command.CommandText = "show tables like '%tb_usuario%'";
                progressBar1.Increment(10);
                lbl_operacao.Text = "Verificando tabela de usuários.";
                var result = command.ExecuteReader();
                if (!result.Read())
                {
                    lbl_operacao.Text = "Criando tabela de usuários.";
                    tabela_usuario();
                    
                }
                progressBar1.Increment(10);
                lbl_operacao.Text = "Verificando tabela de usuários.";
                connection.Close();
                connection.Open();
                lbl_operacao.Text = "Verificando tabela de perfil do usuário.";
                
                command.CommandText = "show tables like '%tb_perfil_usuario%'";
                progressBar1.Increment(10);
                result = command.ExecuteReader();
                if (!result.Read())
                {
                    lbl_operacao.Text = "Criando tabela de perfil do usuário.";
                    tabela_perfil();
                   
                }

                progressBar1.Increment(10);




            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um problema ao verificar tabelas:" + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();
            }
            lbl_operacao.Text = "Concluido.";
            this.Close();


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
                lbl_operacao.Text = "Tabela de usuário criada.";

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
                    "id_usuario int not null," +
                    "nome varchar(50) not null," +
                    "permissao int not null," +
                    "ativo bool not null," +
                    "primary key(id))";
                command.ExecuteNonQuery();
                lbl_operacao.Text = "Tabela de perfil do usuário criada.";

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
