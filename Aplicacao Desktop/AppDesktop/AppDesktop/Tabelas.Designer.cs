namespace AppDesktop
{
    partial class Tabelas
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
            this.lbl_operacao = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lbl_operacao
            // 
            this.lbl_operacao.AutoSize = true;
            this.lbl_operacao.Location = new System.Drawing.Point(31, 34);
            this.lbl_operacao.Name = "lbl_operacao";
            this.lbl_operacao.Size = new System.Drawing.Size(35, 13);
            this.lbl_operacao.TabIndex = 0;
            this.lbl_operacao.Text = "label1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(20, 50);
            this.progressBar1.Maximum = 40;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(376, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // Tabelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 126);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbl_operacao);
            this.Name = "Tabelas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aguarde";
            this.Load += new System.EventHandler(this.Tabelas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_operacao;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}