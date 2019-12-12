using AppDesktop.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;

using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//using WinFormAnimation;

namespace AppDesktop
{
    public partial class FormHome : Form
    {
        public Usuario usuario;
        Perfil perfil;
        public Session activeSession;
        //VARIAVEIS DE PERFIL DE ACESSO;
        string acesso_financeiro = "BEAT/USUARIO/SFC/" ;
        string acesso_estoque = "BEAT/USUARIO/ESTOQUE/";
        string acesso_vendas = "BEAT/USUARIO/VENDAS/";
        string acesso_clientes = "BEAT/USUARIO/CLIENTES";
        //LISTAS//


        List<Notificacao> notificacoes_usuario = new List<Notificacao>();
        //VARIAVEIS//
        int qtd_notificacao = 0, qtd_advertencia = 0;
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
                Properties.Settings.Default.Save();

                if (result == DialogResult.Abort)
                {
                    MessageBox.Show("Para utilizar o BEAT System é necessário realizar as configurações iniciais para definir os paramêtros de conexão do banco de dados e" +
                        " de funcionamento do sistema. O aplicativo será encerrado", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    solicitaLogin();
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


                formLogin = new FormLogin(this);
                DialogResult session = formLogin.ShowDialog();

                if (session == DialogResult.OK)
                {
                    //lbl_login_pendente.Text = "ENTROU";
                    lbl_fazer_login.Visible = false;
                    if (panel_session.Visible)
                    {
                        panel_session.Visible = false;
                    }
                    InicializaSistema();
                }
                else
                {
                    panel_session.Visible = true;
                    lbl_login_pendente.Visible = true;
                    panel_fazer_login.Visible = true;
                    lbl_fazer_login.Visible = true;
                }
            }
            else InicializaSistema();
            

        }
        FormMensagemAguarde formMensagem = null;
        public void InicializaSistema()
        {
            formMensagem = new FormMensagemAguarde("CARREGANDO SISTEMA AGUARDE");
            formMensagem.Show();
            //FormataGridNotificacao();
            backgroundWorker_InicializaSistema.RunWorkerAsync();

        }

        private void FormataGridNotificacao()
        {
            dataGrid_notificacoes.Columns["id"].Visible = false;
            dataGrid_notificacoes.Columns["id_remetente"].Visible = false;
            dataGrid_notificacoes.Columns["id_destinatario"].Visible = false;
            
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

        private void panel_session_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                              Color.OrangeRed,
                                                              Color.DarkGoldenrod,
                                                              100F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }


        FormCaixa formCaixa = null;
        FormLogin_Financeiro formFinanceiro_Login = null;
        FormCliente formCliente = null;
        FormEstoque formEstoque = null;
        FormRegrasNegocio formRegrasNegocio = null;
        FormVenda formVenda = null;



        TabPage tab_caixa = new TabPage();
        TabPage tab_cliente = new TabPage();
        TabPage tab_financeiro = new TabPage();
        TabPage tab_estoque = new TabPage();
        TabPage tab_regra_negocio = new TabPage();
        TabPage tab_vendas = new TabPage();

        Conversor conversor = new Conversor();

        
      
   

