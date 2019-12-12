namespace AppDesktop
{
    partial class FormVenda
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
            this.dataGrid_venda = new System.Windows.Forms.DataGridView();
            this.btn_view_cliente = new System.Windows.Forms.Button();
            this.combo_filtro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.masked_DataFim = new System.Windows.Forms.MaskedTextBox();
            this.masked_DataInicio = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_busca = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_filtro2 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_qtd_resultados = new System.Windows.Forms.Label();
            this.dataGrid_Itens = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_venda)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Itens)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_venda
            // 
            this.dataGrid_venda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_venda.Location = new System.Drawing.Point(12, 89);
            this.dataGrid_venda.Name = "dataGrid_venda";
            this.dataGrid_venda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_venda.Size = new System.Drawing.Size(1280, 213);
            this.dataGrid_venda.TabIndex = 0;
            this.dataGrid_venda.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_venda_RowEnter);
            this.dataGrid_venda.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_venda_RowValidated);
            // 
            // btn_view_cliente
            // 
            this.btn_view_cliente.Location = new System.Drawing.Point(1165, 60);
            this.btn_view_cliente.Name = "btn_view_cliente";
            this.btn_view_cliente.Size = new System.Drawing.Size(115, 23);
            this.btn_view_cliente.TabIndex = 1;
            this.btn_view_cliente.Text = "Visualizar comprador";
            this.btn_view_cliente.UseVisualStyleBackColor = true;
            this.btn_view_cliente.Click += new System.EventHandler(this.btn_view_cliente_Click);
            // 
            // combo_filtro
            // 
            this.combo_filtro.FormattingEnabled = true;
            this.combo_filtro.Items.AddRange(new object[] {
            "TODAS",
            "VENDAS DE HOJE",
            "ULTIMAS VENDAS",
            "VALOR",
            "QUANTIDADE",
            "TIPO DE VENDA"});
            this.combo_filtro.Location = new System.Drawing.Point(87, 60);
            this.combo_filtro.Name = "combo_filtro";
            this.combo_filtro.Size = new System.Drawing.Size(121, 21);
            this.combo_filtro.TabIndex = 2;
            this.combo_filtro.SelectedIndexChanged += new System.EventHandler(this.combo_filtro_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtrar por";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.masked_DataFim);
            this.groupBox1.Controls.Add(this.masked_DataInicio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_busca);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 51);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções de Busca";
            // 
            // masked_DataFim
            // 
            this.masked_DataFim.Location = new System.Drawing.Point(134, 19);
            this.masked_DataFim.Mask = "00/00/0000";
            this.masked_DataFim.Name = "masked_DataFim";
            this.masked_DataFim.Size = new System.Drawing.Size(69, 20);
            this.masked_DataFim.TabIndex = 0;
            this.masked_DataFim.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // masked_DataInicio
            // 
            this.masked_DataInicio.Location = new System.Drawing.Point(30, 19);
            this.masked_DataInicio.Mask = "00/00/0000";
            this.masked_DataInicio.Name = "masked_DataInicio";
            this.masked_DataInicio.Size = new System.Drawing.Size(69, 20);
            this.masked_DataInicio.TabIndex = 0;
            this.masked_DataInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Até";
            // 
            // btn_busca
            // 
            this.btn_busca.Location = new System.Drawing.Point(217, 17);
            this.btn_busca.Name = "btn_busca";
            this.btn_busca.Size = new System.Drawing.Size(60, 23);
            this.btn_busca.TabIndex = 1;
            this.btn_busca.Text = "Busca";
            this.btn_busca.UseVisualStyleBackColor = true;
            this.btn_busca.Click += new System.EventHandler(this.btn_busca_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "De";
            // 
            // combo_filtro2
            // 
            this.combo_filtro2.FormattingEnabled = true;
            this.combo_filtro2.Location = new System.Drawing.Point(214, 60);
            this.combo_filtro2.Name = "combo_filtro2";
            this.combo_filtro2.Size = new System.Drawing.Size(121, 21);
            this.combo_filtro2.TabIndex = 2;
            this.combo_filtro2.Visible = false;
            this.combo_filtro2.SelectedIndexChanged += new System.EventHandler(this.combo_filtro2_SelectedIndexChanged);
            this.combo_filtro2.TextUpdate += new System.EventHandler(this.combo_filtro2_TextUpdate);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(308, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 42);
            this.button4.TabIndex = 1;
            this.button4.Text = "Mais opões";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btn_exportar
            // 
            this.btn_exportar.Location = new System.Drawing.Point(1100, 60);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(59, 23);
            this.btn_exportar.TabIndex = 1;
            this.btn_exportar.Text = "Exportar";
            this.btn_exportar.UseVisualStyleBackColor = true;
            this.btn_exportar.Click += new System.EventHandler(this.btn_exportar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dados Encontrados:";
            // 
            // lbl_qtd_resultados
            // 
            this.lbl_qtd_resultados.AutoSize = true;
            this.lbl_qtd_resultados.Location = new System.Drawing.Point(457, 65);
            this.lbl_qtd_resultados.Name = "lbl_qtd_resultados";
            this.lbl_qtd_resultados.Size = new System.Drawing.Size(13, 13);
            this.lbl_qtd_resultados.TabIndex = 5;
            this.lbl_qtd_resultados.Text = "0";
            // 
            // dataGrid_Itens
            // 
            this.dataGrid_Itens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Itens.Location = new System.Drawing.Point(12, 345);
            this.dataGrid_Itens.Name = "dataGrid_Itens";
            this.dataGrid_Itens.Size = new System.Drawing.Size(1280, 189);
            this.dataGrid_Itens.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(983, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Somar Valor total";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(866, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Somar valor final";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(791, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Exibe RN";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1189, 316);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Item Devolvido";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(716, 60);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(69, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "Atualizar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1304, 546);
            this.Controls.Add(this.dataGrid_Itens);
            this.Controls.Add(this.lbl_qtd_resultados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_filtro2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.combo_filtro);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_exportar);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_view_cliente);
            this.Controls.Add(this.dataGrid_venda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVenda";
            this.Text = "FormVenda";
            this.Load += new System.EventHandler(this.FormVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_venda)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Itens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_venda;
        private System.Windows.Forms.Button btn_view_cliente;
        private System.Windows.Forms.ComboBox combo_filtro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox masked_DataFim;
        private System.Windows.Forms.MaskedTextBox masked_DataInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_busca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_filtro2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_exportar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_qtd_resultados;
        private System.Windows.Forms.DataGridView dataGrid_Itens;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}