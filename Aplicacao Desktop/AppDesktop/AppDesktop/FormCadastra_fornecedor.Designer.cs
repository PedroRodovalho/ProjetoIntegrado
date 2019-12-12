namespace AppDesktop
{
    partial class FormCadastra_fornecedor
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
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.txt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.check_cadastra_favorecido = new System.Windows.Forms.CheckBox();
            this.group_favorecido = new System.Windows.Forms.GroupBox();
            this.combo_classificacao = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.combo_banco = new System.Windows.Forms.ComboBox();
            this.btn_cadastrar_banco = new System.Windows.Forms.Button();
            this.lbl_id_banco = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_conta = new System.Windows.Forms.TextBox();
            this.txt_agencia = new System.Windows.Forms.TextBox();
            this.txt_outro_banco = new System.Windows.Forms.TextBox();
            this.txt_cpf_cnpj = new System.Windows.Forms.TextBox();
            this.txt_nome_f = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.group_favorecido.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(627, 106);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(91, 23);
            this.btn_cadastrar.TabIndex = 0;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(56, 19);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(412, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefone";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(56, 45);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(201, 20);
            this.txt_email.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "CNPJ";
            // 
            // txt_cnpj
            // 
            this.txt_cnpj.Location = new System.Drawing.Point(528, 19);
            this.txt_cnpj.Mask = "00.000.000/0000-00";
            this.txt_cnpj.Name = "txt_cnpj";
            this.txt_cnpj.PromptChar = ' ';
            this.txt_cnpj.Size = new System.Drawing.Size(161, 20);
            this.txt_cnpj.TabIndex = 3;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(336, 45);
            this.txt_telefone.Mask = "(99) 9 0000-0000";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.PromptChar = ' ';
            this.txt_telefone.Size = new System.Drawing.Size(132, 20);
            this.txt_telefone.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_nome);
            this.groupBox1.Controls.Add(this.txt_telefone);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.txt_cnpj);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 88);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados fornecedor";
            // 
            // check_cadastra_favorecido
            // 
            this.check_cadastra_favorecido.AutoSize = true;
            this.check_cadastra_favorecido.Location = new System.Drawing.Point(30, 106);
            this.check_cadastra_favorecido.Name = "check_cadastra_favorecido";
            this.check_cadastra_favorecido.Size = new System.Drawing.Size(220, 17);
            this.check_cadastra_favorecido.TabIndex = 6;
            this.check_cadastra_favorecido.Text = "Incluir fornecedor na lista de favorecidos.";
            this.check_cadastra_favorecido.UseVisualStyleBackColor = true;
            this.check_cadastra_favorecido.CheckedChanged += new System.EventHandler(this.check_cadastra_favorecido_CheckedChanged);
            // 
            // group_favorecido
            // 
            this.group_favorecido.Controls.Add(this.combo_classificacao);
            this.group_favorecido.Controls.Add(this.groupBox3);
            this.group_favorecido.Controls.Add(this.txt_cpf_cnpj);
            this.group_favorecido.Controls.Add(this.txt_nome_f);
            this.group_favorecido.Controls.Add(this.label5);
            this.group_favorecido.Controls.Add(this.label7);
            this.group_favorecido.Controls.Add(this.label8);
            this.group_favorecido.Location = new System.Drawing.Point(12, 144);
            this.group_favorecido.Name = "group_favorecido";
            this.group_favorecido.Size = new System.Drawing.Size(706, 176);
            this.group_favorecido.TabIndex = 7;
            this.group_favorecido.TabStop = false;
            this.group_favorecido.Text = "Dados";
            this.group_favorecido.Visible = false;
            // 
            // combo_classificacao
            // 
            this.combo_classificacao.FormattingEnabled = true;
            this.combo_classificacao.Items.AddRange(new object[] {
            "CLIENTE",
            "FORNECEDOR",
            "FUNCIONARIO",
            "OUTROS"});
            this.combo_classificacao.Location = new System.Drawing.Point(525, 99);
            this.combo_classificacao.Name = "combo_classificacao";
            this.combo_classificacao.Size = new System.Drawing.Size(121, 21);
            this.combo_classificacao.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.combo_banco);
            this.groupBox3.Controls.Add(this.btn_cadastrar_banco);
            this.groupBox3.Controls.Add(this.lbl_id_banco);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txt_conta);
            this.groupBox3.Controls.Add(this.txt_agencia);
            this.groupBox3.Controls.Add(this.txt_outro_banco);
            this.groupBox3.Location = new System.Drawing.Point(34, 55);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(379, 115);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados Bancários";
            // 
            // combo_banco
            // 
            this.combo_banco.FormattingEnabled = true;
            this.combo_banco.Location = new System.Drawing.Point(73, 18);
            this.combo_banco.Name = "combo_banco";
            this.combo_banco.Size = new System.Drawing.Size(121, 21);
            this.combo_banco.TabIndex = 16;
            this.combo_banco.SelectedIndexChanged += new System.EventHandler(this.combo_banco_SelectedIndexChanged);
            // 
            // btn_cadastrar_banco
            // 
            this.btn_cadastrar_banco.Location = new System.Drawing.Point(6, 77);
            this.btn_cadastrar_banco.Name = "btn_cadastrar_banco";
            this.btn_cadastrar_banco.Size = new System.Drawing.Size(367, 32);
            this.btn_cadastrar_banco.TabIndex = 15;
            this.btn_cadastrar_banco.Text = "CADASTRAR BANCO";
            this.btn_cadastrar_banco.UseVisualStyleBackColor = true;
            // 
            // lbl_id_banco
            // 
            this.lbl_id_banco.AutoSize = true;
            this.lbl_id_banco.Location = new System.Drawing.Point(312, 48);
            this.lbl_id_banco.Name = "lbl_id_banco";
            this.lbl_id_banco.Size = new System.Drawing.Size(38, 13);
            this.lbl_id_banco.TabIndex = 5;
            this.lbl_id_banco.Text = "Banco";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Banco";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(164, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Agência/Conta";
            // 
            // txt_conta
            // 
            this.txt_conta.Location = new System.Drawing.Point(180, 45);
            this.txt_conta.Name = "txt_conta";
            this.txt_conta.Size = new System.Drawing.Size(105, 20);
            this.txt_conta.TabIndex = 9;
            // 
            // txt_agencia
            // 
            this.txt_agencia.Location = new System.Drawing.Point(108, 45);
            this.txt_agencia.Name = "txt_agencia";
            this.txt_agencia.Size = new System.Drawing.Size(50, 20);
            this.txt_agencia.TabIndex = 8;
            // 
            // txt_outro_banco
            // 
            this.txt_outro_banco.Enabled = false;
            this.txt_outro_banco.Location = new System.Drawing.Point(200, 19);
            this.txt_outro_banco.Name = "txt_outro_banco";
            this.txt_outro_banco.Size = new System.Drawing.Size(141, 20);
            this.txt_outro_banco.TabIndex = 5;
            // 
            // txt_cpf_cnpj
            // 
            this.txt_cpf_cnpj.Location = new System.Drawing.Point(501, 19);
            this.txt_cpf_cnpj.Name = "txt_cpf_cnpj";
            this.txt_cpf_cnpj.ReadOnly = true;
            this.txt_cpf_cnpj.Size = new System.Drawing.Size(145, 20);
            this.txt_cpf_cnpj.TabIndex = 1;
            // 
            // txt_nome_f
            // 
            this.txt_nome_f.Location = new System.Drawing.Point(57, 19);
            this.txt_nome_f.Name = "txt_nome_f";
            this.txt_nome_f.ReadOnly = true;
            this.txt_nome_f.Size = new System.Drawing.Size(356, 20);
            this.txt_nome_f.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(450, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Classificação";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(436, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "CPF/CNPJ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nome";
            // 
            // FormCadastra_fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(745, 387);
            this.Controls.Add(this.group_favorecido);
            this.Controls.Add(this.check_cadastra_favorecido);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cadastrar);
            this.Name = "FormCadastra_fornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de fornecedor";
            this.Load += new System.EventHandler(this.FormCadastra_fornecedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.group_favorecido.ResumeLayout(false);
            this.group_favorecido.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txt_cnpj;
        private System.Windows.Forms.MaskedTextBox txt_telefone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox check_cadastra_favorecido;
        private System.Windows.Forms.GroupBox group_favorecido;
        private System.Windows.Forms.ComboBox combo_classificacao;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox combo_banco;
        private System.Windows.Forms.Button btn_cadastrar_banco;
        private System.Windows.Forms.Label lbl_id_banco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_conta;
        private System.Windows.Forms.TextBox txt_agencia;
        private System.Windows.Forms.TextBox txt_outro_banco;
        private System.Windows.Forms.TextBox txt_cpf_cnpj;
        private System.Windows.Forms.TextBox txt_nome_f;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}