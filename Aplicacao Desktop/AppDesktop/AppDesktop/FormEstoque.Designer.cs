namespace AppDesktop
{
    partial class FormEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstoque));
            this.dataGrid_estoque = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.criarPromoçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarListaDePedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.produtoDevolvidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirNovoProdutoDevolvidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProdutosDevolvidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.fornecedorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.consultarPromoçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_Deletar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.ajustePrecoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajusteDePromocaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_Editar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_Inativar = new System.Windows.Forms.ToolStripButton();
            this.backgroundWorker_RequisitaPermissao = new System.ComponentModel.BackgroundWorker();
            this.timerValidaPermissao = new System.Windows.Forms.Timer(this.components);
            this.toolStrip_Atualizar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_estoque)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid_estoque
            // 
            this.dataGrid_estoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_estoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_estoque.Location = new System.Drawing.Point(3, 37);
            this.dataGrid_estoque.Name = "dataGrid_estoque";
            this.dataGrid_estoque.Size = new System.Drawing.Size(1314, 532);
            this.dataGrid_estoque.TabIndex = 3;
            this.dataGrid_estoque.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_estoque_RowEnter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.dataGrid_estoque);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1345, 572);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStrip_Deletar,
            this.toolStripSplitButton1,
            this.toolStripSeparator1,
            this.toolStripComboBox1,
            this.toolStripSeparator5,
            this.toolStrip_Editar,
            this.toolStripSeparator4,
            this.toolStrip_Inativar,
            this.toolStrip_Atualizar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1345, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fornecedorToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.toolStripSeparator2,
            this.criarPromoçãoToolStripMenuItem,
            this.criarListaDePedidosToolStripMenuItem,
            this.toolStripSeparator6,
            this.produtoDevolvidoToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "Novo";
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.fornecedorToolStripMenuItem.Text = "Cadastrar Fornecedor";
            this.fornecedorToolStripMenuItem.Click += new System.EventHandler(this.fornecedorToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.categoriaToolStripMenuItem.Text = "Criar Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.produtoToolStripMenuItem.Text = "Novo Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(184, 6);
            // 
            // criarPromoçãoToolStripMenuItem
            // 
            this.criarPromoçãoToolStripMenuItem.Name = "criarPromoçãoToolStripMenuItem";
            this.criarPromoçãoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.criarPromoçãoToolStripMenuItem.Text = "Criar Promoção";
            // 
            // criarListaDePedidosToolStripMenuItem
            // 
            this.criarListaDePedidosToolStripMenuItem.Name = "criarListaDePedidosToolStripMenuItem";
            this.criarListaDePedidosToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.criarListaDePedidosToolStripMenuItem.Text = "Criar lista de pedidos";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(184, 6);
            // 
            // produtoDevolvidoToolStripMenuItem
            // 
            this.produtoDevolvidoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirNovoProdutoDevolvidoToolStripMenuItem,
            this.consultarProdutosDevolvidosToolStripMenuItem});
            this.produtoDevolvidoToolStripMenuItem.Name = "produtoDevolvidoToolStripMenuItem";
            this.produtoDevolvidoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.produtoDevolvidoToolStripMenuItem.Text = "Produto devolvido";
            // 
            // inserirNovoProdutoDevolvidoToolStripMenuItem
            // 
            this.inserirNovoProdutoDevolvidoToolStripMenuItem.Name = "inserirNovoProdutoDevolvidoToolStripMenuItem";
            this.inserirNovoProdutoDevolvidoToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.inserirNovoProdutoDevolvidoToolStripMenuItem.Text = "Inserir novo produto devolvido";
            // 
            // consultarProdutosDevolvidosToolStripMenuItem
            // 
            this.consultarProdutosDevolvidosToolStripMenuItem.Name = "consultarProdutosDevolvidosToolStripMenuItem";
            this.consultarProdutosDevolvidosToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.consultarProdutosDevolvidosToolStripMenuItem.Text = "Visualizar produtos devolvidos";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fornecedorToolStripMenuItem1,
            this.produtoToolStripMenuItem1,
            this.toolStripSeparator3,
            this.consultarPromoçãoToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // fornecedorToolStripMenuItem1
            // 
            this.fornecedorToolStripMenuItem1.Name = "fornecedorToolStripMenuItem1";
            this.fornecedorToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.fornecedorToolStripMenuItem1.Text = "Buscar Fornecedor";
            this.fornecedorToolStripMenuItem1.Click += new System.EventHandler(this.fornecedorToolStripMenuItem1_Click);
            // 
            // produtoToolStripMenuItem1
            // 
            this.produtoToolStripMenuItem1.Name = "produtoToolStripMenuItem1";
            this.produtoToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.produtoToolStripMenuItem1.Text = "Buscar Produto";
            this.produtoToolStripMenuItem1.Click += new System.EventHandler(this.produtoToolStripMenuItem1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(180, 6);
            // 
            // consultarPromoçãoToolStripMenuItem
            // 
            this.consultarPromoçãoToolStripMenuItem.Name = "consultarPromoçãoToolStripMenuItem";
            this.consultarPromoçãoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.consultarPromoçãoToolStripMenuItem.Text = "Consultar Promoção";
            // 
            // toolStrip_Deletar
            // 
            this.toolStrip_Deletar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_Deletar.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_Deletar.Image")));
            this.toolStrip_Deletar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_Deletar.Name = "toolStrip_Deletar";
            this.toolStrip_Deletar.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_Deletar.Text = "toolStripButton1";
            this.toolStrip_Deletar.Click += new System.EventHandler(this.toolStrip_Deletar_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajustePrecoToolStripMenuItem,
            this.ajusteDePromocaoToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // ajustePrecoToolStripMenuItem
            // 
            this.ajustePrecoToolStripMenuItem.Name = "ajustePrecoToolStripMenuItem";
            this.ajustePrecoToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.ajustePrecoToolStripMenuItem.Text = "AJUSTE DE PREÇO";
            // 
            // ajusteDePromocaoToolStripMenuItem
            // 
            this.ajusteDePromocaoToolStripMenuItem.Name = "ajusteDePromocaoToolStripMenuItem";
            this.ajusteDePromocaoToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.ajusteDePromocaoToolStripMenuItem.Text = "AJUSTE DE PROMOÇÃO";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "CATEGORIA",
            "ESTOQUE",
            "FORNECEDOR"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip_Editar
            // 
            this.toolStrip_Editar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStrip_Editar.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_Editar.Image")));
            this.toolStrip_Editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_Editar.Name = "toolStrip_Editar";
            this.toolStrip_Editar.Size = new System.Drawing.Size(49, 22);
            this.toolStrip_Editar.Text = "EDITAR";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip_Inativar
            // 
            this.toolStrip_Inativar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_Inativar.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_Inativar.Image")));
            this.toolStrip_Inativar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_Inativar.Name = "toolStrip_Inativar";
            this.toolStrip_Inativar.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_Inativar.Text = "toolStripButton4";
            // 
            // backgroundWorker_RequisitaPermissao
            // 
            this.backgroundWorker_RequisitaPermissao.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_RequisitaPermissao_DoWork);
            this.backgroundWorker_RequisitaPermissao.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RequisitaPermissao_RunWorkerCompleted);
            // 
            // timerValidaPermissao
            // 
            this.timerValidaPermissao.Interval = 10000;
            this.timerValidaPermissao.Tick += new System.EventHandler(this.timerValidaPermissao_Tick);
            // 
            // toolStrip_Atualizar
            // 
            this.toolStrip_Atualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_Atualizar.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_Atualizar.Image")));
            this.toolStrip_Atualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_Atualizar.Name = "toolStrip_Atualizar";
            this.toolStrip_Atualizar.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_Atualizar.Text = "toolStripButton1";
            this.toolStrip_Atualizar.ToolTipText = "Atualizar";
            // 
            // FormEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1320, 585);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEstoque";
            this.Text = "FormEstoque";
            this.Load += new System.EventHandler(this.FormEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_estoque)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton toolStrip_Deletar;
        public System.Windows.Forms.DataGridView dataGrid_estoque;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem criarPromoçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarListaDePedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem consultarPromoçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem ajustePrecoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajusteDePromocaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStrip_Editar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStrip_Inativar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem produtoDevolvidoToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker_RequisitaPermissao;
        private System.Windows.Forms.ToolStripMenuItem inserirNovoProdutoDevolvidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarProdutosDevolvidosToolStripMenuItem;
        private System.Windows.Forms.Timer timerValidaPermissao;
        private System.Windows.Forms.ToolStripButton toolStrip_Atualizar;
    }
}