        private void icon_caixa_Click(object sender, EventArgs e)
        {
            if (!tab.TabPages.Contains(tab_caixa))
            {


                tab.TabPages.Add(tab_caixa);
                tab_caixa.Text = "Caixa";
                formCaixa = new FormCaixa();
                formCaixa.TopLevel = false;
                formCaixa.Visible = true;
                tab_caixa.Controls.Add(formCaixa);
                
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
            /*if (!tab.TabPages.Contains(tab_financeiro))
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
            }*/

            formFinanceiro_Login = new FormLogin_Financeiro();
            formFinanceiro_Login.Show();
            this.Visible = false;

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

                formEstoque = new FormEstoque(this);
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
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                             Color.DarkSlateGray,
                                                             Color.White,
                                                             90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
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


        private void icon_preferencias_Click(object sender, EventArgs e)
        {

        }

        private void btn_vendas_Click(object sender, EventArgs e)
        {

            if (!tab.TabPages.Contains(tab_vendas))
            {
                formMensagem = AbreMensagemAguarde("CARREGANDO VENDAS - Conectando com o banco!");
                

                
                formMensagem.Show();
                tab_vendas.Size = new Size(tab_vendas.Size.Width, 1400);
                tab_vendas.Text = "Vendas";

                tab.TabPages.Add(tab_vendas);
                
                backgroundWorker_AbreVendas.RunWorkerAsync();
                //formVenda = new FormVenda();
                //formVenda.TopLevel = false;
                //formVenda.Visible = true;
                //tab_vendas.Controls.Add(formVenda);
                // this.Controls.Add(formCaixa);
                tab.SelectedTab = tab_vendas;
            }
            else
            {
                tab.SelectedTab = tab_vendas;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath PastaGrafica = new GraphicsPath();
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, panel1.Size.Width, panel1.Height));

            //Arredondar canto superior esquerdo        
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, 10, 10));
            PastaGrafica.AddPie(1, 1, 20, 20, 180, 90);

            //Arredondar canto superior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(panel1.Width - 12, 1, 12, 13));
            PastaGrafica.AddPie(panel1.Width - 24, 1, 24, 26, 270, 90);

