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
using WinFormAnimation;

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
            new Animator2D(new Path2D(new Float2D(-100, 172), icon_caixa.Location.ToFloat2D(), 600))
            .Play(icon_caixa, Animator2D.KnownProperties.Location);
            new Animator2D(new Path2D(new Float2D(-100, 172), icon_cliente.Location.ToFloat2D(), 800))
            .Play(icon_cliente, Animator2D.KnownProperties.Location);
            new Animator2D(new Path2D(new Float2D(-100, 172), icon_financeiro.Location.ToFloat2D(), 1000))
            .Play(icon_financeiro, Animator2D.KnownProperties.Location);
            new Animator2D(new Path2D(new Float2D(-100, 172), icon_preferencias.Location.ToFloat2D(), 1200))
            .Play(icon_preferencias, Animator2D.KnownProperties.Location);


            panel_menu.Visible = true;
            panel_home.Visible = true;
            label_menu.Visible = true;

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
            icon_caixa.Size = new Size(icon_caixa.Size.Width + 10, icon_caixa.Size.Height + 10);
            icon_caixa.Location = new Point(icon_caixa.Location.X - 5, icon_caixa.Location.Y - 5);
        }


        private void icon_caixa_MouseLeave(object sender, EventArgs e)
        {
            icon_caixa.Size = new Size(icon_caixa.Size.Width - 10, icon_caixa.Size.Height - 10);
            icon_caixa.Location = new Point(icon_caixa.Location.X + 5, icon_caixa.Location.Y + 5);
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

        TabPage tab_caixa = new TabPage();
        TabPage tab_cliente = new TabPage();
        TabPage tab_financeiro = new TabPage();
        private void icon_caixa_Click(object sender, EventArgs e)
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

        private void icon_cliente_Click(object sender, EventArgs e)
        {
            FormAba form = new FormAba();
            form.Visible = true;
            tab.TabPages.Add(tab_cliente);
            tab_cliente.Text = "Clientes";
            formCliente = new FormCliente();
            formCliente.TopLevel = false;
            formCliente.Visible = true;
            tab_cliente.Controls.Add(formCliente);

            tab.SelectedTab = tab_cliente;
        }

        private void icon_financeiro_Click(object sender, EventArgs e)
        {

            tab.TabPages.Add(tab_financeiro);
            tab_financeiro.Text = "Financeiro";

            formFinanceiro = new FormFinanceiro();
            formFinanceiro.TopLevel = false;
            formFinanceiro.Visible = true;
            tab_financeiro.Controls.Add(formFinanceiro);

            tab.SelectedTab = tab_financeiro;

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
          /*  var tabPage = this.tab.TabPages[e.Index]; var tabRect = this.tab.GetTabRect(e.Index); tabRect.Inflate(-2, -2); if (e.Index == this.tab.TabCount - 1) { var addImage = Properties.Resources.Teste; e.Graphics.DrawImage(addImage, tabRect.Left + (tabRect.Width - addImage.Width) / 2, tabRect.Top + (tabRect.Height - addImage.Height) / 2); }
            else
            {
                var closeImage = Properties.Resources.DeleteButton_Image; e.Graphics.DrawImage(closeImage, (tabRect.Right - closeImage.Width), tabRect.Top + (tabRect.Height - closeImage.Height) / 2); TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font, tabRect, tabPage.ForeColor, TextFormatFlags.Left);
            }*/
        }
    }
