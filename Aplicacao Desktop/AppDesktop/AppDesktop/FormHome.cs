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
//using WinFormAnimation;

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

            //Boolean primeiro_acesso = true;

            tab.Padding = new Point(12, 4);
            Boolean primeiro_acesso = Properties.Settings.Default.primeiro_acesso;
            if (primeiro_acesso)
            {
               
                this.Visible = false;
                FormPrimeiroAcesso formPrimeiroAcesso = new FormPrimeiroAcesso(this);
                DialogResult result = formPrimeiroAcesso.ShowDialog();
                Properties.Settings.Default.primeiro_acesso = false;
                Properties.Settings.Default.Save();

                if (result == DialogResult.Abort)
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
                    //lbl_login_pendente.Text = "ENTROU";
                    lbl_fazer_login.Visible = false;
                    if (panel_session.Visible)
                    {
                        panel_session.Visible = false;
                    }
                    inicializaSistema();
                }
                else
                {
                    panel_session.Visible = true;
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
            
            panel_menu.Visible = true;
            /// timer1.Enabled = true;
            // timer1.Start();
            /* new Animator2D(new Path2D(new Float2D(-100, 172), icon_caixa.Location.ToFloat2D(), 600))
             .Play(icon_caixa, Animator2D.KnownProperties.Location);
             new Animator2D(new Path2D(new Float2D(-100, 172), icon_cliente.Location.ToFloat2D(), 800))
             .Play(icon_cliente, Animator2D.KnownProperties.Location);
             new Animator2D(new Path2D(new Float2D(-100, 172), icon_financeiro.Location.ToFloat2D(), 1000))
             .Play(icon_financeiro, Animator2D.KnownProperties.Location);
             new Animator2D(new Path2D(new Float2D(-100, 172), icon_preferencias.Location.ToFloat2D(), 1200))
             .Play(icon_preferencias, Animator2D.KnownProperties.Location);
             */

            panel_menu.Visible = true;
            panel_home.Visible = true;
            

        }
        protected void PaintTransparentBackground(Graphics graphics, Rectangle clipRect)
        {
            graphics.Clear(Color.Transparent);
            if ((this.Parent != null))
            {
                clipRect.Offset(this.Location);
                PaintEventArgs e = new PaintEventArgs(graphics, clipRect);
                GraphicsState state = graphics.Save();
                graphics.SmoothingMode = SmoothingMode.HighSpeed;
                try
                {
                    graphics.TranslateTransform((float)-this.Location.X, (float)-this.Location.Y);
                    this.InvokePaintBackground(this.Parent, e);
                    this.InvokePaint(this.Parent, e);
                }
                finally
                {
                    graphics.Restore(state);
                    clipRect.Offset(-this.Location.X, -this.Location.Y);
                }
            }
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






        private void icon_caixa_MouseEnter(object sender, EventArgs e)
        {
            lbl_nome_icone.Visible = true;
            lbl_nome_icone.Text = "CAIXA";
            icon_caixa.Size = new Size(icon_caixa.Size.Width + 15, icon_caixa.Size.Height + 15);
            icon_caixa.Location = new Point(icon_caixa.Location.X - 8, icon_caixa.Location.Y - 8);
            icon_estoque.Location = new Point(icon_estoque.Location.X + 10, icon_estoque.Location.Y);
            icon_cliente.Location = new Point(icon_cliente.Location.X - 10, icon_cliente.Location.Y);
            icon_financeiro.Location = new Point(icon_financeiro.Location.X - 10, icon_financeiro.Location.Y);
        }


        private void icon_caixa_MouseLeave(object sender, EventArgs e)
        {
            lbl_nome_icone.Visible = false;
            icon_caixa.Size = new Size(icon_caixa.Size.Width - 15, icon_caixa.Size.Height - 15);
            icon_caixa.Location = new Point(icon_caixa.Location.X + 8, icon_caixa.Location.Y + 8);
            icon_estoque.Location = new Point(icon_estoque.Location.X - 10, icon_estoque.Location.Y);
            icon_cliente.Location = new Point(icon_cliente.Location.X + 10, icon_cliente.Location.Y);
            icon_financeiro.Location = new Point(icon_financeiro.Location.X + 10, icon_financeiro.Location.Y);
        }

        private void panel_session_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                              Color.Gray,
                                                              Color.Black,
                                                              90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }


        FormCaixa formCaixa = null;
        FormFinanceiro formFinanceiro = null;
        FormCliente formCliente = null;
        FormEstoque formEstoque = null;
        FormRegrasNegocio formRegrasNegocio = null;



        TabPage tab_caixa = new TabPage();
        TabPage tab_cliente = new TabPage();
        TabPage tab_financeiro = new TabPage();
        TabPage tab_estoque = new TabPage();
        TabPage tab_regra_negocio = new TabPage();

        string[,] abas = {
            {"disponivel", "22", "120","0"}, //22; 124
            {"disponivel", "232", "124","0"}, //232; 124
            {"disponivel", "442", "124","0"},
            {"disponivel", "652", "124","0"},
            {"disponivel", "862", "124","0"},
            {"disponivel", "1072", "124","0"}};



        public void MapeaiaAba(string nome)
        {
            int pos = 0;
            for (int i = 0; i < abas.Length; i++)
            {
                if (abas[i, 0].Equals("disponivel"))
                {
                    abas[i, 0] = nome;

                    AbreAba(nome, i, abas[i, 1], abas[i, 2]);
                    pos = i;
                    break;
                }
            }
            for (int i = 0; i < abas.Length; i++)
            {

            }


        }

        Conversor conversor = new Conversor();

        FormAba formAbaCaixa, formAbaFinanceiro, formAbaEstoque, formAbaCliente;
        public void AbreAba(string nome, int posicao, string X, string Y)
        {
            Point point = new Point(conversor.ToInt32(X), conversor.ToInt32(Y));
            if (nome.Equals("CAIXA"))
            {
                formAbaCaixa = new FormAba(this, nome, point, posicao);
                formAbaCaixa.TopLevel = false;
                formAbaCaixa.Visible = true;
                this.Controls.Add(formAbaCaixa);
                formCaixa = new FormCaixa();
                formCaixa.TopLevel = false;
                formCaixa.Visible = true;
                panel_home.Controls.Add(formCaixa);

                //abas[posicao, 3] = Application.OpenForms.OfType<FormAba>().;
                MessageBox.Show(abas[posicao, 0] + " " + abas[posicao, 3]);
            }


        }
        public void FechaAba(string nome)
        {
            int posicao = 0;
            for (int i = 0; i < abas.Length; i++)
            {
                if (abas[i, 0].Equals(nome))
                {
                    abas[i, 0] = "disponivel";
                    //posicao = i;
                    int elemento = conversor.ToInt32(abas[i, 3]);
                    MessageBox.Show(abas[i, 0] + " " + abas[i, 3]);


                    break;
                }
            }

            if (nome.Equals("CAIXA"))
            {
                formAbaCaixa.Close();
                formCaixa.Close();
            }
        }

        private void icon_caixa_Click(object sender, EventArgs e)
        {

            //MapeaiaAba("CAIXA");


            if (!tab.TabPages.Contains(tab_caixa))
            {
                tab_caixa.Size = new Size(tab_caixa.Size.Width, 1400);
                tab_caixa.Text = "Caixa";

                tab.TabPages.Add(tab_caixa);
                formCaixa = new FormCaixa();
                formCaixa.TopLevel = false;
                formCaixa.Visible = true;
                tab_caixa.Controls.Add(formCaixa);
                // this.Controls.Add(formCaixa);
                tab.SelectedTab = tab_caixa;
            }
            else
            {
                tab.SelectedTab = tab_caixa;
            }

        }

        private void icon_cliente_Click(object sender, EventArgs e)
        {

            if (!tab.TabPages.Contains(tab_cliente))
            {





                tab.TabPages.Add(tab_cliente);
                tab_cliente.Text = "Clientes";
                formCliente = new FormCliente();
                formCliente.TopLevel = false;
                formCliente.Visible = true;
                tab_cliente.Controls.Add(formCliente);

                tab.SelectedTab = tab_cliente;
            }
        }

        private void icon_financeiro_Click(object sender, EventArgs e)
        {
            if (!tab.TabPages.Contains(tab_financeiro))
            {
                tab.TabPages.Add(tab_financeiro);
                tab_financeiro.Text = "Financeiro";

                formFinanceiro = new FormFinanceiro();
                formFinanceiro.TopLevel = false;
                formFinanceiro.Visible = true;
                tab_financeiro.Controls.Add(formFinanceiro);

                tab.SelectedTab = tab_financeiro;
            }
            else
            {
                tab.SelectedTab = tab_financeiro;
            }

        }

        private void panel_home_SizeChanged(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormCaixa>().Count() > 0)
            {
                formCaixa.Size = new Size(panel_home.Size.Width, panel_home.Size.Height);
            }
        }

        private void tab_DrawItem(object sender, DrawItemEventArgs e)
        {
            


            
        }

        private void icon_estoque_Click(object sender, EventArgs e)
        {
            if (!tab.TabPages.Contains(tab_estoque))
            {
                tab.TabPages.Add(tab_estoque);
                tab_estoque.Text = "Estoque";

                formEstoque = new FormEstoque();
                formEstoque.TopLevel = false;
                formEstoque.Visible = true;
                tab_estoque.Controls.Add(formEstoque);

                tab.SelectedTab = tab_estoque;
            }
            else
            {
                tab.SelectedTab = tab_estoque;
            }
        }

        private void panel_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_regra_Click(object sender, EventArgs e)
        {
            if (!tab.TabPages.Contains(tab_regra_negocio))
            {
                tab_regra_negocio.Size = new Size(tab_caixa.Size.Width, 1400);
                tab_regra_negocio.Text = "Regras de Negocio";

                tab.TabPages.Add(tab_regra_negocio);
                formRegrasNegocio = new FormRegrasNegocio();
                formRegrasNegocio.TopLevel = false;
                formRegrasNegocio.Visible = true;
                tab_regra_negocio.Controls.Add(formRegrasNegocio);
                // this.Controls.Add(formCaixa);
                tab.SelectedTab = tab_regra_negocio;
            }
            else
            {
                tab.SelectedTab = tab_regra_negocio;
            }
        }

        private void icon_financeiro_MouseEnter(object sender, EventArgs e)
        {
            lbl_nome_icone.Text = "FINANCEIRO";
            lbl_nome_icone.Visible = true;
        }

        private void icon_financeiro_MouseLeave(object sender, EventArgs e)
        {
            lbl_nome_icone.Visible = false;
        }

        private void icon_cliente_MouseEnter(object sender, EventArgs e)
        {
            lbl_nome_icone.Text = "CLIENTE";
            lbl_nome_icone.Visible = true;
        }

        private void icon_cliente_MouseLeave(object sender, EventArgs e)
        {
            lbl_nome_icone.Visible = false;
        }

        private void icon_estoque_MouseEnter(object sender, EventArgs e)
        {
            lbl_nome_icone.Text = "ESTOQUE";
            lbl_nome_icone.Visible = true;
        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void icon_estoque_MouseLeave(object sender, EventArgs e)
        {
            lbl_nome_icone.Visible = false;
        }

        private void icon_preferencias_MouseEnter(object sender, EventArgs e)
        {
            lbl_nome_icone.Text = "PREFERÊNCIAS";
            lbl_nome_icone.Visible = true;
        }

        private void icon_preferencias_MouseLeave(object sender, EventArgs e)
        {
            lbl_nome_icone.Visible = false;
        }
    }


}

