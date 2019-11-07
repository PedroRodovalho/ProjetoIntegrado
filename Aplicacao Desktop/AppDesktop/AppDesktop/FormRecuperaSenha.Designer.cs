namespace AppDesktop
{
    partial class FormRecuperaSenha
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
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_mensagem = new System.Windows.Forms.GroupBox();
            this.groupBox_redefinirSenha = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_concluir = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_confirmar_senha = new System.Windows.Forms.TextBox();
            this.txt_nova_senha = new System.Windows.Forms.TextBox();
            this.txt_senha_atual = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_mensagem.SuspendLayout();
            this.groupBox_redefinirSenha.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(18, 19);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(204, 20);
            this.txt_usuario.TabIndex = 1;
            // 
            // btn_enviar
            // 
            this.btn_enviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_enviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enviar.Location = new System.Drawing.Point(228, 18);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(75, 21);
            this.btn_enviar.TabIndex = 2;
            this.btn_enviar.Text = "ENVIAR";
            this.btn_enviar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_usuario);
            this.groupBox1.Controls.Add(this.btn_enviar);
            this.groupBox1.Location = new System.Drawing.Point(479, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 48);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Esqueceu sua senha ? Não se preocupe, para recupera-la siga os passos abaixo:";
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(15, 16);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(27, 21);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "lbl";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 60);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(738, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Heavy", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Recuperação de Senha";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 292);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Instruções";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(110, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(203, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "que reenviaremos um novinho para você!";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(48, 207);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(59, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Clique aqui";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(396, 26);
            this.label9.TabIndex = 6;
            this.label9.Text = "● Não recebeu o e-mail ? Não tenha pressa, pode ser que sua solicitação demore \r\n" +
    "alguns minutos.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(380, 26);
            this.label8.TabIndex = 6;
            this.label8.Text = "● Você pode alterar sua senha sempre que quiser nas configurações de conta.\r\n\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "● Nunca informe sua senha para ninguém.\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(399, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "● Seu usuário será validado e uma mensagem será enviada para seu endereço de \r\nem" +
    "ail.\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(274, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "3º Insira a senha recebida e então crie uma nova senha.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(317, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "2º Acesse seu endereço de email para visualizar sua nova senha.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "1º Para redefinir sua senha, insira seu nome de usuário ao lado e clique em \"Envi" +
    "ar\".";
            // 
            // groupBox_mensagem
            // 
            this.groupBox_mensagem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_mensagem.AutoSize = true;
            this.groupBox_mensagem.Controls.Add(this.lblInfo);
            this.groupBox_mensagem.Location = new System.Drawing.Point(479, 165);
            this.groupBox_mensagem.Name = "groupBox_mensagem";
            this.groupBox_mensagem.Size = new System.Drawing.Size(303, 63);
            this.groupBox_mensagem.TabIndex = 9;
            this.groupBox_mensagem.TabStop = false;
            this.groupBox_mensagem.Visible = false;
            // 
            // groupBox_redefinirSenha
            // 
            this.groupBox_redefinirSenha.Controls.Add(this.label13);
            this.groupBox_redefinirSenha.Controls.Add(this.btn_concluir);
            this.groupBox_redefinirSenha.Controls.Add(this.label12);
            this.groupBox_redefinirSenha.Controls.Add(this.label11);
            this.groupBox_redefinirSenha.Controls.Add(this.txt_confirmar_senha);
            this.groupBox_redefinirSenha.Controls.Add(this.txt_nova_senha);
            this.groupBox_redefinirSenha.Controls.Add(this.txt_senha_atual);
            this.groupBox_redefinirSenha.Location = new System.Drawing.Point(479, 234);
            this.groupBox_redefinirSenha.Name = "groupBox_redefinirSenha";
            this.groupBox_redefinirSenha.Size = new System.Drawing.Size(303, 148);
            this.groupBox_redefinirSenha.TabIndex = 10;
            this.groupBox_redefinirSenha.TabStop = false;
            this.groupBox_redefinirSenha.Text = "Redefinir senha";
            this.groupBox_redefinirSenha.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Confirmar Senha";
            // 
            // btn_concluir
            // 
            this.btn_concluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_concluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_concluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_concluir.Location = new System.Drawing.Point(12, 108);
            this.btn_concluir.Name = "btn_concluir";
            this.btn_concluir.Size = new System.Drawing.Size(285, 34);
            this.btn_concluir.TabIndex = 2;
            this.btn_concluir.Text = "Concluir";
            this.btn_concluir.UseVisualStyleBackColor = true;
            this.btn_concluir.Click += new System.EventHandler(this.btn_concluir_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Nova Senha";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Senha Atual";
            // 
            // txt_confirmar_senha
            // 
            this.txt_confirmar_senha.Location = new System.Drawing.Point(100, 71);
            this.txt_confirmar_senha.Name = "txt_confirmar_senha";
            this.txt_confirmar_senha.PasswordChar = '*';
            this.txt_confirmar_senha.Size = new System.Drawing.Size(197, 20);
            this.txt_confirmar_senha.TabIndex = 1;
            this.txt_confirmar_senha.UseSystemPasswordChar = true;
            // 
            // txt_nova_senha
            // 
            this.txt_nova_senha.Location = new System.Drawing.Point(100, 45);
            this.txt_nova_senha.Name = "txt_nova_senha";
            this.txt_nova_senha.PasswordChar = '*';
            this.txt_nova_senha.Size = new System.Drawing.Size(197, 20);
            this.txt_nova_senha.TabIndex = 1;
            this.txt_nova_senha.UseSystemPasswordChar = true;
            // 
            // txt_senha_atual
            // 
            this.txt_senha_atual.Location = new System.Drawing.Point(100, 19);
            this.txt_senha_atual.Name = "txt_senha_atual";
            this.txt_senha_atual.PasswordChar = '*';
            this.txt_senha_atual.Size = new System.Drawing.Size(197, 20);
            this.txt_senha_atual.TabIndex = 1;
            this.txt_senha_atual.UseSystemPasswordChar = true;
            // 
            // FormRecuperaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_redefinirSenha);
            this.Controls.Add(this.groupBox_mensagem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRecuperaSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperação de Senha";
            this.Load += new System.EventHandler(this.FormRecuperaSenha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_mensagem.ResumeLayout(false);
            this.groupBox_mensagem.PerformLayout();
            this.groupBox_redefinirSenha.ResumeLayout(false);
            this.groupBox_redefinirSenha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblInfo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox_mensagem;
        private System.Windows.Forms.GroupBox groupBox_redefinirSenha;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_concluir;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_confirmar_senha;
        private System.Windows.Forms.TextBox txt_nova_senha;
        private System.Windows.Forms.TextBox txt_senha_atual;
    }
}