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

namespace AppDesktop
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }
        private FormLogin formLogin = null;
        private void Form1_Load(object sender, EventArgs e)
        {

           // Boolean primeiro_acesso = true;


            Boolean primeiro_acesso = Properties.Settings.Default.primeiro_acesso;
           if (primeiro_acesso)
            {
                this.Visible = false;
                FormPrimeiroAcesso formPrimeiroAcesso = new FormPrimeiroAcesso(this);
                DialogResult result = formPrimeiroAcesso.ShowDialog();
                Properties.Settings.Default.primeiro_acesso = false;
                Properties.Settings.Default.Save();

                if(result == DialogResult.Abort)
                {
                    this.Visible = true;
                }

            }
            else
            {
                solicitaLogin();
            }

        }

        public void solicitaLogin()
        {
            int Permission_Type = Properties.Settings.Default.Permission_Type;
          
            if (Permission_Type == 1 || Permission_Type == 2)
            {


                formLogin = new FormLogin();
                DialogResult session = formLogin.ShowDialog();

                if (session == DialogResult.OK)
                {
                    lbl_login_pendente.Text = "ENTROU";
                    lbl_fazer_login.Visible = false;

                    inicializaSistema();
                }
                else
                {
                    lbl_login_pendente.Visible = true;
                    panel_fazer_login.Visible = true;
                    lbl_fazer_login.Visible = true;
                }
            }
            else
            {
                inicializaSistema();
            }

        }

        public void inicializaSistema()
        {
            
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            solicitaLogin();
        }

        private void panel_fazer_login_Paint(object sender, PaintEventArgs e)
        {

            GraphicsPath PastaGrafica = new GraphicsPath();
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, panel_fazer_login.Size.Width, panel_fazer_login.Size.Height));

            //Arredondar canto superior esquerdo        
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, 10, 10));
            PastaGrafica.AddPie(1, 1, 20, 20, 180, 90);

            //Arredondar canto superior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(panel_fazer_login.Width - 12, 1, 12, 13));
            PastaGrafica.AddPie(panel_fazer_login.Width - 24, 1, 24, 26, 270, 90);

            //Arredondar canto inferior esquerdo
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, panel_fazer_login.Height - 10, 10, 10));
            PastaGrafica.AddPie(1, panel_fazer_login.Height - 20, 20, 20, 90, 90);

            //Arredondar canto inferior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(panel_fazer_login.Width - 12, panel_fazer_login.Height - 13, 13, 13));
            PastaGrafica.AddPie(panel_fazer_login.Width - 24, panel_fazer_login.Height - 26, 24, 26, 0, 90);

            PastaGrafica.SetMarkers();
            panel_fazer_login.Region = new Region(PastaGrafica);
        }

        private void lbl_fazer_login_MouseEnter(object sender, EventArgs e)
        {
            lbl_fazer_login.ForeColor = Color.DarkOrange;

        }

        private void lbl_fazer_login_MouseLeave(object sender, EventArgs e)
        {
            lbl_fazer_login.ForeColor = Color.White;
        }

        private void lbl_fazer_login_Click(object sender, EventArgs e)
        {
            solicitaLogin();
        }
    }
}
