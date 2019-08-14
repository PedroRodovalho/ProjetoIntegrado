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
using MySql.Data.MySqlClient;

namespace AppDesktop
{
    public partial class FormPrimeiroAcesso : Form
    {
        FormHome main;
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
            iniciaConfig();

        }

        public void iniciaConfig()
        {
            panel_etapa1.Visible = true;
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
            else {
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
                Properties.Settings.Default.ip_banco = txt_ip_banco.Text;
                Properties.Settings.Default.database = txt_nome_banco.Text;
                Properties.Settings.Default.usuario_banco = txt_user_banco.Text;
                Properties.Settings.Default.senha_banco = txt_senha_banco.Text;

                panel_etapa1.Visible = false;
                panel_etapa2.Visible = true;
            }
        }
    }
}
