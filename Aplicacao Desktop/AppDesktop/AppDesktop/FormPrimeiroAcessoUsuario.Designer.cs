namespace AppDesktop
{
    partial class FormPrimeiroAcessoUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_fechar = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_sobrenome = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox_mensagem = new System.Windows.Forms.GroupBox();
            this.lbl_mensagem = new System.Windows.Forms.Label();
            this.backgroundWorker_EnviaEmail = new System.ComponentModel.BackgroundWorker();
            this.groupBox_Finalizacao = new System.Windows.Forms.GroupBox();
            this.lbl_endereco_email = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_chave = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_concluir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_mensagem.SuspendLayout();
            this.groupBox_Finalizacao.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Haettenschweiler", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "MEU PRIMEIRO LOGIN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.lbl_fechar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 53);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_fechar
            // 
            this.lbl_fechar.AutoSize = true;
            this.lbl_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_fechar.Font = new System.Drawing.Font("Webdings", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lbl_fechar.ForeColor = System.Drawing.Color.White;
            this.lbl_fechar.Location = new System.Drawing.Point(497, 10);
            this.lbl_fechar.Name = "lbl_fechar";
            this.lbl_fechar.Size = new System.Drawing.Size(42, 30);
            this.lbl_fechar.TabIndex = 0;
            this.lbl_fechar.Text = "r";
            this.lbl_fechar.Click += new System.EventHandler(this.lbl_fechar_Click);
            this.lbl_fechar.MouseEnter += new System.EventHandler(this.lbl_fechar_MouseEnter);
            this.lbl_fechar.MouseLeave += new System.EventHandler(this.lbl_fechar_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_telefone);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.txt_sobrenome);
            this.groupBox1.Controls.Add(this.txt_nome);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(63, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 194);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Perfil de Usuário";
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(77, 149);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(158, 20);
            this.txt_telefone.TabIndex = 4;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(77, 92);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(292, 20);
            this.txt_email.TabIndex = 3;
            // 
            // txt_sobrenome
            // 
            this.txt_sobrenome.Location = new System.Drawing.Point(77, 63);
            this.txt_sobrenome.Name = "txt_sobrenome";
            this.txt_sobrenome.Size = new System.Drawing.Size(158, 20);
            this.txt_sobrenome.TabIndex = 2;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(77, 32);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(158, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "(Seu email poderá ser usado para recuperar sua senha.)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sobrenome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(284, 299);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(205, 36);
            this.btn_enviar.TabIndex = 5;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(63, 299);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(215, 36);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(502, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Para desbloquear o seu acesso, é necessário informar alguns dados seus! Não se pr" +
    "eocupe, é rapidinho.";
            // 
            // groupBox_mensagem
            // 
            this.groupBox_mensagem.Controls.Add(this.lbl_mensagem);
            this.groupBox_mensagem.Location = new System.Drawing.Point(15, 353);
            this.groupBox_mensagem.Name = "groupBox_mensagem";
            this.groupBox_mensagem.Size = new System.Drawing.Size(527, 70);
            this.groupBox_mensagem.TabIndex = 3;
            this.groupBox_mensagem.TabStop = false;
            // 
            // lbl_mensagem
            // 
            this.lbl_mensagem.AutoSize = true;
            this.lbl_mensagem.Location = new System.Drawing.Point(27, 32);
            this.lbl_mensagem.Name = "lbl_mensagem";
            this.lbl_mensagem.Size = new System.Drawing.Size(14, 13);
            this.lbl_mensagem.TabIndex = 0;
            this.lbl_mensagem.Text = "●";
            this.lbl_mensagem.Visible = false;
            // 
            // backgroundWorker_EnviaEmail
            // 
            this.backgroundWorker_EnviaEmail.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_EnviaEmail_DoWork);
            this.backgroundWorker_EnviaEmail.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_EnviaEmail_ProgressChanged);
            this.backgroundWorker_EnviaEmail.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_EnviaEmail_RunWorkerCompleted);
            // 
            // groupBox_Finalizacao
            // 
            this.groupBox_Finalizacao.Controls.Add(this.lbl_endereco_email);
            this.groupBox_Finalizacao.Controls.Add(this.linkLabel2);
            this.groupBox_Finalizacao.Controls.Add(this.groupBox2);
            this.groupBox_Finalizacao.Controls.Add(this.label8);
            this.groupBox_Finalizacao.Controls.Add(this.label12);
            this.groupBox_Finalizacao.Controls.Add(this.label14);
            this.groupBox_Finalizacao.Controls.Add(this.label13);
            this.groupBox_Finalizacao.Controls.Add(this.label11);
            this.groupBox_Finalizacao.Location = new System.Drawing.Point(15, 62);
            this.groupBox_Finalizacao.Name = "groupBox_Finalizacao";
            this.groupBox_Finalizacao.Size = new System.Drawing.Size(527, 288);
            this.groupBox_Finalizacao.TabIndex = 4;
            this.groupBox_Finalizacao.TabStop = false;
            this.groupBox_Finalizacao.Text = "Finalizar Confirmação";
            this.groupBox_Finalizacao.Visible = false;
            // 
            // lbl_endereco_email
            // 
            this.lbl_endereco_email.AutoSize = true;
            this.lbl_endereco_email.Location = new System.Drawing.Point(216, 202);
            this.lbl_endereco_email.Name = "lbl_endereco_email";
            this.lbl_endereco_email.Size = new System.Drawing.Size(158, 13);
            this.lbl_endereco_email.TabIndex = 11;
            this.lbl_endereco_email.Text = "endereçodeemail@email.com.br";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(233, 229);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(130, 13);
            this.linkLabel2.TabIndex = 10;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Alterar endereço de email.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_chave);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.btn_finalizar);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(61, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 86);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // txt_chave
            // 
            this.txt_chave.BackColor = System.Drawing.SystemColors.Window;
            this.txt_chave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_chave.Font = new System.Drawing.Font("Eras Medium ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chave.Location = new System.Drawing.Point(17, 20);
            this.txt_chave.Name = "txt_chave";
            this.txt_chave.Size = new System.Drawing.Size(184, 37);
            this.txt_chave.TabIndex = 7;
            this.txt_chave.Text = "ABCDEFG";
            this.txt_chave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_chave.WordWrap = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(186, 60);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(59, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Clique aqui";
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Location = new System.Drawing.Point(207, 20);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(177, 37);
            this.btn_finalizar.TabIndex = 6;
            this.btn_finalizar.Text = "Enviar";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(245, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "para reenviar.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Não recebeu o email ?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(355, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Para finalizar, insira a chave enviada para o endereço de email informado!";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 229);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(204, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "● O endereço de email não esta correto ?";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 202);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(194, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "● O email foi enviado para o endereço: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(418, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "● O Email com a chave de confirmação pode demorar alguns minutos até ser entregue" +
    ".";
            // 
            // btn_concluir
            // 
            this.btn_concluir.Location = new System.Drawing.Point(449, 414);
            this.btn_concluir.Name = "btn_concluir";
            this.btn_concluir.Size = new System.Drawing.Size(75, 23);
            this.btn_concluir.TabIndex = 1;
            this.btn_concluir.Text = "Concluir";
            this.btn_concluir.UseVisualStyleBackColor = true;
            this.btn_concluir.Visible = false;
            this.btn_concluir.Click += new System.EventHandler(this.btn_concluir_Click);
            // 
            // FormPrimeiroAcessoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 450);
            this.Controls.Add(this.groupBox_Finalizacao);
            this.Controls.Add(this.btn_concluir);
            this.Controls.Add(this.groupBox_mensagem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.btn_cancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrimeiroAcessoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrimeiroAcessoUsuario";
            this.Load += new System.EventHandler(this.FormPrimeiroAcessoUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_mensagem.ResumeLayout(false);
            this.groupBox_mensagem.PerformLayout();
            this.groupBox_Finalizacao.ResumeLayout(false);
            this.groupBox_Finalizacao.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_sobrenome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox_mensagem;
        private System.Windows.Forms.Label lbl_mensagem;
        private System.ComponentModel.BackgroundWorker backgroundWorker_EnviaEmail;
        private System.Windows.Forms.GroupBox groupBox_Finalizacao;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txt_chave;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_fechar;
        private System.Windows.Forms.Label lbl_endereco_email;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_concluir;
    }
}