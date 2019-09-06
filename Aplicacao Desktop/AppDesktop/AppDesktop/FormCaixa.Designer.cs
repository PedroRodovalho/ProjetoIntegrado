namespace AppDesktop
{
    partial class FormCaixa
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
            this.dataGrid_itens = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.combo_parcelas = new System.Windows.Forms.ComboBox();
            this.radio_credito = new System.Windows.Forms.RadioButton();
            this.radio_debito = new System.Windows.Forms.RadioButton();
            this.radio_dinheiro = new System.Windows.Forms.RadioButton();
            this.group_pagamento = new System.Windows.Forms.GroupBox();
            this.txt_tel = new System.Windows.Forms.MaskedTextBox();
            this.txt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_nome_cliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_produto = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_mensagens = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_vendedor = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_relogio = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_itens)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.group_pagamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid_itens
            // 
            this.dataGrid_itens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_itens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_itens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_itens.Location = new System.Drawing.Point(447, 128);
            this.dataGrid_itens.Name = "dataGrid_itens";
            this.dataGrid_itens.Size = new System.Drawing.Size(861, 373);
            this.dataGrid_itens.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.combo_parcelas);
            this.panel1.Controls.Add(this.radio_credito);
            this.panel1.Controls.Add(this.radio_debito);
            this.panel1.Controls.Add(this.radio_dinheiro);
            this.panel1.Controls.Add(this.group_pagamento);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(21, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 413);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(15, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 126);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações da Compra";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(358, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "0,00";
            this.label13.Click += new System.EventHandler(this.label1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(373, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "0";
            this.label12.Click += new System.EventHandler(this.label1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(373, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "0";
            this.label15.Click += new System.EventHandler(this.label1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Total de Itens";
            this.label11.Click += new System.EventHandler(this.label1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Valor Total:";
            this.label14.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Desconto:";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // combo_parcelas
            // 
            this.combo_parcelas.FormattingEnabled = true;
            this.combo_parcelas.Location = new System.Drawing.Point(264, 182);
            this.combo_parcelas.Name = "combo_parcelas";
            this.combo_parcelas.Size = new System.Drawing.Size(49, 21);
            this.combo_parcelas.TabIndex = 6;
            this.combo_parcelas.Visible = false;
            // 
            // radio_credito
            // 
            this.radio_credito.AutoSize = true;
            this.radio_credito.Location = new System.Drawing.Point(185, 183);
            this.radio_credito.Name = "radio_credito";
            this.radio_credito.Size = new System.Drawing.Size(58, 17);
            this.radio_credito.TabIndex = 5;
            this.radio_credito.TabStop = true;
            this.radio_credito.Text = "Crédito";
            this.radio_credito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radio_credito.UseVisualStyleBackColor = true;
            // 
            // radio_debito
            // 
            this.radio_debito.AutoSize = true;
            this.radio_debito.Location = new System.Drawing.Point(105, 183);
            this.radio_debito.Name = "radio_debito";
            this.radio_debito.Size = new System.Drawing.Size(56, 17);
            this.radio_debito.TabIndex = 5;
            this.radio_debito.TabStop = true;
            this.radio_debito.Text = "Debito";
            this.radio_debito.UseVisualStyleBackColor = true;
            // 
            // radio_dinheiro
            // 
            this.radio_dinheiro.AutoSize = true;
            this.radio_dinheiro.Location = new System.Drawing.Point(24, 183);
            this.radio_dinheiro.Name = "radio_dinheiro";
            this.radio_dinheiro.Size = new System.Drawing.Size(64, 17);
            this.radio_dinheiro.TabIndex = 5;
            this.radio_dinheiro.TabStop = true;
            this.radio_dinheiro.Text = "Dinheiro";
            this.radio_dinheiro.UseVisualStyleBackColor = true;
            // 
            // group_pagamento
            // 
            this.group_pagamento.Controls.Add(this.txt_tel);
            this.group_pagamento.Controls.Add(this.txt_cpf);
            this.group_pagamento.Controls.Add(this.button7);
            this.group_pagamento.Controls.Add(this.label10);
            this.group_pagamento.Controls.Add(this.txt_nome_cliente);
            this.group_pagamento.Controls.Add(this.label8);
            this.group_pagamento.Controls.Add(this.label7);
            this.group_pagamento.Controls.Add(this.label1);
            this.group_pagamento.Controls.Add(this.pictureBox1);
            this.group_pagamento.Location = new System.Drawing.Point(15, 22);
            this.group_pagamento.Name = "group_pagamento";
            this.group_pagamento.Size = new System.Drawing.Size(392, 154);
            this.group_pagamento.TabIndex = 4;
            this.group_pagamento.TabStop = false;
            this.group_pagamento.Text = "Informações do Cliente";
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(57, 73);
            this.txt_tel.Mask = "(99) 9 0000-0000";
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(155, 20);
            this.txt_tel.TabIndex = 9;
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(57, 47);
            this.txt_cpf.Mask = "000.000.000-00";
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(155, 20);
            this.txt_cpf.TabIndex = 8;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 99);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(206, 49);
            this.button7.TabIndex = 7;
            this.button7.Text = "Cadastrar";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(262, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Sem imagem";
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_nome_cliente
            // 
            this.txt_nome_cliente.Location = new System.Drawing.Point(56, 21);
            this.txt_nome_cliente.Name = "txt_nome_cliente";
            this.txt_nome_cliente.Size = new System.Drawing.Size(321, 20);
            this.txt_nome_cliente.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tel";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "CPF";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(218, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 101);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 39);
            this.label5.TabIndex = 0;
            this.label5.Text = "Valor Final";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 41);
            this.label4.TabIndex = 0;
            this.label4.Text = "0,00";
            // 
            // txt_produto
            // 
            this.txt_produto.Location = new System.Drawing.Point(310, 102);
            this.txt_produto.Name = "txt_produto";
            this.txt_produto.Size = new System.Drawing.Size(336, 20);
            this.txt_produto.TabIndex = 4;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_codigo.Location = new System.Drawing.Point(105, 102);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(115, 20);
            this.txt_codigo.TabIndex = 4;
            this.txt_codigo.TextChanged += new System.EventHandler(this.txt_codigo_TextChanged);
            this.txt_codigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_codigo_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(652, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 20);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 20);
            this.button2.TabIndex = 5;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_mensagens
            // 
            this.lbl_mensagens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_mensagens.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_mensagens.Location = new System.Drawing.Point(447, 504);
            this.lbl_mensagens.Name = "lbl_mensagens";
            this.lbl_mensagens.Size = new System.Drawing.Size(622, 37);
            this.lbl_mensagens.TabIndex = 6;
            this.lbl_mensagens.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1181, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 32);
            this.button4.TabIndex = 7;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1181, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 32);
            this.button3.TabIndex = 7;
            this.button3.Text = "Limpar Campos";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1075, 504);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(233, 37);
            this.button5.TabIndex = 7;
            this.button5.Text = "Finalizar Venda";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1181, 86);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(127, 32);
            this.button6.TabIndex = 7;
            this.button6.Text = "Orçamento";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(962, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vendedor:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_vendedor
            // 
            this.lbl_vendedor.AutoSize = true;
            this.lbl_vendedor.Location = new System.Drawing.Point(1024, 9);
            this.lbl_vendedor.Name = "lbl_vendedor";
            this.lbl_vendedor.Size = new System.Drawing.Size(53, 13);
            this.lbl_vendedor.TabIndex = 3;
            this.lbl_vendedor.Text = "Vendedor";
            this.lbl_vendedor.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(265, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Produto";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_relogio);
            this.groupBox2.Location = new System.Drawing.Point(77, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 94);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // lbl_relogio
            // 
            this.lbl_relogio.AutoSize = true;
            this.lbl_relogio.Font = new System.Drawing.Font("Haettenschweiler", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_relogio.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_relogio.Location = new System.Drawing.Point(69, 25);
            this.lbl_relogio.Name = "lbl_relogio";
            this.lbl_relogio.Size = new System.Drawing.Size(357, 50);
            this.lbl_relogio.TabIndex = 0;
            this.lbl_relogio.Text = "dd/MM/aaaa HH:mm:ss\r\n";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1320, 585);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lbl_mensagens);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.txt_produto);
            this.Controls.Add(this.lbl_vendedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGrid_itens);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCaixa";
            this.Text = "FormCaixa";
            this.Load += new System.EventHandler(this.FormCaixa_Load);
            this.SizeChanged += new System.EventHandler(this.FormCaixa_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_itens)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.group_pagamento.ResumeLayout(false);
            this.group_pagamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_itens;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_produto;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_mensagens;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_vendedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox group_pagamento;
        private System.Windows.Forms.RadioButton radio_credito;
        private System.Windows.Forms.RadioButton radio_debito;
        private System.Windows.Forms.RadioButton radio_dinheiro;
        private System.Windows.Forms.ComboBox combo_parcelas;
        private System.Windows.Forms.TextBox txt_nome_cliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox txt_tel;
        private System.Windows.Forms.MaskedTextBox txt_cpf;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_relogio;
        private System.Windows.Forms.Timer timer1;
    }
}