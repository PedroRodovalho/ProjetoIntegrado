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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.lbl_login_pendente = new System.Windows.Forms.Label();
            this.panel_session = new System.Windows.Forms.Panel();
            this.panel_fazer_login = new System.Windows.Forms.Panel();
            this.lbl_fazer_login = new System.Windows.Forms.Label();
            this.icon_preferencias = new System.Windows.Forms.PictureBox();
            this.icon_financeiro = new System.Windows.Forms.PictureBox();
            this.icon_caixa = new System.Windows.Forms.PictureBox();
            this.icon_cliente = new System.Windows.Forms.PictureBox();
            this.lbl_caixa = new System.Windows.Forms.Label();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.btn_regra = new System.Windows.Forms.Button();
            this.lbl_nome_icone = new System.Windows.Forms.Label();
            this.icon_estoque = new System.Windows.Forms.PictureBox();
            this.panel_home = new System.Windows.Forms.Panel();
            this.tab = new System.Windows.Forms.TabControl();
            this.panel_session.SuspendLayout();
            this.panel_fazer_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_preferencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_financeiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_caixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_cliente)).BeginInit();
            this.panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_estoque)).BeginInit();
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
            this.panel_session.BackColor = System.Drawing.SystemColors.WindowFrame;
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
            resources.ApplyResources(this.icon_preferencias, "icon_preferencias");
            this.icon_preferencias.Name = "icon_preferencias";
            this.icon_preferencias.TabStop = false;
            this.icon_preferencias.MouseEnter += new System.EventHandler(this.icon_preferencias_MouseEnter);
            this.icon_preferencias.MouseLeave += new System.EventHandler(this.icon_preferencias_MouseLeave);
            // 
            // icon_financeiro
            // 
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
            this.icon_caixa.MouseLeave += new System.EventHandler(this.icon_caixa_MouseLeave);
            // 
            // icon_cliente
            // 
            resources.ApplyResources(this.icon_cliente, "icon_cliente");
            this.icon_cliente.Name = "icon_cliente";
            this.icon_cliente.TabStop = false;
            this.icon_cliente.Click += new System.EventHandler(this.icon_cliente_Click);
            this.icon_cliente.MouseEnter += new System.EventHandler(this.icon_cliente_MouseEnter);
            this.icon_cliente.MouseLeave += new System.EventHandler(this.icon_cliente_MouseLeave);
            // 
            // lbl_caixa
            // 
            resources.ApplyResources(this.lbl_caixa, "lbl_caixa");
            this.lbl_caixa.ForeColor = System.Drawing.Color.White;
            this.lbl_caixa.Name = "lbl_caixa";
            // 
            // panel_menu
            // 
            resources.ApplyResources(this.panel_menu, "panel_menu");
            this.panel_menu.BackColor = System.Drawing.Color.Goldenrod;
            this.panel_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_menu.Controls.Add(this.btn_regra);
            this.panel_menu.Controls.Add(this.icon_preferencias);
            this.panel_menu.Controls.Add(this.icon_financeiro);
            this.panel_menu.Controls.Add(this.lbl_caixa);
            this.panel_menu.Controls.Add(this.lbl_nome_icone);
            this.panel_menu.Controls.Add(this.icon_caixa);
            this.panel_menu.Controls.Add(this.icon_estoque);
            this.panel_menu.Controls.Add(this.icon_cliente);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_menu_Paint);
            // 
            // btn_regra
            // 
            resources.ApplyResources(this.btn_regra, "btn_regra");
            this.btn_regra.Name = "btn_regra";
            this.btn_regra.UseVisualStyleBackColor = true;
            this.btn_regra.Click += new System.EventHandler(this.btn_regra_Click);
            // 
            // lbl_nome_icone
            // 
            resources.ApplyResources(this.lbl_nome_icone, "lbl_nome_icone");
            this.lbl_nome_icone.ForeColor = System.Drawing.Color.Black;
            this.lbl_nome_icone.Name = "lbl_nome_icone";
            // 
            // icon_estoque
            // 
            this.icon_estoque.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.icon_estoque, "icon_estoque");
            this.icon_estoque.Name = "icon_estoque";
            this.icon_estoque.TabStop = false;
            this.icon_estoque.Click += new System.EventHandler(this.icon_estoque_Click);
            this.icon_estoque.MouseEnter += new System.EventHandler(this.icon_estoque_MouseEnter);
            this.icon_estoque.MouseLeave += new System.EventHandler(this.icon_estoque_MouseLeave);
            // 
            // panel_home
            // 
            resources.ApplyResources(this.panel_home, "panel_home");
            this.panel_home.Name = "panel_home";
            this.panel_home.SizeChanged += new System.EventHandler(this.panel_home_SizeChanged);
            // 
            // tab
            // 
            resources.ApplyResources(this.tab, "tab");
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tab_DrawItem);
            // 
            // FormHome
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tab);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.panel_home);
            this.Controls.Add(this.panel_session);
            this.Name = "FormHome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_session.ResumeLayout(false);
            this.panel_session.PerformLayout();
            this.panel_fazer_login.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icon_preferencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_financeiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_caixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_cliente)).EndInit();
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_estoque)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label lbl_caixa;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel_home;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.PictureBox icon_estoque;
        private System.Windows.Forms.Button btn_regra;
        private System.Windows.Forms.Label lbl_nome_icone;
    }
}

