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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_session.SuspendLayout();
            this.panel_fazer_login.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Name = "label1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // FormHome
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_session);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormHome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_session.ResumeLayout(false);
            this.panel_session.PerformLayout();
            this.panel_fazer_login.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_login_pendente;
        private System.Windows.Forms.Panel panel_session;
        private System.Windows.Forms.Panel panel_fazer_login;
        private System.Windows.Forms.Label lbl_fazer_login;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

