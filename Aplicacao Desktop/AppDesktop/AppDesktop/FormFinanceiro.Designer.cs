namespace AppDesktop
{
    partial class FormFinanceiro
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
            this.btn_contas_pagar = new System.Windows.Forms.Button();
            this.btn_contas_receber = new System.Windows.Forms.Button();
            this.btn_lancamentos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_contas_pagar
            // 
            this.btn_contas_pagar.Location = new System.Drawing.Point(17, 30);
            this.btn_contas_pagar.Name = "btn_contas_pagar";
            this.btn_contas_pagar.Size = new System.Drawing.Size(110, 23);
            this.btn_contas_pagar.TabIndex = 2;
            this.btn_contas_pagar.Text = "Contas a pagar";
            this.btn_contas_pagar.UseVisualStyleBackColor = true;
            this.btn_contas_pagar.Click += new System.EventHandler(this.btn_contas_pagar_Click);
            // 
            // btn_contas_receber
            // 
            this.btn_contas_receber.Location = new System.Drawing.Point(17, 59);
            this.btn_contas_receber.Name = "btn_contas_receber";
            this.btn_contas_receber.Size = new System.Drawing.Size(110, 23);
            this.btn_contas_receber.TabIndex = 3;
            this.btn_contas_receber.Text = "Contas a receber";
            this.btn_contas_receber.UseVisualStyleBackColor = true;
            this.btn_contas_receber.Click += new System.EventHandler(this.btn_contas_receber_Click);
            // 
            // btn_lancamentos
            // 
            this.btn_lancamentos.Location = new System.Drawing.Point(17, 88);
            this.btn_lancamentos.Name = "btn_lancamentos";
            this.btn_lancamentos.Size = new System.Drawing.Size(110, 39);
            this.btn_lancamentos.TabIndex = 4;
            this.btn_lancamentos.Text = "Lançamentos Futuros";
            this.btn_lancamentos.UseVisualStyleBackColor = true;
            this.btn_lancamentos.Click += new System.EventHandler(this.btn_lancamentos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.btn_contas_pagar);
            this.groupBox1.Controls.Add(this.btn_contas_receber);
            this.groupBox1.Controls.Add(this.btn_lancamentos);
            this.groupBox1.Location = new System.Drawing.Point(23, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 324);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(167, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 448);
            this.panel1.TabIndex = 7;
            // 
            // FormFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1288, 507);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFinanceiro";
            this.Text = "FormFinanceiro";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_contas_pagar;
        private System.Windows.Forms.Button btn_contas_receber;
        private System.Windows.Forms.Button btn_lancamentos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
    }
}