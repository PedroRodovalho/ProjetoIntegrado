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
            this.panel_menu = new System.Windows.Forms.Panel();
            this.icon_preferencias = new System.Windows.Forms.PictureBox();
            this.icon_financeiro = new System.Windows.Forms.PictureBox();
            this.icon_cliente = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.lbl_caixa = new System.Windows.Forms.Label();
            this.icon_caixa = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel_session.SuspendLayout();
            this.panel_fazer_login.SuspendLayout();
            this.panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_preferencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_financeiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_caixa)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_login_pendente
            // 
            resources.ApplyResources(this.lbl_login_pendente, "lbl_login_pendente");
            this.lbl_login_pendente.Name = "lbl_login_pendente";
            // 
            // panel_session
            // 
            this.panel_session.Controls.Add(this.lbl_login_pendente);
            this.panel_session.Controls.Add(this.panel_fazer_login);
            resources.ApplyResources(this.panel_session, "panel_session");
            this.panel_session.Name = "panel_session";
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
            // panel_menu
            // 
            this.panel_menu.Controls.Add(this.icon_preferencias);
            this.panel_menu.Controls.Add(this.icon_financeiro);
            this.panel_menu.Controls.Add(this.icon_cliente);
            this.panel_menu.Controls.Add(this.label2);
            this.panel_menu.Controls.Add(this.label1);
            this.panel_menu.Controls.Add(this.lbl_cliente);
            this.panel_menu.Controls.Add(this.lbl_caixa);
            this.panel_menu.Controls.Add(this.icon_caixa);
            resources.ApplyResources(this.panel_menu, "panel_menu");
            this.panel_menu.Name = "panel_menu";
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
            // 
            // icon_cliente
            // 
            resources.ApplyResources(this.icon_cliente, "icon_cliente");
            this.icon_cliente.Name = "icon_cliente";
            this.icon_cliente.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lbl_cliente
            // 
            resources.ApplyResources(this.lbl_cliente, "lbl_cliente");
            this.lbl_cliente.Name = "lbl_cliente";
            // 
            // lbl_caixa
            // 
            resources.ApplyResources(this.lbl_caixa, "lbl_caixa");
            this.lbl_caixa.Name = "lbl_caixa";
            // 
            // icon_caixa
            // 
            resources.ApplyResources(this.icon_caixa, "icon_caixa");
            this.icon_caixa.Name = "icon_caixa";
            this.icon_caixa.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FormHome
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.panel_session);
            this.Name = "FormHome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_session.ResumeLayout(false);
            this.panel_session.PerformLayout();
            this.panel_fazer_login.ResumeLayout(false);
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_preferencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_financeiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_caixa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_login_pendente;
        private System.Windows.Forms.Panel panel_session;
        private System.Windows.Forms.Panel panel_fazer_login;
        private System.Windows.Forms.Label lbl_fazer_login;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.PictureBox icon_caixa;
        private System.Windows.Forms.PictureBox icon_preferencias;
        private System.Windows.Forms.PictureBox icon_financeiro;
        private System.Windows.Forms.PictureBox icon_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.Label lbl_caixa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

