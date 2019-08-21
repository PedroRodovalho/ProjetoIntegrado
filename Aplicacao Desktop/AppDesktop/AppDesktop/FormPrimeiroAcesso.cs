using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppDesktop.DAO;
using MySql.Data.MySqlClient;

namespace AppDesktop
{
    public partial class FormPrimeiroAcesso : Form
    {
        FormHome main;
        UsuarioDAO userDAO = new UsuarioDAO();
        public FormPrimeiroAcesso(FormHome main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void FormPrimeiroAcesso_Load(object sender, EventArgs e)
        {
            ArredondaCantosdoForm();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            btn_start.Visible = false;
            lbl_info.Visible = false;
            iniciaConfig();

        }

        public void iniciaConfig()
        {
            btn_next.Visible = true;
            btn_back.Visible = true;
            panel_etapa1.Visible = true;
            lbl_etapa.Text = "Passo 1/5";

        }



        private void panel_topo_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath PastaGrafica = new GraphicsPath();
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, panel_topo.Size.Width, panel_topo.Size.Height));

            //Arredondar canto superior esquerdo        
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, 10, 10));
            PastaGrafica.AddPie(1, 1, 20, 20, 180, 90);

            //Arredondar canto superior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(panel_topo.Width - 12, 1, 12, 13));
            PastaGrafica.AddPie(panel_topo.Width - 24, 1, 24, 26, 270, 90);

            //Arredondar canto inferior esquerdo
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, panel_topo.Height - 10, 10, 10));
            PastaGrafica.AddPie(1, panel_topo.Height - 20, 20, 20, 90, 90);

            //Arredondar canto inferior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(panel_topo.Width - 12, panel_topo.Height - 13, 13, 13));
            PastaGrafica.AddPie(panel_topo.Width - 24, panel_topo.Height - 26, 24, 26, 0, 90);

            PastaGrafica.SetMarkers();
            panel_topo.Region = new Region(PastaGrafica);
        }

        public void ArredondaCantosdoForm()
        {

            GraphicsPath PastaGrafica = new GraphicsPath();
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, this.Size.Width, this.Size.Height));

            //Arredondar canto superior esquerdo        
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, 10, 10));
            PastaGrafica.AddPie(1, 1, 20, 20, 180, 90);

            //Arredondar canto superior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(this.Width - 12, 1, 12, 13));
            PastaGrafica.AddPie(this.Width - 24, 1, 24, 26, 270, 90);

            //Arredondar canto inferior esquerdo
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, this.Height - 10, 10, 10));
            PastaGrafica.AddPie(1, this.Height - 20, 20, 20, 90, 90);

            //Arredondar canto inferior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(this.Width - 12, this.Height - 13, 13, 13));
            PastaGrafica.AddPie(this.Width - 24, this.Height - 26, 24, 26, 0, 90);

            PastaGrafica.SetMarkers();
            this.Region = new Region(PastaGrafica);
        }

        private void btn_teste_db_Click(object sender, EventArgs e)
        {


            string server = txt_ip_banco.Text;
            string database = txt_nome_banco.Text;
            string user = txt_user_banco.Text;
            string senha = txt_senha_banco.Text;

            string conexao = "Server=" + server + ";DataBase=" + database + ";Uid=" + user + ";Password=" + senha;


            var conn = new MySqlConnection(conexao);

            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {

                    lbl_status_conexao.Text = "Conexão estabelecida com sucesso!";
                    lbl_status_conexao.ForeColor = Color.Green;
                    link_show_error.Visible = false;
                    if (lbl_errodb.Visible) lbl_errodb.Visible = false;
                }
            }
            catch (Exception ex)
            {
                lbl_status_conexao.Text = "Falha ao estabelecer conexão!";
                lbl_status_conexao.ForeColor = Color.Red;
                link_show_error.Visible = true;
                lbl_errodb.Text = ex.Message;

            }


        }

        private void link_show_error_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lbl_errodb.Visible)
            {
                lbl_errodb.Visible = false;
                link_show_error.Text = "Exibir mensagem de erro.";
            }
            else
            {
                lbl_errodb.Visible = true;
                link_show_error.Text = "Ocultar mensagem de erro.";
            }
        }

        private void lbl_fechar_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = DialogResult.Abort;

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (panel_etapa1.Visible)
            {
                etapa2();
            }
            else

            if (panel_etapa2.Visible)
            {
                etapa3();
            }
            else

            if (panel_etapa3.Visible)
            {
                etapa4();

            }
            else

            if (panel_etapa4.Visible)
            {
                etapa5();
            }
        }

        private void btn_admin_create_Click(object sender, EventArgs e)
        {
            Usuario user_adm = new Usuario();

            user_adm.Login = txt_admin_user.Text;
            user_adm.Senha = txt_admin_pass.Text;

            userDAO.criaLogin(user_adm);


        }

        private void btn_register_user_Click(object sender, EventArgs e)
        {
            Usuario new_user = new Usuario();

            new_user.Login = txt_user_user.Text;
            new_user.Senha = txt_user_pass.Text;

            userDAO.criaLogin(new_user);
        }
        public void etapa2()
        {
            panel_etapa1.Visible = false;
            panel_etapa2.Visible = true;
            lbl_etapa.Text = "Passo 2/5";
            progressBar.Increment(10);

        }


        public void etapa3()
        {
            Properties.Settings.Default.ip_banco = txt_ip_banco.Text;
            Properties.Settings.Default.database = txt_nome_banco.Text;
            Properties.Settings.Default.usuario_banco = txt_user_banco.Text;
            Properties.Settings.Default.senha_banco = txt_senha_banco.Text;

            Properties.Settings.Default.Save();
            panel_etapa2.Visible = false;
            panel_etapa3.Visible = true;
            lbl_etapa.Text = "Passo 3/5";

            Tabelas formTabelas = new Tabelas();
            formTabelas.ShowDialog();
            progressBar.Increment(10);
        }
        public void etapa4()
        {
            panel_etapa3.Visible = false;
            panel_etapa4.Visible = true;

            lbl_etapa.Text = "Passo 4/5";
            progressBar.Increment(10);


            if (radio_permissao4.Checked)
            {
                //progressBar.Increment(10);
                btn_next.PerformClick();
                Properties.Settings.Default.Permission_Type = 4;
            }
            else if (radio_permissao3.Checked)
            {
                btn_next.PerformClick();
                Properties.Settings.Default.Permission_Type = 3;


            }
            else
            if (radio_permissao2.Checked)
            {
                group_permission.Enabled = false;
                Properties.Settings.Default.Permission_Type = 2;
            }
            else
            {
                Properties.Settings.Default.Permission_Type = 1;
            }
            
           

        }
        public void etapa5()
        {

            panel_etapa4.Visible = false;
            panel_etapa5.Visible = true;
            progressBar.Increment(10);
            lbl_etapa.Text = "Passo 5/5";
            btn_next.Text = "Finalizar";
            finalizaConfig();

        }

        public void finalizaConfig()
        {

            main.Visible = true;
            
            

            this.Close();
        }

        private void radio_permissao4_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_permissao4.Checked)
            {
                group_admin_create.Enabled = false;
            }
            else
            {
                group_admin_create.Enabled = true;
            }
        }
    }
}
