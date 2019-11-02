namespace AppDesktop
{
    partial class FormRegrasNegocio
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
            this.tab_regras_negocio = new System.Windows.Forms.TabControl();
            this.tab_Estoques = new System.Windows.Forms.TabPage();
            this.tab_Vendas = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.combo_tipo_venda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radio_desconto = new System.Windows.Forms.RadioButton();
            this.label22 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radio_acrescimo = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_criar_regra = new System.Windows.Forms.Button();
            this.group_desconto = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_desconto_quantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_desconto_total = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_desconto_produto = new System.Windows.Forms.TextBox();
            this.desconto_quantidade = new System.Windows.Forms.CheckBox();
            this.desconto_venda = new System.Windows.Forms.CheckBox();
            this.desconto_produto = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_total_venda = new System.Windows.Forms.TextBox();
            this.combo_total_venda = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.txt_quantidade_produto = new System.Windows.Forms.TextBox();
            this.combo_valor = new System.Windows.Forms.ComboBox();
            this.combo_quantidade_produto = new System.Windows.Forms.ComboBox();
            this.group_acrescimo = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_acrescimo = new System.Windows.Forms.TextBox();
            this.check_por_parcela = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.combo_fparcelas = new System.Windows.Forms.ComboBox();
            this.combo_iparcelas = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tab_regras_negocio.SuspendLayout();
            this.tab_Vendas.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.group_desconto.SuspendLayout();
            this.group_acrescimo.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_regras_negocio
            // 
            this.tab_regras_negocio.Controls.Add(this.tab_Estoques);
            this.tab_regras_negocio.Controls.Add(this.tab_Vendas);
            this.tab_regras_negocio.Location = new System.Drawing.Point(12, 12);
            this.tab_regras_negocio.Name = "tab_regras_negocio";
            this.tab_regras_negocio.SelectedIndex = 0;
            this.tab_regras_negocio.Size = new System.Drawing.Size(1280, 522);
            this.tab_regras_negocio.TabIndex = 0;
            // 
            // tab_Estoques
            // 
            this.tab_Estoques.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tab_Estoques.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tab_Estoques.Location = new System.Drawing.Point(4, 22);
            this.tab_Estoques.Name = "tab_Estoques";
            this.tab_Estoques.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Estoques.Size = new System.Drawing.Size(1272, 496);
            this.tab_Estoques.TabIndex = 0;
            this.tab_Estoques.Text = "Estoque";
            // 
            // tab_Vendas
            // 
            this.tab_Vendas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tab_Vendas.Controls.Add(this.groupBox7);
            this.tab_Vendas.Controls.Add(this.groupBox6);
            this.tab_Vendas.Controls.Add(this.groupBox5);
            this.tab_Vendas.Controls.Add(this.dataGridView1);
            this.tab_Vendas.Controls.Add(this.groupBox3);
            this.tab_Vendas.Location = new System.Drawing.Point(4, 22);
            this.tab_Vendas.Name = "tab_Vendas";
            this.tab_Vendas.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Vendas.Size = new System.Drawing.Size(1272, 496);
            this.tab_Vendas.TabIndex = 1;
            this.tab_Vendas.Text = "Vendas";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txt_descricao);
            this.groupBox7.Controls.Add(this.combo_tipo_venda);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.radio_desconto);
            this.groupBox7.Controls.Add(this.label22);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.radio_acrescimo);
            this.groupBox7.Controls.Add(this.button1);
            this.groupBox7.Controls.Add(this.btn_criar_regra);
            this.groupBox7.Controls.Add(this.group_desconto);
            this.groupBox7.Controls.Add(this.group_acrescimo);
            this.groupBox7.Location = new System.Drawing.Point(23, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(804, 195);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Nova Regra";
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(74, 19);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(217, 20);
            this.txt_descricao.TabIndex = 4;
            // 
            // combo_tipo_venda
            // 
            this.combo_tipo_venda.FormattingEnabled = true;
            this.combo_tipo_venda.Items.AddRange(new object[] {
            "No dinheiro",
            "No debito",
            "Parceladas",
            "Todas"});
            this.combo_tipo_venda.Location = new System.Drawing.Point(662, 20);
            this.combo_tipo_venda.Name = "combo_tipo_venda";
            this.combo_tipo_venda.Size = new System.Drawing.Size(121, 21);
            this.combo_tipo_venda.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valido para vendas";
            // 
            // radio_desconto
            // 
            this.radio_desconto.AutoSize = true;
            this.radio_desconto.Location = new System.Drawing.Point(470, 21);
            this.radio_desconto.Name = "radio_desconto";
            this.radio_desconto.Size = new System.Drawing.Size(71, 17);
            this.radio_desconto.TabIndex = 6;
            this.radio_desconto.TabStop = true;
            this.radio_desconto.Text = "Desconto";
            this.radio_desconto.UseVisualStyleBackColor = true;
            this.radio_desconto.CheckedChanged += new System.EventHandler(this.radio_desconto_CheckedChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(14, 22);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 13);
            this.label22.TabIndex = 1;
            this.label22.Text = "Descrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Regras para:";
            // 
            // radio_acrescimo
            // 
            this.radio_acrescimo.AutoSize = true;
            this.radio_acrescimo.Location = new System.Drawing.Point(379, 21);
            this.radio_acrescimo.Name = "radio_acrescimo";
            this.radio_acrescimo.Size = new System.Drawing.Size(74, 17);
            this.radio_acrescimo.TabIndex = 6;
            this.radio_acrescimo.TabStop = true;
            this.radio_acrescimo.Text = "Acrescimo";
            this.radio_acrescimo.UseVisualStyleBackColor = true;
            this.radio_acrescimo.CheckedChanged += new System.EventHandler(this.radio_acrescimo_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(642, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "teste";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_criar_regra
            // 
            this.btn_criar_regra.Location = new System.Drawing.Point(723, 166);
            this.btn_criar_regra.Name = "btn_criar_regra";
            this.btn_criar_regra.Size = new System.Drawing.Size(75, 23);
            this.btn_criar_regra.TabIndex = 5;
            this.btn_criar_regra.Text = "Criar regra";
            this.btn_criar_regra.UseVisualStyleBackColor = true;
            this.btn_criar_regra.Click += new System.EventHandler(this.btn_criar_regra_Click);
            // 
            // group_desconto
            // 
            this.group_desconto.Controls.Add(this.label6);
            this.group_desconto.Controls.Add(this.label7);
            this.group_desconto.Controls.Add(this.txt_desconto_quantidade);
            this.group_desconto.Controls.Add(this.label2);
            this.group_desconto.Controls.Add(this.label3);
            this.group_desconto.Controls.Add(this.txt_desconto_total);
            this.group_desconto.Controls.Add(this.label9);
            this.group_desconto.Controls.Add(this.label13);
            this.group_desconto.Controls.Add(this.txt_desconto_produto);
            this.group_desconto.Controls.Add(this.desconto_quantidade);
            this.group_desconto.Controls.Add(this.desconto_venda);
            this.group_desconto.Controls.Add(this.desconto_produto);
            this.group_desconto.Controls.Add(this.label11);
            this.group_desconto.Controls.Add(this.txt_total_venda);
            this.group_desconto.Controls.Add(this.combo_total_venda);
            this.group_desconto.Controls.Add(this.label10);
            this.group_desconto.Controls.Add(this.label5);
            this.group_desconto.Controls.Add(this.txt_valor);
            this.group_desconto.Controls.Add(this.txt_quantidade_produto);
            this.group_desconto.Controls.Add(this.combo_valor);
            this.group_desconto.Controls.Add(this.combo_quantidade_produto);
            this.group_desconto.Location = new System.Drawing.Point(11, 47);
            this.group_desconto.Name = "group_desconto";
            this.group_desconto.Size = new System.Drawing.Size(787, 118);
            this.group_desconto.TabIndex = 3;
            this.group_desconto.TabStop = false;
            this.group_desconto.Text = "Condições de Desconto";
            this.group_desconto.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(424, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "% de desconto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(331, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Aplicar";
            // 
            // txt_desconto_quantidade
            // 
            this.txt_desconto_quantidade.Location = new System.Drawing.Point(376, 62);
            this.txt_desconto_quantidade.Name = "txt_desconto_quantidade";
            this.txt_desconto_quantidade.Size = new System.Drawing.Size(41, 20);
            this.txt_desconto_quantidade.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "% de desconto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Aplicar";
            // 
            // txt_desconto_total
            // 
            this.txt_desconto_total.Location = new System.Drawing.Point(384, 39);
            this.txt_desconto_total.Name = "txt_desconto_total";
            this.txt_desconto_total.Size = new System.Drawing.Size(41, 20);
            this.txt_desconto_total.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(432, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "% de desconto";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(339, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Aplicar";
            // 
            // txt_desconto_produto
            // 
            this.txt_desconto_produto.Location = new System.Drawing.Point(384, 18);
            this.txt_desconto_produto.Name = "txt_desconto_produto";
            this.txt_desconto_produto.Size = new System.Drawing.Size(41, 20);
            this.txt_desconto_produto.TabIndex = 10;
            // 
            // desconto_quantidade
            // 
            this.desconto_quantidade.AutoSize = true;
            this.desconto_quantidade.Location = new System.Drawing.Point(6, 64);
            this.desconto_quantidade.Name = "desconto_quantidade";
            this.desconto_quantidade.Size = new System.Drawing.Size(161, 17);
            this.desconto_quantidade.TabIndex = 7;
            this.desconto_quantidade.Text = "A quantidade de produtor for";
            this.desconto_quantidade.UseVisualStyleBackColor = true;
            // 
            // desconto_venda
            // 
            this.desconto_venda.AutoSize = true;
            this.desconto_venda.Location = new System.Drawing.Point(6, 42);
            this.desconto_venda.Name = "desconto_venda";
            this.desconto_venda.Size = new System.Drawing.Size(146, 17);
            this.desconto_venda.TabIndex = 7;
            this.desconto_venda.Text = "O valor total da venda for";
            this.desconto_venda.UseVisualStyleBackColor = true;
            // 
            // desconto_produto
            // 
            this.desconto_produto.AutoSize = true;
            this.desconto_produto.Location = new System.Drawing.Point(6, 21);
            this.desconto_produto.Name = "desconto_produto";
            this.desconto_produto.Size = new System.Drawing.Size(146, 17);
            this.desconto_produto.TabIndex = 7;
            this.desconto_produto.Text = "O valor de um produto for";
            this.desconto_produto.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(241, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "que";
            // 
            // txt_total_venda
            // 
            this.txt_total_venda.Location = new System.Drawing.Point(272, 40);
            this.txt_total_venda.Name = "txt_total_venda";
            this.txt_total_venda.Size = new System.Drawing.Size(59, 20);
            this.txt_total_venda.TabIndex = 6;
            // 
            // combo_total_venda
            // 
            this.combo_total_venda.FormattingEnabled = true;
            this.combo_total_venda.Items.AddRange(new object[] {
            "Maior",
            "Maior ou igual",
            "Menor",
            "Menor ou igual",
            "O mesmo"});
            this.combo_total_venda.Location = new System.Drawing.Point(154, 40);
            this.combo_total_venda.Name = "combo_total_venda";
            this.combo_total_venda.Size = new System.Drawing.Size(81, 21);
            this.combo_total_venda.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(241, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "que";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "que";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(272, 18);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(59, 20);
            this.txt_valor.TabIndex = 2;
            // 
            // txt_quantidade_produto
            // 
            this.txt_quantidade_produto.Location = new System.Drawing.Point(290, 62);
            this.txt_quantidade_produto.Name = "txt_quantidade_produto";
            this.txt_quantidade_produto.Size = new System.Drawing.Size(41, 20);
            this.txt_quantidade_produto.TabIndex = 2;
            // 
            // combo_valor
            // 
            this.combo_valor.FormattingEnabled = true;
            this.combo_valor.Items.AddRange(new object[] {
            "Maior ou igual",
            "Menor ou igual"});
            this.combo_valor.Location = new System.Drawing.Point(154, 18);
            this.combo_valor.Name = "combo_valor";
            this.combo_valor.Size = new System.Drawing.Size(81, 21);
            this.combo_valor.TabIndex = 0;
            // 
            // combo_quantidade_produto
            // 
            this.combo_quantidade_produto.FormattingEnabled = true;
            this.combo_quantidade_produto.Items.AddRange(new object[] {
            "Maior",
            "Maior ou igual",
            "Menor",
            "Menor ou igual",
            "O mesmo"});
            this.combo_quantidade_produto.Location = new System.Drawing.Point(170, 62);
            this.combo_quantidade_produto.Name = "combo_quantidade_produto";
            this.combo_quantidade_produto.Size = new System.Drawing.Size(81, 21);
            this.combo_quantidade_produto.TabIndex = 0;
            // 
            // group_acrescimo
            // 
            this.group_acrescimo.Controls.Add(this.label14);
            this.group_acrescimo.Controls.Add(this.txt_acrescimo);
            this.group_acrescimo.Controls.Add(this.check_por_parcela);
            this.group_acrescimo.Controls.Add(this.label15);
            this.group_acrescimo.Location = new System.Drawing.Point(11, 47);
            this.group_acrescimo.Name = "group_acrescimo";
            this.group_acrescimo.Size = new System.Drawing.Size(520, 145);
            this.group_acrescimo.TabIndex = 3;
            this.group_acrescimo.TabStop = false;
            this.group_acrescimo.Text = "Condições de Acréscimo";
            this.group_acrescimo.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Acréscimo de";
            // 
            // txt_acrescimo
            // 
            this.txt_acrescimo.Location = new System.Drawing.Point(97, 32);
            this.txt_acrescimo.Name = "txt_acrescimo";
            this.txt_acrescimo.Size = new System.Drawing.Size(41, 20);
            this.txt_acrescimo.TabIndex = 2;
            // 
            // check_por_parcela
            // 
            this.check_por_parcela.AutoSize = true;
            this.check_por_parcela.Location = new System.Drawing.Point(227, 34);
            this.check_por_parcela.Name = "check_por_parcela";
            this.check_por_parcela.Size = new System.Drawing.Size(80, 17);
            this.check_por_parcela.TabIndex = 7;
            this.check_por_parcela.Text = "Por parcela";
            this.check_por_parcela.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(142, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "%";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radioButton8);
            this.groupBox6.Controls.Add(this.radioButton6);
            this.groupBox6.Controls.Add(this.radioButton7);
            this.groupBox6.Location = new System.Drawing.Point(235, 201);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(214, 39);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(2, 16);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(55, 17);
            this.radioButton8.TabIndex = 6;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Todos";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(61, 16);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(74, 17);
            this.radioButton6.TabIndex = 6;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Acrescimo";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(141, 16);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(71, 17);
            this.radioButton7.TabIndex = 6;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Desconto";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton3);
            this.groupBox5.Controls.Add(this.radioButton5);
            this.groupBox5.Controls.Add(this.radioButton4);
            this.groupBox5.Location = new System.Drawing.Point(22, 201);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(214, 39);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Exibir";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(5, 16);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(55, 17);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Todas";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(135, 16);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(62, 17);
            this.radioButton5.TabIndex = 6;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Inativas";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(68, 16);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(54, 17);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Ativas";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1042, 240);
            this.dataGridView1.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.combo_fparcelas);
            this.groupBox3.Controls.Add(this.combo_iparcelas);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Location = new System.Drawing.Point(852, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 39);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parcelas";
            // 
            // combo_fparcelas
            // 
            this.combo_fparcelas.FormattingEnabled = true;
            this.combo_fparcelas.Items.AddRange(new object[] {
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
            this.combo_fparcelas.Location = new System.Drawing.Point(128, 13);
            this.combo_fparcelas.Name = "combo_fparcelas";
            this.combo_fparcelas.Size = new System.Drawing.Size(53, 21);
            this.combo_fparcelas.TabIndex = 5;
            // 
            // combo_iparcelas
            // 
            this.combo_iparcelas.FormattingEnabled = true;
            this.combo_iparcelas.Items.AddRange(new object[] {
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
            this.combo_iparcelas.Location = new System.Drawing.Point(35, 13);
            this.combo_iparcelas.Name = "combo_iparcelas";
            this.combo_iparcelas.Size = new System.Drawing.Size(53, 21);
            this.combo_iparcelas.TabIndex = 5;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(99, 16);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(23, 13);
            this.label24.TabIndex = 1;
            this.label24.Text = "Ate";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(16, 16);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(21, 13);
            this.label23.TabIndex = 1;
            this.label23.Text = "De";
            // 
            // FormRegrasNegocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1304, 546);
            this.Controls.Add(this.tab_regras_negocio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegrasNegocio";
            this.Text = "FormRegrasNegocio";
            this.Load += new System.EventHandler(this.FormRegrasNegocio_Load);
            this.tab_regras_negocio.ResumeLayout(false);
            this.tab_Vendas.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.group_desconto.ResumeLayout(false);
            this.group_desconto.PerformLayout();
            this.group_acrescimo.ResumeLayout(false);
            this.group_acrescimo.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_regras_negocio;
        private System.Windows.Forms.TabPage tab_Estoques;
        private System.Windows.Forms.TabPage tab_Vendas;
        private System.Windows.Forms.ComboBox combo_tipo_venda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox group_acrescimo;
        private System.Windows.Forms.GroupBox group_desconto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_total_venda;
        private System.Windows.Forms.ComboBox combo_total_venda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.TextBox txt_quantidade_produto;
        private System.Windows.Forms.ComboBox combo_valor;
        private System.Windows.Forms.ComboBox combo_quantidade_produto;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.RadioButton radio_desconto;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radio_acrescimo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_desconto_produto;
        private System.Windows.Forms.CheckBox desconto_quantidade;
        private System.Windows.Forms.CheckBox desconto_venda;
        private System.Windows.Forms.CheckBox desconto_produto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox combo_fparcelas;
        private System.Windows.Forms.ComboBox combo_iparcelas;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btn_criar_regra;
        private System.Windows.Forms.CheckBox check_por_parcela;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_acrescimo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_desconto_quantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_desconto_total;
        private System.Windows.Forms.Button button1;
    }
}