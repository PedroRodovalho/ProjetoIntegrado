namespace AppDesktop
{
    partial class FormHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.lbl_login_pendente = new System.Windows.Forms.Label();
            this.panel_session = new System.Windows.Forms.Panel();
            this.panel_fazer_login = new System.Windows.Forms.Panel();
            this.lbl_fazer_login = new System.Windows.Forms.Label();
            this.icon_preferencias = new System.Windows.Forms.PictureBox();
            this.icon_financeiro = new System.Windows.Forms.PictureBox();
            this.icon_caixa = new System.Windows.Forms.PictureBox();
            this.icon_cliente = new System.Windows.Forms.PictureBox();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_sessao = new System.Windows.Forms.Panel();
            this.lbl_nome_usuario = new System.Windows.Forms.Label();
            this.link_sair = new System.Windows.Forms.LinkLabel();
            this.btn_vendas = new System.Windows.Forms.Button();
            this.lbl_nome_icone = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.icon_estoque = new System.Windows.Forms.PictureBox();
            this.btn_regra = new System.Windows.Forms.Button();
            this.panel_home = new System.Windows.Forms.Panel();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPage_Inicio = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_notificacao_usuario = new System.Windows.Forms.Label();
            this.lbl_advertencia_usuario = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_cargo = new System.Windows.Forms.Label();
            this.lbl_data_cadastro_usuario = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGrid_notificacoes = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_administrativo = new System.Windows.Forms.Panel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.link_gerenciar_usuario = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusConexao = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorker_InicializaSistema = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker_AbreVendas = new System.ComponentModel.BackgroundWorker();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer_bloqueio = new System.Windows.Forms.Timer(this.components);
            this.panel_session.SuspendLayout();
            this.panel_fazer_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_preferencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_financeiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_caixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_cliente)).BeginInit();
            this.panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_sessao.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_estoque)).BeginInit();
            this.panel_home.SuspendLayout();
            this.tab.SuspendLayout();
            this.tabPage_Inicio.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_notificacoes)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel_administrativo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_login_pendente
            // 
            resources.ApplyResources(this.lbl_login_pendente, "lbl_login_pendente");
            this.lbl_login_pendente.BackColor = System.Drawing.Color.Transparent;
            this.lbl_login_pendente.ForeColor = System.Drawing.Color.White;
            this.lbl_login_pendente.Name = "lbl_login_pendente";
            // 
            // panel_session
            // 
            this.panel_session.BackColor = System.Drawing.Color.Transparent;
            this.panel_session.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_session.Controls.Add(this.lbl_login_pendente);
            this.panel_session.Controls.Add(this.panel_fazer_login);
            resources.ApplyResources(this.panel_session, "panel_session");
            this.panel_session.Name = "panel_session";
            this.panel_session.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_session_Paint);
            // 
            // panel_fazer_login
            // 
            this.panel_fazer_login.BackColor = System.Drawing.Color.Maroon;
            this.panel_fazer_login.Controls.Add(this.lbl_fazer_login);
            resources.ApplyResources(this.panel_fazer_login, "panel_fazer_login");
            this.panel_fazer_login.Name = "panel_fazer_login";
            this.panel_fazer_login.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_fazer_login_Paint);
            // 
            // lbl_fazer_login
            // 
            this.lbl_fazer_login.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.lbl_fazer_login, "lbl_fazer_login");
            this.lbl_fazer_login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_fazer_login.Name = "lbl_fazer_login";
            this.lbl_fazer_login.Click += new System.EventHandler(this.lbl_fazer_login_Click);
            this.lbl_fazer_login.MouseEnter += new System.EventHandler(this.lbl_fazer_login_MouseEnter);
            this.lbl_fazer_login.MouseLeave += new System.EventHandler(this.lbl_fazer_login_MouseLeave);
            // 
            // icon_preferencias
            // 
            this.icon_preferencias.BackColor = System.Drawing.Color.Transparent;
            this.icon_preferencias.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.icon_preferencias, "icon_preferencias");
            this.icon_preferencias.Name = "icon_preferencias";
            this.icon_preferencias.TabStop = false;
            this.icon_preferencias.Click += new System.EventHandler(this.icon_preferencias_Click);
            this.icon_preferencias.MouseEnter += new System.EventHandler(this.icon_preferencias_MouseEnter);
            this.icon_preferencias.MouseLeave += new System.EventHandler(this.icon_preferencias_MouseLeave);
            // 
            // icon_financeiro
            // 
            this.icon_financeiro.BackColor = System.Drawing.Color.Transparent;
            this.icon_financeiro.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.icon_financeiro, "icon_financeiro");
            this.icon_financeiro.Name = "icon_financeiro";
            this.icon_financeiro.TabStop = false;
            this.icon_financeiro.Click += new System.EventHandler(this.icon_financeiro_Click);
            this.icon_financeiro.MouseEnter += new System.EventHandler(this.icon_financeiro_MouseEnter);
            this.icon_financeiro.MouseLeave += new System.EventHandler(this.icon_financeiro_MouseLeave);
            // 
            // icon_caixa
            // 
            this.icon_caixa.BackColor = System.Drawing.Color.Transparent;
            this.icon_caixa.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.icon_caixa, "icon_caixa");
            this.icon_caixa.Name = "icon_caixa";
            this.icon_caixa.TabStop = false;
            this.icon_caixa.Click += new System.EventHandler(this.icon_caixa_Click);
            this.icon_caixa.MouseEnter += new System.EventHandler(this.icon_caixa_MouseEnter);
            this.icon_caixa.MouseLeave += new System.EventHandler(this.icon_caixa_MouseLeave_1);
            // 
            // icon_cliente
            // 
            this.icon_cliente.BackColor = System.Drawing.Color.Transparent;
            this.icon_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.icon_cliente, "icon_cliente");
            this.icon_cliente.Name = "icon_cliente";
            this.icon_cliente.TabStop = false;
            this.icon_cliente.Click += new System.EventHandler(this.icon_cliente_Click);
            this.icon_cliente.MouseEnter += new System.EventHandler(this.icon_cliente_MouseEnter);
            this.icon_cliente.MouseLeave += new System.EventHandler(this.icon_cliente_MouseLeave);
            // 
            // panel_menu
            // 
            resources.ApplyResources(this.panel_menu, "panel_menu");
            this.panel_menu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_menu.Controls.Add(this.pictureBox2);
            this.panel_menu.Controls.Add(this.pictureBox1);
            this.panel_menu.Controls.Add(this.panel_sessao);
            this.panel_menu.Controls.Add(this.btn_vendas);
            this.panel_menu.Controls.Add(this.lbl_nome_icone);
            this.panel_menu.Controls.Add(this.panel1);
            this.panel_menu.Controls.Add(this.btn_regra);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_menu_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panel_sessao
            // 
            this.panel_sessao.BackColor = System.Drawing.Color.Orange;
            this.panel_sessao.Controls.Add(this.lbl_nome_usuario);
            this.panel_sessao.Controls.Add(this.link_sair);
            resources.ApplyResources(this.panel_sessao, "panel_sessao");
            this.panel_sessao.Name = "panel_sessao";
            this.panel_sessao.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_sessao_Paint);
            // 
            // lbl_nome_usuario
            // 
            this.lbl_nome_usuario.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lbl_nome_usuario, "lbl_nome_usuario");
            this.lbl_nome_usuario.Name = "lbl_nome_usuario";
            // 
            // link_sair
            // 
            resources.ApplyResources(this.link_sair, "link_sair");
            this.link_sair.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.link_sair.Name = "link_sair";
            this.link_sair.TabStop = true;
            this.link_sair.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_sair_LinkClicked);
            // 
            // btn_vendas
            // 
            resources.ApplyResources(this.btn_vendas, "btn_vendas");
            this.btn_vendas.Name = "btn_vendas";
            this.btn_vendas.UseVisualStyleBackColor = true;
            this.btn_vendas.Click += new System.EventHandler(this.btn_vendas_Click);
            // 
            // lbl_nome_icone
            // 
            resources.ApplyResources(this.lbl_nome_icone, "lbl_nome_icone");
            this.lbl_nome_icone.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nome_icone.ForeColor = System.Drawing.Color.White;
            this.lbl_nome_icone.Name = "lbl_nome_icone";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.icon_preferencias);
            this.panel1.Controls.Add(this.icon_cliente);
            this.panel1.Controls.Add(this.icon_estoque);
            this.panel1.Controls.Add(this.icon_financeiro);
            this.panel1.Controls.Add(this.icon_caixa);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // icon_estoque
            // 
            this.icon_estoque.BackColor = System.Drawing.Color.Transparent;
            this.icon_estoque.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.icon_estoque, "icon_estoque");
            this.icon_estoque.Name = "icon_estoque";
            this.icon_estoque.TabStop = false;
            this.icon_estoque.Click += new System.EventHandler(this.icon_estoque_Click);
            this.icon_estoque.MouseEnter += new System.EventHandler(this.icon_estoque_MouseEnter);
            this.icon_estoque.MouseLeave += new System.EventHandler(this.icon_estoque_MouseLeave);
            // 
            // btn_regra
            // 
            resources.ApplyResources(this.btn_regra, "btn_regra");
            this.btn_regra.Name = "btn_regra";
            this.btn_regra.UseVisualStyleBackColor = true;
            this.btn_regra.Click += new System.EventHandler(this.btn_regra_Click);
            // 
            // panel_home
            // 
            resources.ApplyResources(this.panel_home, "panel_home");
            this.panel_home.Controls.Add(this.tab);
            this.panel_home.Name = "panel_home";
            this.panel_home.SizeChanged += new System.EventHandler(this.panel_home_SizeChanged);
            // 
            // tab
            // 
            resources.ApplyResources(this.tab, "tab");
            this.tab.Controls.Add(this.tabPage_Inicio);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tab_DrawItem);
            // 
            // tabPage_Inicio
            // 
            this.tabPage_Inicio.Controls.Add(this.panel4);
            this.tabPage_Inicio.Controls.Add(this.panel3);
            this.tabPage_Inicio.Controls.Add(this.panel_administrativo);
            resources.ApplyResources(this.tabPage_Inicio, "tabPage_Inicio");
            this.tabPage_Inicio.Name = "tabPage_Inicio";
            this.tabPage_Inicio.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.lbl_notificacao_usuario);
            this.panel4.Controls.Add(this.lbl_advertencia_usuario);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.lbl_cargo);
            this.panel4.Controls.Add(this.lbl_data_cadastro_usuario);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.panel5);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lbl_notificacao_usuario
            // 
            resources.ApplyResources(this.lbl_notificacao_usuario, "lbl_notificacao_usuario");
            this.lbl_notificacao_usuario.Name = "lbl_notificacao_usuario";
            // 
            // lbl_advertencia_usuario
            // 
            resources.ApplyResources(this.lbl_advertencia_usuario, "lbl_advertencia_usuario");
            this.lbl_advertencia_usuario.Name = "lbl_advertencia_usuario";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // lbl_cargo
            // 
            resources.ApplyResources(this.lbl_cargo, "lbl_cargo");
            this.lbl_cargo.Name = "lbl_cargo";
            // 
            // lbl_data_cadastro_usuario
            // 
            resources.ApplyResources(this.lbl_data_cadastro_usuario, "lbl_data_cadastro_usuario");
            this.lbl_data_cadastro_usuario.Name = "lbl_data_cadastro_usuario";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkRed;
            this.panel5.Controls.Add(this.label2);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGrid_notificacoes);
            this.panel3.Controls.Add(this.panel6);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // dataGrid_notificacoes
            // 
            this.dataGrid_notificacoes.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_notificacoes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGrid_notificacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGrid_notificacoes, "dataGrid_notificacoes");
            this.dataGrid_notificacoes.Name = "dataGrid_notificacoes";
            this.dataGrid_notificacoes.RowHeadersVisible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkRed;
            this.panel6.Controls.Add(this.label6);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Name = "label6";
            // 
            // panel_administrativo
            // 
            this.panel_administrativo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_administrativo.Controls.Add(this.linkLabel4);
            this.panel_administrativo.Controls.Add(this.linkLabel3);
            this.panel_administrativo.Controls.Add(this.link_gerenciar_usuario);
            this.panel_administrativo.Controls.Add(this.linkLabel1);
            this.panel_administrativo.Controls.Add(this.panel2);
            resources.ApplyResources(this.panel_administrativo, "panel_administrativo");
            this.panel_administrativo.Name = "panel_administrativo";
            // 
            // linkLabel4
            // 
            resources.ApplyResources(this.linkLabel4, "linkLabel4");
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.TabStop = true;
            // 
            // linkLabel3
            // 
            resources.ApplyResources(this.linkLabel3, "linkLabel3");
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.TabStop = true;
            // 
            // link_gerenciar_usuario
            // 
            resources.ApplyResources(this.link_gerenciar_usuario, "link_gerenciar_usuario");
            this.link_gerenciar_usuario.Name = "link_gerenciar_usuario";
            this.link_gerenciar_usuario.TabStop = true;
            this.link_gerenciar_usuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_gerenciar_usuario_LinkClicked);
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Controls.Add(this.label1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusConexao,
            this.toolStripStatusLabel1});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // StatusConexao
            // 
            this.StatusConexao.Name = "StatusConexao";
            resources.ApplyResources(this.StatusConexao, "StatusConexao");
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            // 
            // backgroundWorker_InicializaSistema
            // 
            this.backgroundWorker_InicializaSistema.WorkerReportsProgress = true;
            this.backgroundWorker_InicializaSistema.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_InicializaSistema_DoWork);
            this.backgroundWorker_InicializaSistema.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_InicializaSistema_ProgressChanged);
            this.backgroundWorker_InicializaSistema.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_InicializaSistema_RunWorkerCompleted);
            // 
            // backgroundWorker_AbreVendas
            // 
            this.backgroundWorker_AbreVendas.WorkerReportsProgress = true;
            this.backgroundWorker_AbreVendas.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_AbreVendas_DoWork);
            this.backgroundWorker_AbreVendas.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_AbreVendas_ProgressChanged);
            this.backgroundWorker_AbreVendas.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_AbreVendas_RunWorkerCompleted);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // timer_bloqueio
            // 
            this.timer_bloqueio.Enabled = true;
            this.timer_bloqueio.Interval = 10000;
            this.timer_bloqueio.Tick += new System.EventHandler(this.timer_bloqueio_Tick);
            // 
            // FormHome
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel_home);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.panel_session);
            this.Name = "FormHome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormHome_KeyPress);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormHome_MouseMove);
            this.Resize += new System.EventHandler(this.FormHome_Resize);
            this.panel_session.ResumeLayout(false);
            this.panel_session.PerformLayout();
            this.panel_fazer_login.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icon_preferencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_financeiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_caixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_cliente)).EndInit();
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_sessao.ResumeLayout(false);
            this.panel_sessao.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_estoque)).EndInit();
            this.panel_home.ResumeLayout(false);
            this.tab.ResumeLayout(false);
            this.tabPage_Inicio.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_notificacoes)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel_administrativo.ResumeLayout(false);
            this.panel_administrativo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_login_pendente;
        private System.Windows.Forms.Panel panel_session;
        private System.Windows.Forms.Panel panel_fazer_login;
        private System.Windows.Forms.Label lbl_fazer_login;
        private System.Windows.Forms.PictureBox icon_caixa;
        private System.Windows.Forms.PictureBox icon_preferencias;
        private System.Windows.Forms.PictureBox icon_financeiro;
        private System.Windows.Forms.PictureBox icon_cliente;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel_home;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.PictureBox icon_estoque;
        private System.Windows.Forms.Button btn_regra;
        private System.Windows.Forms.Label lbl_nome_icone;
        private System.Windows.Forms.Button btn_vendas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripStatusLabel StatusConexao;
        private System.ComponentModel.BackgroundWorker backgroundWorker_InicializaSistema;
        private System.Windows.Forms.LinkLabel link_sair;
        private System.Windows.Forms.Label lbl_nome_usuario;
        private System.Windows.Forms.Panel panel_sessao;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker_AbreVendas;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage tabPage_Inicio;
        private System.Windows.Forms.Panel panel_administrativo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel link_gerenciar_usuario;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_notificacao_usuario;
        private System.Windows.Forms.Label lbl_advertencia_usuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_cargo;
        private System.Windows.Forms.Label lbl_data_cadastro_usuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGrid_notificacoes;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer_bloqueio;
    }
}

