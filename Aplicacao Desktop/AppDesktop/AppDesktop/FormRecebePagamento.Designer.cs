namespace AppDesktop
{
    partial class FormRecebePagamento
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
            this.radioDinheiro = new System.Windows.Forms.RadioButton();
            this.radioDebito = new System.Windows.Forms.RadioButton();
            this.radioCredito = new System.Windows.Forms.RadioButton();
            this.groupBox_formaPagamento = new System.Windows.Forms.GroupBox();
            this.combo_parcelas = new System.Windows.Forms.ComboBox();
            this.txt_valor_pago = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_tipo_desconto = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_valor_parcelas = new System.Windows.Forms.Label();
            this.lbl_valor_restante = new System.Windows.Forms.Label();
            this.lbl_troco = new System.Windows.Forms.Label();
            this.lbl_valor_pago = new System.Windows.Forms.Label();
            this.lbl_desconto = new System.Windows.Forms.Label();
            this.lbl_valor_final = new System.Windows.Forms.Label();
            this.lbl_valor_total = new System.Windows.Forms.Label();
            this.lbl_info_pagamento = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_concluir = new System.Windows.Forms.Button();
            this.btn_adiciona_pagamento = new System.Windows.Forms.Button();
            this.dataGrid_pagamentos = new System.Windows.Forms.DataGridView();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.groupBox_formaPagamento.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_pagamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // radioDinheiro
            // 
            this.radioDinheiro.AutoSize = true;
            this.radioDinheiro.Checked = true;
            this.radioDinheiro.Location = new System.Drawing.Point(6, 22);
            this.radioDinheiro.Name = "radioDinheiro";
            this.radioDinheiro.Size = new System.Drawing.Size(78, 17);
            this.radioDinheiro.TabIndex = 0;
            this.radioDinheiro.TabStop = true;
            this.radioDinheiro.Text = "DINHEIRO";
            this.radioDinheiro.UseVisualStyleBackColor = true;
            this.radioDinheiro.CheckedChanged += new System.EventHandler(this.radioDinheiro_CheckedChanged);
            // 
            // radioDebito
            // 
            this.radioDebito.AutoSize = true;
            this.radioDebito.Location = new System.Drawing.Point(6, 45);
            this.radioDebito.Name = "radioDebito";
            this.radioDebito.Size = new System.Drawing.Size(65, 17);
            this.radioDebito.TabIndex = 0;
            this.radioDebito.TabStop = true;
            this.radioDebito.Text = "DEBITO";
            this.radioDebito.UseVisualStyleBackColor = true;
            // 
            // radioCredito
            // 
            this.radioCredito.AutoSize = true;
            this.radioCredito.Location = new System.Drawing.Point(6, 68);
            this.radioCredito.Name = "radioCredito";
            this.radioCredito.Size = new System.Drawing.Size(73, 17);
            this.radioCredito.TabIndex = 0;
            this.radioCredito.TabStop = true;
            this.radioCredito.Text = "CREDITO";
            this.radioCredito.UseVisualStyleBackColor = true;
            // 
            // groupBox_formaPagamento
            // 
            this.groupBox_formaPagamento.Controls.Add(this.radioDinheiro);
            this.groupBox_formaPagamento.Controls.Add(this.radioCredito);
            this.groupBox_formaPagamento.Controls.Add(this.radioDebito);
            this.groupBox_formaPagamento.Controls.Add(this.combo_parcelas);
            this.groupBox_formaPagamento.Location = new System.Drawing.Point(12, 12);
            this.groupBox_formaPagamento.Name = "groupBox_formaPagamento";
            this.groupBox_formaPagamento.Size = new System.Drawing.Size(94, 140);
            this.groupBox_formaPagamento.TabIndex = 1;
            this.groupBox_formaPagamento.TabStop = false;
            this.groupBox_formaPagamento.Text = "Pagamento";
            this.groupBox_formaPagamento.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // combo_parcelas
            // 
            this.combo_parcelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_parcelas.Enabled = false;
            this.combo_parcelas.FormattingEnabled = true;
            this.combo_parcelas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.combo_parcelas.Location = new System.Drawing.Point(6, 91);
            this.combo_parcelas.Name = "combo_parcelas";
            this.combo_parcelas.Size = new System.Drawing.Size(82, 21);
            this.combo_parcelas.TabIndex = 4;
            // 
            // txt_valor_pago
            // 
            this.txt_valor_pago.Location = new System.Drawing.Point(187, 14);
            this.txt_valor_pago.Name = "txt_valor_pago";
            this.txt_valor_pago.Size = new System.Drawing.Size(100, 20);
            this.txt_valor_pago.TabIndex = 2;
            this.txt_valor_pago.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_valor_pago_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor Pago";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DESCONTO:";
            // 
            // lbl_tipo_desconto
            // 
            this.lbl_tipo_desconto.AutoSize = true;
            this.lbl_tipo_desconto.Location = new System.Drawing.Point(447, 19);
            this.lbl_tipo_desconto.Name = "lbl_tipo_desconto";
            this.lbl_tipo_desconto.Size = new System.Drawing.Size(81, 13);
            this.lbl_tipo_desconto.TabIndex = 3;
            this.lbl_tipo_desconto.Text = "DESCONTO: H";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lbl_valor_parcelas);
            this.groupBox2.Controls.Add(this.lbl_valor_restante);
            this.groupBox2.Controls.Add(this.lbl_troco);
            this.groupBox2.Controls.Add(this.lbl_valor_pago);
            this.groupBox2.Controls.Add(this.lbl_desconto);
            this.groupBox2.Controls.Add(this.lbl_valor_final);
            this.groupBox2.Controls.Add(this.lbl_valor_total);
            this.groupBox2.Controls.Add(this.lbl_info_pagamento);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(125, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 111);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações de Pagamento";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Troco:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Valor Pago:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Desconto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Valor Restante:";
            // 
            // lbl_valor_parcelas
            // 
            this.lbl_valor_parcelas.AutoSize = true;
            this.lbl_valor_parcelas.Location = new System.Drawing.Point(313, 31);
            this.lbl_valor_parcelas.Name = "lbl_valor_parcelas";
            this.lbl_valor_parcelas.Size = new System.Drawing.Size(28, 13);
            this.lbl_valor_parcelas.TabIndex = 3;
            this.lbl_valor_parcelas.Text = "0.00";
            // 
            // lbl_valor_restante
            // 
            this.lbl_valor_restante.AutoSize = true;
            this.lbl_valor_restante.Location = new System.Drawing.Point(101, 86);
            this.lbl_valor_restante.Name = "lbl_valor_restante";
            this.lbl_valor_restante.Size = new System.Drawing.Size(28, 13);
            this.lbl_valor_restante.TabIndex = 3;
            this.lbl_valor_restante.Text = "0.00";
            // 
            // lbl_troco
            // 
            this.lbl_troco.AutoSize = true;
            this.lbl_troco.Location = new System.Drawing.Point(268, 73);
            this.lbl_troco.Name = "lbl_troco";
            this.lbl_troco.Size = new System.Drawing.Size(28, 13);
            this.lbl_troco.TabIndex = 3;
            this.lbl_troco.Text = "0.00";
            // 
            // lbl_valor_pago
            // 
            this.lbl_valor_pago.AutoSize = true;
            this.lbl_valor_pago.Location = new System.Drawing.Point(101, 73);
            this.lbl_valor_pago.Name = "lbl_valor_pago";
            this.lbl_valor_pago.Size = new System.Drawing.Size(28, 13);
            this.lbl_valor_pago.TabIndex = 3;
            this.lbl_valor_pago.Text = "0.00";
            // 
            // lbl_desconto
            // 
            this.lbl_desconto.AutoSize = true;
            this.lbl_desconto.Location = new System.Drawing.Point(101, 31);
            this.lbl_desconto.Name = "lbl_desconto";
            this.lbl_desconto.Size = new System.Drawing.Size(28, 13);
            this.lbl_desconto.TabIndex = 3;
            this.lbl_desconto.Text = "0.00";
            // 
            // lbl_valor_final
            // 
            this.lbl_valor_final.AutoSize = true;
            this.lbl_valor_final.Location = new System.Drawing.Point(101, 45);
            this.lbl_valor_final.Name = "lbl_valor_final";
            this.lbl_valor_final.Size = new System.Drawing.Size(28, 13);
            this.lbl_valor_final.TabIndex = 3;
            this.lbl_valor_final.Text = "0.00";
            // 
            // lbl_valor_total
            // 
            this.lbl_valor_total.AutoSize = true;
            this.lbl_valor_total.Location = new System.Drawing.Point(101, 18);
            this.lbl_valor_total.Name = "lbl_valor_total";
            this.lbl_valor_total.Size = new System.Drawing.Size(28, 13);
            this.lbl_valor_total.TabIndex = 3;
            this.lbl_valor_total.Text = "0.00";
            // 
            // lbl_info_pagamento
            // 
            this.lbl_info_pagamento.AutoSize = true;
            this.lbl_info_pagamento.Location = new System.Drawing.Point(230, 31);
            this.lbl_info_pagamento.Name = "lbl_info_pagamento";
            this.lbl_info_pagamento.Size = new System.Drawing.Size(77, 13);
            this.lbl_info_pagamento.TabIndex = 3;
            this.lbl_info_pagamento.Text = "Valor parcelas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Valor Final:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tipo de Desconto:";
            // 
            // btn_concluir
            // 
            this.btn_concluir.Location = new System.Drawing.Point(450, 199);
            this.btn_concluir.Name = "btn_concluir";
            this.btn_concluir.Size = new System.Drawing.Size(92, 29);
            this.btn_concluir.TabIndex = 5;
            this.btn_concluir.Text = "Concluir";
            this.btn_concluir.UseVisualStyleBackColor = true;
            this.btn_concluir.Click += new System.EventHandler(this.btn_concluir_Click);
            // 
            // btn_adiciona_pagamento
            // 
            this.btn_adiciona_pagamento.Enabled = false;
            this.btn_adiciona_pagamento.Location = new System.Drawing.Point(450, 158);
            this.btn_adiciona_pagamento.Name = "btn_adiciona_pagamento";
            this.btn_adiciona_pagamento.Size = new System.Drawing.Size(92, 35);
            this.btn_adiciona_pagamento.TabIndex = 5;
            this.btn_adiciona_pagamento.Text = "Adicionar Pagamento";
            this.btn_adiciona_pagamento.UseVisualStyleBackColor = true;
            this.btn_adiciona_pagamento.Click += new System.EventHandler(this.btn_adiciona_pagamento_Click);
            // 
            // dataGrid_pagamentos
            // 
            this.dataGrid_pagamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_pagamentos.Location = new System.Drawing.Point(12, 199);
            this.dataGrid_pagamentos.Name = "dataGrid_pagamentos";
            this.dataGrid_pagamentos.Size = new System.Drawing.Size(530, 150);
            this.dataGrid_pagamentos.TabIndex = 6;
            this.dataGrid_pagamentos.Visible = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(358, 199);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(86, 29);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(25, 355);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 7;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(106, 355);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(75, 23);
            this.btn_remover.TabIndex = 7;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            // 
            // FormRecebePagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(554, 232);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_adiciona_pagamento);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_concluir);
            this.Controls.Add(this.lbl_tipo_desconto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_valor_pago);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_formaPagamento);
            this.Controls.Add(this.dataGrid_pagamentos);
            this.Name = "FormRecebePagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRecebePagamento";
            this.Load += new System.EventHandler(this.FormRecebePagamento_Load);
            this.groupBox_formaPagamento.ResumeLayout(false);
            this.groupBox_formaPagamento.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_pagamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioDinheiro;
        private System.Windows.Forms.RadioButton radioDebito;
        private System.Windows.Forms.RadioButton radioCredito;
        private System.Windows.Forms.TextBox txt_valor_pago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_tipo_desconto;
        private System.Windows.Forms.ComboBox combo_parcelas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_concluir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_valor_restante;
        private System.Windows.Forms.Label lbl_valor_pago;
        private System.Windows.Forms.Label lbl_valor_final;
        private System.Windows.Forms.Label lbl_valor_total;
        private System.Windows.Forms.Label lbl_info_pagamento;
        private System.Windows.Forms.Button btn_adiciona_pagamento;
        private System.Windows.Forms.DataGridView dataGrid_pagamentos;
        private System.Windows.Forms.Button btn_cancelar;
        public System.Windows.Forms.GroupBox groupBox_formaPagamento;
        private System.Windows.Forms.Label lbl_valor_parcelas;
        private System.Windows.Forms.Label lbl_desconto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_troco;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_remover;
    }
}