            //Arredondar canto inferior esquerdo
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, panel1.Height - 10, 10, 10));
            PastaGrafica.AddPie(1, panel1.Height - 20, 20, 20, 90, 90);

            //Arredondar canto inferior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(panel1.Width - 12, panel1.Height - 13, 13, 13));
            PastaGrafica.AddPie(panel1.Width - 24, panel1.Height - 26, 24, 26, 0, 90);

            PastaGrafica.SetMarkers();
            panel1.Region = new Region(PastaGrafica);
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                            Color.Orange,
                                                            Color.Black,
                                                            90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }

        }
        Config config = new Config();

       

        private void ConfiguraItens()
        {
            //Controle do caixa;
            
            if (!activeSession.RequestFullPermissionCaixa())
            {
                if (!activeSession.RequestInsertCaixa()) icon_caixa.Visible = false;
                if (!activeSession.RequestSelectCaixa()) btn_vendas.Visible = false;
            }
            if (!activeSession.RequestFullPermissionEstoque())
            {
                if (!activeSession.RequestSelectEstoque()) icon_estoque.Visible = false;
               
            }
            if (!activeSession.RequestFullPermissionCliente()) icon_cliente.Visible = false;
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

        private void panel_sessao_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void link_sair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            Application.Restart();
        }

        private void icon_caixa_MouseEnter(object sender, EventArgs e)
        {
            lbl_nome_icone.Text = "CAIXA";
            lbl_nome_icone.Visible = true;
        }

        private void icon_caixa_MouseLeave_1(object sender, EventArgs e)
        {
            lbl_nome_icone.Visible = false;
        }

        public FormMensagemAguarde AbreMensagemAguarde(string mensagem)
        {
            FormMensagemAguarde formMensagem = new FormMensagemAguarde(mensagem);
            
           
            //formMensagem.Show();
            return formMensagem;
        }

        //EXECUÇÕES EM SEGUNDO PLANO//
        private void backgroundWorker_InicializaSistema_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundWorker_InicializaSistema.ReportProgress(1, "Conectando com o banco de dados!");
            UsuarioDAO usuarioDAO = new UsuarioDAO();
           
            backgroundWorker_InicializaSistema.ReportProgress(5, "Buscando perfil de usuário!");
            
            perfil = usuarioDAO.BuscaPerfil(usuario);
            backgroundWorker_InicializaSistema.ReportProgress(10, "Verificando permissões!");
            
            ControleUsuarios controleUsuarios = new ControleUsuarios(usuario);
            backgroundWorker_InicializaSistema.ReportProgress(15, "Verificando permissões - CAIXA!");
            
            PermissaoCaixa permissaoCaixa = controleUsuarios.PedePermissaoCaixa();
            backgroundWorker_InicializaSistema.ReportProgress(25, "Verificando permissões - CLIENTE");
            


            PermissaoCliente permissaoCliente = controleUsuarios.PedePermissaoCliente();
            backgroundWorker_InicializaSistema.ReportProgress(35, "Verificando permissões - ESTOQUE");
            
            PermissaoEstoque permissaoEstoque = controleUsuarios.PedePermissaoEstoque();
            
            backgroundWorker_InicializaSistema.ReportProgress(45, "Criando sessão!");
            activeSession = new Session(permissaoCaixa, permissaoCliente, permissaoEstoque);
            backgroundWorker_InicializaSistema.ReportProgress(65, "Carregando painel de notificações!");
            notificacoes_usuario = usuarioDAO.CarregaNotificacao(usuario.Id);
            for(int i = 0; i < notificacoes_usuario.Count; i++)
            {
                if (notificacoes_usuario[i].Tipo.Equals("Advertência"))
                {
                    qtd_advertencia++;
                }
                else if(notificacoes_usuario[i].Tipo.Equals("Notificação")) 
                {
                    qtd_notificacao++;
                }
            }
            backgroundWorker_InicializaSistema.ReportProgress(75, "Finalizando configuração!");
            
            ConfiguraItens();
            backgroundWorker_InicializaSistema.ReportProgress(100, "Finalizado");
          

        }
        private void backgroundWorker_InicializaSistema_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            formMensagem.Close();
            formMensagem = null;
            panel_menu.Visible = true;
            
            panel_menu.Visible = true;
            panel_home.Visible = true;
            lbl_nome_usuario.Text = perfil.Nome;
            lbl_data_cadastro_usuario.Text = perfil.Data_cadastro;
            dataGrid_notificacoes.DataSource = notificacoes_usuario;
            FormataGridNotificacao();
            
        }
        private void backgroundWorker_AbreVendas_DoWork(object sender, DoWorkEventArgs e)
        {

            backgroundWorker_AbreVendas.ReportProgress(99);
            formVenda = new FormVenda();
            backgroundWorker_AbreVendas.ReportProgress(100);

        }

        private void backgroundWorker_AbreVendas_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            formMensagem.Close();
            formMensagem = null;
            formVenda.TopLevel = false;
            tab_vendas.Controls.Add(formVenda);
            formVenda.Visible = true;
        }

        private void backgroundWorker_AbreVendas_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            formMensagem.progressBar1.Value = e.ProgressPercentage;
            formMensagem.AtualizaMensagemTopo("CARREGANDO VENDAS - Criando listas");
            
        }

        private void backgroundWorker_InicializaSistema_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            formMensagem.progressBar1.Value = e.ProgressPercentage;
            formMensagem.AtualizaMensagemBot(e.UserState.ToString());
        }

        private void FormHome_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;
                this.ShowInTaskbar = false;
                this.WindowState = FormWindowState.Minimized;
                notifyIcon1.Visible = true;
            }
        }

        FormGerenciarUsuario formGerenciarUsuario = null;

        private void FormHome_MouseMove(object sender, MouseEventArgs e)
        {
            ResetaTimerBloqueio();
        }

        private void timer_bloqueio_Tick(object sender, EventArgs e)
        {
           // MessageBox.Show("BLOQUEADO");
        }

        private void FormHome_KeyPress(object sender, KeyPressEventArgs e)
        {
            ResetaTimerBloqueio();
        }

        private void ResetaTimerBloqueio()
        {
            timer_bloqueio.Stop();
            timer_bloqueio.Start();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            
            this.WindowState = FormWindowState.Maximized;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
        }

        private void link_gerenciar_usuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formGerenciarUsuario = new FormGerenciarUsuario();
            formGerenciarUsuario.Show();
        }
    }


}

