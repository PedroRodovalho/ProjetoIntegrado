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
            this.label2 = new System.Windows.Forms.Label();
            this.icon_caixa = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.icon_cliente = new System.Windows.Forms.PictureBox();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.lbl_caixa = new System.Windows.Forms.Label();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.icon_estoque = new System.Windows.Forms.PictureBox();
            this.panel_home = new System.Windows.Forms.Panel();
            this.tab = new System.Windows.Forms.TabControl();
            this.label_menu = new System.Windows.Forms.Label();
            this.panel_session.SuspendLayout();
            this.panel_fazer_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_preferencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_financeiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_caixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_cliente)).BeginInit();
            this.panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_estoque)).BeginInit();
            this.panel_home.SuspendLayout();
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
            // 
            // icon_financeiro
            // 
            resources.ApplyResources(this.icon_financeiro, "icon_financeiro");
            this.icon_financeiro.Name = "icon_financeiro";
            this.icon_financeiro.TabStop = false;
            this.icon_financeiro.Click += new System.EventHandler(this.icon_financeiro_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
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
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // icon_cliente
            // 
            resources.ApplyResources(this.icon_cliente, "icon_cliente");
            this.icon_cliente.Name = "icon_cliente";
            this.icon_cliente.TabStop = false;
            this.icon_cliente.Click += new System.EventHandler(this.icon_cliente_Click);
            // 
            // lbl_cliente
            // 
            resources.ApplyResources(this.lbl_cliente, "lbl_cliente");
            this.lbl_cliente.ForeColor = System.Drawing.Color.White;
            this.lbl_cliente.Name = "lbl_cliente";
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
            this.panel_menu.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_menu.Controls.Add(this.icon_preferencias);
            this.panel_menu.Controls.Add(this.icon_financeiro);
            this.panel_menu.Controls.Add(this.lbl_caixa);
            this.panel_menu.Controls.Add(this.label2);
            this.panel_menu.Controls.Add(this.label3);
            this.panel_menu.Controls.Add(this.lbl_cliente);
            this.panel_menu.Controls.Add(this.icon_caixa);
            this.panel_menu.Controls.Add(this.icon_estoque);
            this.panel_menu.Controls.Add(this.icon_cliente);
            this.panel_menu.Controls.Add(this.label1);
            this.panel_menu.Name = "panel_menu";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // icon_estoque
            // 
            this.icon_estoque.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.icon_estoque, "icon_estoque");
            this.icon_estoque.Name = "icon_estoque";
            this.icon_estoque.TabStop = false;
            this.icon_estoque.Click += new System.EventHandler(this.icon_estoque_Click);
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
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tab_DrawItem);
            // 
            // label_menu
            // 
            this.label_menu.BackColor = System.Drawing.SystemColors.GrayText;
            resources.ApplyResources(this.label_menu, "label_menu");
            this.label_menu.Name = "label_menu";
            // 
            // FormHome
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.label_menu);
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
            this.panel_home.ResumeLayout(false);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.Label lbl_caixa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel_home;
        private System.Windows.Forms.Label label_menu;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox icon_estoque;
    }
}

