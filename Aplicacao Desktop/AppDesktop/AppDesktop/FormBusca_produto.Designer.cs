namespace AppDesktop
{
    partial class FormBusca_produto
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
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_produto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_fornecedor = new System.Windows.Forms.Label();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.lbl_custo = new System.Windows.Forms.Label();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.lbl_preco = new System.Windows.Forms.Label();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_data = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(62, 21);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 1;
            this.txt_codigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_codigo_KeyDown);
            // 
            // txt_produto
            // 
            this.txt_produto.Location = new System.Drawing.Point(216, 21);
            this.txt_produto.Name = "txt_produto";
            this.txt_produto.Size = new System.Drawing.Size(404, 20);
            this.txt_produto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Produto";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 62);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 232);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txt_descricao);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.lbl_fornecedor);
            this.tabPage1.Controls.Add(this.lbl_quantidade);
            this.tabPage1.Controls.Add(this.lbl_custo);
            this.tabPage1.Controls.Add(this.lbl_data);
            this.tabPage1.Controls.Add(this.lbl_marca);
            this.tabPage1.Controls.Add(this.lbl_preco);
            this.tabPage1.Controls.Add(this.lbl_peso);
            this.tabPage1.Controls.Add(this.lbl_categoria);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 206);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Produto";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(18, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 53);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(180, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Criar promoção";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Deletar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(380, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Descrição:";
            // 
            // txt_descricao
            // 
            this.txt_descricao.Enabled = false;
            this.txt_descricao.Location = new System.Drawing.Point(383, 34);
            this.txt_descricao.Multiline = true;
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(379, 82);
            this.txt_descricao.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(166, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Marca:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Fornecedor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Disponibilidade de Estoque:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Categoria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Preço:";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(363, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(2, 101);
            this.label7.TabIndex = 0;
            // 
            // lbl_fornecedor
            // 
            this.lbl_fornecedor.AutoSize = true;
            this.lbl_fornecedor.Location = new System.Drawing.Point(75, 89);
            this.lbl_fornecedor.Name = "lbl_fornecedor";
            this.lbl_fornecedor.Size = new System.Drawing.Size(27, 13);
            this.lbl_fornecedor.TabIndex = 0;
            this.lbl_fornecedor.Text = "N/A";
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Location = new System.Drawing.Point(329, 16);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(28, 13);
            this.lbl_quantidade.TabIndex = 0;
            this.lbl_quantidade.Text = "0,00";
            // 
            // lbl_custo
            // 
            this.lbl_custo.AutoSize = true;
            this.lbl_custo.Location = new System.Drawing.Point(75, 16);
            this.lbl_custo.Name = "lbl_custo";
            this.lbl_custo.Size = new System.Drawing.Size(28, 13);
            this.lbl_custo.TabIndex = 0;
            this.lbl_custo.Text = "0,00";
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Location = new System.Drawing.Point(329, 41);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_marca.Size = new System.Drawing.Size(27, 13);
            this.lbl_marca.TabIndex = 0;
            this.lbl_marca.Text = "N/A";
            this.lbl_marca.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_preco
            // 
            this.lbl_preco.AutoSize = true;
            this.lbl_preco.Location = new System.Drawing.Point(75, 41);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(28, 13);
            this.lbl_preco.TabIndex = 0;
            this.lbl_preco.Text = "0,00";
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Location = new System.Drawing.Point(75, 66);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(27, 13);
            this.lbl_categoria.TabIndex = 0;
            this.lbl_categoria.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Custo:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 206);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fornecedor";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(413, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Telefone";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Nome";
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Location = new System.Drawing.Point(329, 91);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(27, 13);
            this.lbl_data.TabIndex = 0;
            this.lbl_data.Text = "N/A";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(166, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Data de entrada:";
            // 
            // lbl_peso
            // 
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Location = new System.Drawing.Point(329, 66);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(27, 13);
            this.lbl_peso.TabIndex = 0;
            this.lbl_peso.Text = "N/A";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(165, 66);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Peso:";
            // 
            // FormBusca_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 305);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txt_produto);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormBusca_produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Produto";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_produto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_fornecedor;
        private System.Windows.Forms.Label lbl_custo;
        private System.Windows.Forms.Label lbl_preco;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.Label lbl_quantidade;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_peso;
    }
}