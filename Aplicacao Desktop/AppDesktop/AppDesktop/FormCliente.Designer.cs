namespace AppDesktop
{
    partial class FormCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCliente));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_add = new System.Windows.Forms.ToolStripButton();
            this.tollStripButton_consultar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_Atualizar = new System.Windows.Forms.ToolStripButton();
            this.dataGrid_cliente = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_cliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_add,
            this.tollStripButton_consultar,
            this.toolStrip_Atualizar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1320, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_add
            // 
            this.toolStripButton_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_add.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_add.Image")));
            this.toolStripButton_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_add.Name = "toolStripButton_add";
            this.toolStripButton_add.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_add.Text = "toolStripButton1";
            this.toolStripButton_add.Click += new System.EventHandler(this.toolStripButton_add_Click);
            // 
            // tollStripButton_consultar
            // 
            this.tollStripButton_consultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tollStripButton_consultar.Image = ((System.Drawing.Image)(resources.GetObject("tollStripButton_consultar.Image")));
            this.tollStripButton_consultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tollStripButton_consultar.Name = "tollStripButton_consultar";
            this.tollStripButton_consultar.Size = new System.Drawing.Size(23, 22);
            this.tollStripButton_consultar.Text = "Consultar";
            this.tollStripButton_consultar.Click += new System.EventHandler(this.tollStripButton_consultar_Click);
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
            // dataGrid_cliente
            // 
            this.dataGrid_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_cliente.Location = new System.Drawing.Point(12, 90);
            this.dataGrid_cliente.MultiSelect = false;
            this.dataGrid_cliente.Name = "dataGrid_cliente";
            this.dataGrid_cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_cliente.Size = new System.Drawing.Size(1280, 444);
            this.dataGrid_cliente.TabIndex = 1;
            this.dataGrid_cliente.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_cliente_RowEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(29, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 56);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPF/CNPJ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(284, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(338, 20);
            this.textBox2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1320, 546);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGrid_cliente);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCliente";
            this.Text = "FormCliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_cliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_add;
        private System.Windows.Forms.DataGridView dataGrid_cliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripButton toolStrip_Atualizar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripButton tollStripButton_consultar;
    }
}