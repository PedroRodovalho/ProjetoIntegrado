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
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_logar = new System.Windows.Forms.Button();
            this.panel_session = new System.Windows.Forms.Panel();
            this.panel_session.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(140, 121);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(45, 13);
            this.lbl_status.TabIndex = 0;
            this.lbl_status.Text = "lblstatus";
            // 
            // btn_logar
            // 
            this.btn_logar.Location = new System.Drawing.Point(552, 116);
            this.btn_logar.Name = "btn_logar";
            this.btn_logar.Size = new System.Drawing.Size(75, 23);
            this.btn_logar.TabIndex = 1;
            this.btn_logar.Text = "Fazer Login";
            this.btn_logar.UseVisualStyleBackColor = true;
            this.btn_logar.Visible = false;
            this.btn_logar.Click += new System.EventHandler(this.btn_logar_Click);
            // 
            // panel_session
            // 
            this.panel_session.Controls.Add(this.lbl_status);
            this.panel_session.Controls.Add(this.btn_logar);
            this.panel_session.Location = new System.Drawing.Point(299, 174);
            this.panel_session.Name = "panel_session";
            this.panel_session.Size = new System.Drawing.Size(829, 388);
            this.panel_session.TabIndex = 2;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel_session);
            this.Name = "FormHome";
            this.Text = "Aplicação desktop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_session.ResumeLayout(false);
            this.panel_session.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button btn_logar;
        private System.Windows.Forms.Panel panel_session;
    }
}

