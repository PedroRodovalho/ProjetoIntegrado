namespace AppDesktop
{
    partial class FormConsulta_Cliente
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_tipo_cliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cpf_cnpj = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_data_nascimento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_data_cadastro = new System.Windows.Forms.TextBox();
            this.groupBox_cliente = new System.Windows.Forms.GroupBox();
            this.lbl_cadastro_ativo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_inativar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_compras_realizadas = new System.Windows.Forms.Label();
            this.pictureBox_foto = new System.Windows.Forms.PictureBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.groupBox_cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(51, 21);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(46, 20);
            this.txt_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "CLIENTE";
            // 
            // txt_cliente
            // 
            this.txt_cliente.Location = new System.Drawing.Point(84, 47);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(344, 20);
            this.txt_cliente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "TIPO CLIENTE";
            // 
            // comboBox_tipo_cliente
            // 
            this.comboBox_tipo_cliente.FormattingEnabled = true;
            this.comboBox_tipo_cliente.Items.AddRange(new object[] {
            "Pessoa Fisica",
            "Pessoa Juridica"});
            this.comboBox_tipo_cliente.Location = new System.Drawing.Point(530, 47);
            this.comboBox_tipo_cliente.Name = "comboBox_tipo_cliente";
            this.comboBox_tipo_cliente.Size = new System.Drawing.Size(121, 21);
            this.comboBox_tipo_cliente.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "TELEFONE";
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(95, 73);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(113, 20);
            this.txt_telefone.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "CPF/CNPJ";
            // 
            // txt_cpf_cnpj
            // 
            this.txt_cpf_cnpj.Location = new System.Drawing.Point(285, 73);
            this.txt_cpf_cnpj.Name = "txt_cpf_cnpj";
            this.txt_cpf_cnpj.Size = new System.Drawing.Size(153, 20);
            this.txt_cpf_cnpj.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "DATA NASCIMENTO";
            // 
            // txt_data_nascimento
            // 
            this.txt_data_nascimento.Location = new System.Drawing.Point(586, 73);
            this.txt_data_nascimento.Name = "txt_data_nascimento";
            this.txt_data_nascimento.Size = new System.Drawing.Size(113, 20);
            this.txt_data_nascimento.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "DATA CADASTRO";
            // 
            // txt_data_cadastro
            // 
            this.txt_data_cadastro.Location = new System.Drawing.Point(207, 21);
            this.txt_data_cadastro.Name = "txt_data_cadastro";
            this.txt_data_cadastro.Size = new System.Drawing.Size(113, 20);
            this.txt_data_cadastro.TabIndex = 2;
            // 
            // groupBox_cliente
            // 
            this.groupBox_cliente.Controls.Add(this.comboBox_tipo_cliente);
            this.groupBox_cliente.Controls.Add(this.label1);
            this.groupBox_cliente.Controls.Add(this.txt_cpf_cnpj);
            this.groupBox_cliente.Controls.Add(this.txt_id);
            this.groupBox_cliente.Controls.Add(this.txt_data_cadastro);
            this.groupBox_cliente.Controls.Add(this.label2);
            this.groupBox_cliente.Controls.Add(this.txt_data_nascimento);
            this.groupBox_cliente.Controls.Add(this.label3);
            this.groupBox_cliente.Controls.Add(this.txt_telefone);
            this.groupBox_cliente.Controls.Add(this.label4);
            this.groupBox_cliente.Controls.Add(this.label5);
            this.groupBox_cliente.Controls.Add(this.txt_cliente);
            this.groupBox_cliente.Controls.Add(this.lbl_cadastro_ativo);
            this.groupBox_cliente.Controls.Add(this.label9);
            this.groupBox_cliente.Controls.Add(this.label7);
            this.groupBox_cliente.Controls.Add(this.label6);
            this.groupBox_cliente.Enabled = false;
            this.groupBox_cliente.Location = new System.Drawing.Point(24, 18);
            this.groupBox_cliente.Name = "groupBox_cliente";
            this.groupBox_cliente.Size = new System.Drawing.Size(739, 105);
            this.groupBox_cliente.TabIndex = 3;
            this.groupBox_cliente.TabStop = false;
            this.groupBox_cliente.Text = "Informações do Cliente";
            // 
            // lbl_cadastro_ativo
            // 
            this.lbl_cadastro_ativo.AutoSize = true;
            this.lbl_cadastro_ativo.Location = new System.Drawing.Point(470, 25);
            this.lbl_cadastro_ativo.Name = "lbl_cadastro_ativo";
            this.lbl_cadastro_ativo.Size = new System.Drawing.Size(26, 13);
            this.lbl_cadastro_ativo.TabIndex = 0;
            this.lbl_cadastro_ativo.Text = "SIM";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(427, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Status";
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(610, 140);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 8;
            this.btn_excluir.Text = "EXCLUIR";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(688, 140);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 7;
            this.btn_editar.Text = "EDITAR";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_inativar
            // 
            this.btn_inativar.Location = new System.Drawing.Point(531, 140);
            this.btn_inativar.Name = "btn_inativar";
            this.btn_inativar.Size = new System.Drawing.Size(75, 23);
            this.btn_inativar.TabIndex = 9;
            this.btn_inativar.Text = "INATIVAR";
            this.btn_inativar.UseVisualStyleBackColor = true;
            this.btn_inativar.Click += new System.EventHandler(this.btn_inativar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(998, 260);
            this.dataGridView1.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "COMPRAS REALIZADAS:";
            // 
            // lbl_compras_realizadas
            // 
            this.lbl_compras_realizadas.AutoSize = true;
            this.lbl_compras_realizadas.Location = new System.Drawing.Point(170, 151);
            this.lbl_compras_realizadas.Name = "lbl_compras_realizadas";
            this.lbl_compras_realizadas.Size = new System.Drawing.Size(13, 13);
            this.lbl_compras_realizadas.TabIndex = 0;
            this.lbl_compras_realizadas.Text = "0";
            // 
            // pictureBox_foto
            // 
            this.pictureBox_foto.Location = new System.Drawing.Point(784, 12);
            this.pictureBox_foto.Name = "pictureBox_foto";
            this.pictureBox_foto.Size = new System.Drawing.Size(238, 152);
            this.pictureBox_foto.TabIndex = 6;
            this.pictureBox_foto.TabStop = false;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Enabled = false;
            this.btn_salvar.Location = new System.Drawing.Point(416, 140);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(109, 23);
            this.btn_salvar.TabIndex = 10;
            this.btn_salvar.Text = "Salvar Alterações";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // FormConsulta_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1034, 450);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.pictureBox_foto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_inativar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.groupBox_cliente);
            this.Controls.Add(this.lbl_compras_realizadas);
            this.Controls.Add(this.label8);
            this.Name = "FormConsulta_Cliente";
            this.Text = "Consulta de clientes";
            this.Load += new System.EventHandler(this.FormConsulta_Cliente_Load);
            this.groupBox_cliente.ResumeLayout(false);
            this.groupBox_cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_tipo_cliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_cpf_cnpj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_data_nascimento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_data_cadastro;
        private System.Windows.Forms.GroupBox groupBox_cliente;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_inativar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_compras_realizadas;
        private System.Windows.Forms.Label lbl_cadastro_ativo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox_foto;
        private System.Windows.Forms.Button btn_salvar;
    }
}