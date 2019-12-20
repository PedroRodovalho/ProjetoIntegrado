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
            this.lbl_desconto_liquido = new System.Windows.Forms.Label();
            this.lbl_desconto = new System.Windows.Forms.Label();
            this.lbl_valor_total = new System.Windows.Forms.Label();
            this.lbl_total_itens = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.group_pagamento = new System.Windows.Forms.GroupBox();
            this.txt_tel = new System.Windows.Forms.MaskedTextBox();
            this.txt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_nome_cliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_valor_final = new System.Windows.Forms.Label();
            this.txt_produto = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_mensagens = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_vendedor = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_relogio = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_quantidade = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.btn_ok_quantidade = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_itens)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.group_pagamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel_quantidade.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.panel1.Controls.Add(this.group_pagamento);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbl_valor_final);
            this.panel1.Location = new System.Drawing.Point(21, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 413);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_desconto_liquido);
            this.groupBox1.Controls.Add(this.lbl_desconto);
            this.groupBox1.Controls.Add(this.lbl_valor_total);
            this.groupBox1.Controls.Add(this.lbl_total_itens);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(15, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 126);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações da Compra";
            // 
            // lbl_desconto_liquido
            // 
            this.lbl_desconto_liquido.AutoSize = true;
            this.lbl_desconto_liquido.Location = new System.Drawing.Point(344, 84);
            this.lbl_desconto_liquido.Name = "lbl_desconto_liquido";
            this.lbl_desconto_liquido.Size = new System.Drawing.Size(28, 13);
            this.lbl_desconto_liquido.TabIndex = 3;
            this.lbl_desconto_liquido.Text = "0,00";
            // 
            // lbl_desconto
            // 
            this.lbl_desconto.AutoSize = true;
            this.lbl_desconto.Location = new System.Drawing.Point(344, 62);
            this.lbl_desconto.Name = "lbl_desconto";
            this.lbl_desconto.Size = new System.Drawing.Size(28, 13);
            this.lbl_desconto.TabIndex = 3;
            this.lbl_desconto.Text = "0,00";
            // 
            // lbl_valor_total
            // 
            this.lbl_valor_total.AutoSize = true;
            this.lbl_valor_total.Location = new System.Drawing.Point(359, 43);
            this.lbl_valor_total.Name = "lbl_valor_total";
            this.lbl_valor_total.Size = new System.Drawing.Size(13, 13);
            this.lbl_valor_total.TabIndex = 3;
            this.lbl_valor_total.Text = "0";
            this.lbl_valor_total.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_total_itens
            // 
            this.lbl_total_itens.AutoSize = true;
            this.lbl_total_itens.Location = new System.Drawing.Point(359, 25);
            this.lbl_total_itens.Name = "lbl_total_itens";
            this.lbl_total_itens.Size = new System.Drawing.Size(13, 13);
            this.lbl_total_itens.TabIndex = 3;
            this.lbl_total_itens.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Total de Itens";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Valor Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Desconto Liquido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Desconto:";
            // 
            // group_pagamento
            // 
            this.group_pagamento.Controls.Add(this.txt_tel);
            this.group_pagamento.Controls.Add(this.txt_cpf);
            this.group_pagamento.Controls.Add(this.btn_cadastrar);
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
            this.txt_cpf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_cpf_KeyDown);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(6, 99);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(206, 49);
            this.btn_cadastrar.TabIndex = 7;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(262, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Sem imagem";
            // 
            // txt_nome_cliente
            // 
            this.txt_nome_cliente.Location = new System.Drawing.Point(56, 21);
            this.txt_nome_cliente.Name = "txt_nome_cliente";
            this.txt_nome_cliente.Size = new System.Drawing.Size(321, 20);
            this.txt_nome_cliente.TabIndex = 4;
            this.txt_nome_cliente.TextChanged += new System.EventHandler(this.txt_nome_cliente_TextChanged);
            this.txt_nome_cliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_nome_cliente_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
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
            // lbl_valor_final
            // 
            this.lbl_valor_final.AutoSize = true;
            this.lbl_valor_final.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_valor_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor_final.Location = new System.Drawing.Point(278, 357);
            this.lbl_valor_final.Name = "lbl_valor_final";
            this.lbl_valor_final.Size = new System.Drawing.Size(86, 41);
            this.lbl_valor_final.TabIndex = 0;
            this.lbl_valor_final.Text = "0,00";
            // 
            // txt_produto
            // 
            this.txt_produto.Location = new System.Drawing.Point(62, 53);
            this.txt_produto.Name = "txt_produto";
            this.txt_produto.Size = new System.Drawing.Size(336, 20);
            this.txt_produto.TabIndex = 4;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(62, 27);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(155, 20);
            this.txt_codigo.TabIndex = 4;
            this.txt_codigo.TextChanged += new System.EventHandler(this.txt_codigo_TextChanged);
            this.txt_codigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_codigo_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1204, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 20);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(1075, 504);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(233, 37);
            this.btnFinalizar.TabIndex = 7;
            this.btnFinalizar.Text = "Finalizar Venda";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizarVenda_click);
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
            this.label3.Visible = false;
            // 
            // lbl_vendedor
            // 
            this.lbl_vendedor.AutoSize = true;
            this.lbl_vendedor.Location = new System.Drawing.Point(1024, 9);
            this.lbl_vendedor.Name = "lbl_vendedor";
            this.lbl_vendedor.Size = new System.Drawing.Size(53, 13);
            this.lbl_vendedor.TabIndex = 3;
            this.lbl_vendedor.Text = "Vendedor";
            this.lbl_vendedor.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Produto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_relogio);
            this.groupBox2.Location = new System.Drawing.Point(42, 24);
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
            // panel_quantidade
            // 
            this.panel_quantidade.Controls.Add(this.label16);
            this.panel_quantidade.Controls.Add(this.txt_quantidade);
            this.panel_quantidade.Controls.Add(this.btn_ok_quantidade);
            this.panel_quantidade.Location = new System.Drawing.Point(414, 156);
            this.panel_quantidade.Name = "panel_quantidade";
            this.panel_quantidade.Size = new System.Drawing.Size(282, 100);
            this.panel_quantidade.TabIndex = 9;
            this.panel_quantidade.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(33, 44);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Quantidade";
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Location = new System.Drawing.Point(101, 41);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_quantidade.Size = new System.Drawing.Size(62, 20);
            this.txt_quantidade.TabIndex = 4;
            this.txt_quantidade.Text = "1";
            this.txt_quantidade.TextChanged += new System.EventHandler(this.txt_quantidade_TextChanged);
            this.txt_quantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_quantidade_KeyDown);
            // 
            // btn_ok_quantidade
            // 
            this.btn_ok_quantidade.Location = new System.Drawing.Point(169, 41);
            this.btn_ok_quantidade.Name = "btn_ok_quantidade";
            this.btn_ok_quantidade.Size = new System.Drawing.Size(62, 20);
            this.btn_ok_quantidade.TabIndex = 5;
            this.btn_ok_quantidade.Text = "OK";
            this.btn_ok_quantidade.UseVisualStyleBackColor = true;
            this.btn_ok_quantidade.Click += new System.EventHandler(this.btn_ok_quantidade_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 20);
            this.button2.TabIndex = 5;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.txt_produto);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txt_codigo);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(554, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(523, 81);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Adicionar Item";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(426, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FormCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1320, 585);
            this.Controls.Add(this.panel_quantidade);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lbl_mensagens);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_vendedor);
            this.Controls.Add(this.label3);
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
            this.panel_quantidade.ResumeLayout(false);
            this.panel_quantidade.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_produto;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_mensagens;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_vendedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_valor_final;
        private System.Windows.Forms.GroupBox group_pagamento;
        private System.Windows.Forms.TextBox txt_nome_cliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_desconto;
        private System.Windows.Forms.Label lbl_valor_total;
        private System.Windows.Forms.MaskedTextBox txt_tel;
        private System.Windows.Forms.MaskedTextBox txt_cpf;
        private System.Windows.Forms.Label lbl_total_itens;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_relogio;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel_quantidade;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.Button btn_ok_quantidade;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_desconto_liquido;
        public System.Windows.Forms.DataGridView dataGrid_itens;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
    }
}