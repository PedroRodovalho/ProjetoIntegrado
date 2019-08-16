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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }
        private FormLogin formLogin = null;
        private void Form1_Load(object sender, EventArgs e)
        {
        
            Boolean primeiro_acesso = Properties.Settings.Default.primeiro_acesso;
            
            if (primeiro_acesso)
            {
                this.Visible = false;
                FormPrimeiroAcesso formPrimeiroAcesso = new FormPrimeiroAcesso(this);
                DialogResult result = formPrimeiroAcesso.ShowDialog();
            }
            else
            {
                solicitaLogin();
            }
            
        }

        public void solicitaLogin()
        {
            formLogin = new FormLogin();
            DialogResult session = formLogin.ShowDialog();

            if (session == DialogResult.OK)
            {
                lbl_status.Text = "ENTROU";
                btn_logar.Visible = false;
            }
            else
            {
                lbl_status.Text = "FAÇA LOGIN PARA CONTINUAR";
                btn_logar.Visible = true;
            }

        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            solicitaLogin();
        }
    }
}
