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
            this.panel_session.SuspendLayout();
            this.panel_fazer_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_login_pendente
            // 
            resources.ApplyResources(this.lbl_login_pendente, "lbl_login_pendente");
            this.lbl_login_pendente.Name = "lbl_login_pendente";
            // 
            // panel_session
            // 
            resources.ApplyResources(this.panel_session, "panel_session");
            this.panel_session.Controls.Add(this.lbl_login_pendente);
            this.panel_session.Controls.Add(this.panel_fazer_login);
            this.panel_session.Name = "panel_session";
            // 
            // panel_fazer_login
            // 
            resources.ApplyResources(this.panel_fazer_login, "panel_fazer_login");
            this.panel_fazer_login.BackColor = System.Drawing.Color.Maroon;
            this.panel_fazer_login.Controls.Add(this.lbl_fazer_login);
            this.panel_fazer_login.Name = "panel_fazer_login";
            this.panel_fazer_login.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_fazer_login_Paint);
            // 
            // lbl_fazer_login
            // 
            resources.ApplyResources(this.lbl_fazer_login, "lbl_fazer_login");
            this.lbl_fazer_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_fazer_login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_fazer_login.Name = "lbl_fazer_login";
            this.lbl_fazer_login.Click += new System.EventHandler(this.lbl_fazer_login_Click);
            this.lbl_fazer_login.MouseEnter += new System.EventHandler(this.lbl_fazer_login_MouseEnter);
            this.lbl_fazer_login.MouseLeave += new System.EventHandler(this.lbl_fazer_login_MouseLeave);
            // 
            // FormHome
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_session);
            this.Name = "FormHome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_session.ResumeLayout(false);
            this.panel_session.PerformLayout();
            this.panel_fazer_login.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_login_pendente;
        private System.Windows.Forms.Panel panel_session;
        private System.Windows.Forms.Panel panel_fazer_login;
        private System.Windows.Forms.Label lbl_fazer_login;
    }
}

