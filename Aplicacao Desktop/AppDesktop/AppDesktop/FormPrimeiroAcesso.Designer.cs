namespace AppDesktop
{
    partial class FormPrimeiroAcesso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrimeiroAcesso));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.panel_etapa1 = new System.Windows.Forms.Panel();
            this.panel_topo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_fechar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ip_banco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nome_banco = new System.Windows.Forms.TextBox();
            this.txt_user_banco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_senha_banco = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_teste_db = new System.Windows.Forms.Button();
            this.lbl_status_conexao = new System.Windows.Forms.Label();
            this.link_show_error = new System.Windows.Forms.LinkLabel();
            this.lbl_errodb = new System.Windows.Forms.Label();
            this.panel_etapa2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.radio_permissao1 = new System.Windows.Forms.RadioButton();
            this.radio_permissao2 = new System.Windows.Forms.RadioButton();
            this.radio_permissao4 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.radio_permissao3 = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_criar_administrador = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel_etapa1.SuspendLayout();
            this.panel_topo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel_etapa2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(625, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(379, 174);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Iniciar";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // panel_etapa1
            // 
            this.panel_etapa1.Controls.Add(this.link_show_error);
            this.panel_etapa1.Controls.Add(this.lbl_errodb);
            this.panel_etapa1.Controls.Add(this.lbl_status_conexao);
            this.panel_etapa1.Controls.Add(this.groupBox1);
            this.panel_etapa1.Controls.Add(this.label5);
            this.panel_etapa1.Location = new System.Drawing.Point(73, 73);
            this.panel_etapa1.Name = "panel_etapa1";
            this.panel_etapa1.Size = new System.Drawing.Size(718, 488);
            this.panel_etapa1.TabIndex = 2;
            this.panel_etapa1.Visible = false;
            // 
            // panel_topo
            // 
            this.panel_topo.BackColor = System.Drawing.Color.Crimson;
            this.panel_topo.Controls.Add(this.lbl_fechar);
            this.panel_topo.Controls.Add(this.label2);
            this.panel_topo.Location = new System.Drawing.Point(-2, -1);
            this.panel_topo.Name = "panel_topo";
            this.panel_topo.Size = new System.Drawing.Size(841, 49);
            this.panel_topo.TabIndex = 3;
            this.panel_topo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_topo_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Assistente de Configuração";
            // 
            // lbl_fechar
            // 
            this.lbl_fechar.AutoSize = true;
            this.lbl_fechar.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lbl_fechar.Location = new System.Drawing.Point(794, 15);
            this.lbl_fechar.Name = "lbl_fechar";
            this.lbl_fechar.Size = new System.Drawing.Size(32, 24);
            this.lbl_fechar.TabIndex = 1;
            this.lbl_fechar.Text = "r";
            this.lbl_fechar.Click += new System.EventHandler(this.lbl_fechar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "IP Banco";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Etapa 1/5";
            // 
            // txt_ip_banco
            // 
            this.txt_ip_banco.Location = new System.Drawing.Point(77, 39);
            this.txt_ip_banco.Name = "txt_ip_banco";
            this.txt_ip_banco.Size = new System.Drawing.Size(100, 20);
            this.txt_ip_banco.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Banco de dados";
            // 
            // txt_nome_banco
            // 
            this.txt_nome_banco.Location = new System.Drawing.Point(111, 68);
            this.txt_nome_banco.Name = "txt_nome_banco";
            this.txt_nome_banco.Size = new System.Drawing.Size(100, 20);
            this.txt_nome_banco.TabIndex = 2;
            // 
            // txt_user_banco
            // 
            this.txt_user_banco.Location = new System.Drawing.Point(77, 93);
            this.txt_user_banco.Name = "txt_user_banco";
            this.txt_user_banco.Size = new System.Drawing.Size(100, 20);
            this.txt_user_banco.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Usuário";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Senha";
            // 
            // txt_senha_banco
            // 
            this.txt_senha_banco.Location = new System.Drawing.Point(64, 118);
            this.txt_senha_banco.Name = "txt_senha_banco";
            this.txt_senha_banco.Size = new System.Drawing.Size(100, 20);
            this.txt_senha_banco.TabIndex = 4;
            this.txt_senha_banco.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btn_teste_db);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_nome_banco);
            this.groupBox1.Controls.Add(this.txt_senha_banco);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_user_banco);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_ip_banco);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(32, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 177);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurações de Banco de Dados";
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(716, 567);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 4;
            this.btn_next.Text = "Avançar";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(635, 567);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(183, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Ex .: (127.0.0.1, localhost, 10.0.0.1)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(217, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Ex .: (aplicacao_db)";
            // 
            // btn_teste_db
            // 
            this.btn_teste_db.Location = new System.Drawing.Point(547, 148);
            this.btn_teste_db.Name = "btn_teste_db";
            this.btn_teste_db.Size = new System.Drawing.Size(104, 23);
            this.btn_teste_db.TabIndex = 5;
            this.btn_teste_db.Text = "Testar conexão";
            this.btn_teste_db.UseVisualStyleBackColor = true;
            this.btn_teste_db.Click += new System.EventHandler(this.btn_teste_db_Click);
            // 
            // lbl_status_conexao
            // 
            this.lbl_status_conexao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_status_conexao.Location = new System.Drawing.Point(175, 254);
            this.lbl_status_conexao.Name = "lbl_status_conexao";
            this.lbl_status_conexao.Size = new System.Drawing.Size(321, 22);
            this.lbl_status_conexao.TabIndex = 4;
            this.lbl_status_conexao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // link_show_error
            // 
            this.link_show_error.AutoSize = true;
            this.link_show_error.Location = new System.Drawing.Point(502, 255);
            this.link_show_error.Name = "link_show_error";
            this.link_show_error.Size = new System.Drawing.Size(125, 13);
            this.link_show_error.TabIndex = 5;
            this.link_show_error.TabStop = true;
            this.link_show_error.Text = "Exibir mensagem de erro.";
            this.link_show_error.Visible = false;
            this.link_show_error.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_show_error_LinkClicked);
            // 
            // lbl_errodb
            // 
            this.lbl_errodb.AutoSize = true;
            this.lbl_errodb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_errodb.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_errodb.Location = new System.Drawing.Point(29, 302);
            this.lbl_errodb.Name = "lbl_errodb";
            this.lbl_errodb.Size = new System.Drawing.Size(25, 13);
            this.lbl_errodb.TabIndex = 4;
            this.lbl_errodb.Text = "erro";
            this.lbl_errodb.Visible = false;
            // 
            // panel_etapa2
            // 
            this.panel_etapa2.Controls.Add(this.label18);
            this.panel_etapa2.Controls.Add(this.label16);
            this.panel_etapa2.Controls.Add(this.label14);
            this.panel_etapa2.Controls.Add(this.label12);
            this.panel_etapa2.Controls.Add(this.groupBox2);
            this.panel_etapa2.Controls.Add(this.label13);
            this.panel_etapa2.Controls.Add(this.label17);
            this.panel_etapa2.Controls.Add(this.label15);
            this.panel_etapa2.Controls.Add(this.label11);
            this.panel_etapa2.Controls.Add(this.radio_permissao4);
            this.panel_etapa2.Controls.Add(this.radio_permissao3);
            this.panel_etapa2.Controls.Add(this.radio_permissao2);
            this.panel_etapa2.Controls.Add(this.radio_permissao1);
            this.panel_etapa2.Controls.Add(this.label3);
            this.panel_etapa2.Location = new System.Drawing.Point(73, 73);
            this.panel_etapa2.Name = "panel_etapa2";
            this.panel_etapa2.Size = new System.Drawing.Size(718, 488);
            this.panel_etapa2.TabIndex = 5;
            this.panel_etapa2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Etapa 2/5";
            // 
            // radio_permissao1
            // 
            this.radio_permissao1.AutoSize = true;
            this.radio_permissao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_permissao1.Location = new System.Drawing.Point(32, 62);
            this.radio_permissao1.Name = "radio_permissao1";
            this.radio_permissao1.Size = new System.Drawing.Size(158, 17);
            this.radio_permissao1.TabIndex = 8;
            this.radio_permissao1.TabStop = true;
            this.radio_permissao1.Text = "Sistema de Permissões:";
            this.radio_permissao1.UseVisualStyleBackColor = true;
            // 
            // radio_permissao2
            // 
            this.radio_permissao2.AutoSize = true;
            this.radio_permissao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_permissao2.Location = new System.Drawing.Point(32, 101);
            this.radio_permissao2.Name = "radio_permissao2";
            this.radio_permissao2.Size = new System.Drawing.Size(242, 17);
            this.radio_permissao2.TabIndex = 8;
            this.radio_permissao2.TabStop = true;
            this.radio_permissao2.Text = "Um administrador e contas de usuário:";
            this.radio_permissao2.UseVisualStyleBackColor = true;
            // 
            // radio_permissao4
            // 
            this.radio_permissao4.AutoSize = true;
            this.radio_permissao4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_permissao4.Location = new System.Drawing.Point(32, 175);
            this.radio_permissao4.Name = "radio_permissao4";
            this.radio_permissao4.Size = new System.Drawing.Size(120, 17);
            this.radio_permissao4.TabIndex = 8;
            this.radio_permissao4.TabStop = true;
            this.radio_permissao4.Text = "Sem Permissões:";
            this.radio_permissao4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.btn_criar_administrador);
            this.groupBox2.Location = new System.Drawing.Point(32, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(663, 187);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuario Mestre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(187, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(537, 26);
            this.label11.TabIndex = 0;
            this.label11.Text = "Estabelece um perfil com Login e Senha para cada usuário do sistema. Cada perfil " +
    "possui um nivel de permissão \r\n\r\n";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(364, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "que estabelece qual área do sistema poderá ser acessada. (Recomendado)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(151, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(564, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Não é estabelecido nenhum Login e Senha e o acesso ao sistema é totalmente livre." +
    " (Recomendado apenas para uso";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(38, 195);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "de um único usuário).";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(272, 104);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(437, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Define um unico perfil de administrador que será solicitado em determinadas ações" +
    " do siste-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(38, 121);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(484, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "ma e possibilita a criação de contas de usuário para a utilização do sistema sem " +
    "o uso de permissões.";
            // 
            // radio_permissao3
            // 
            this.radio_permissao3.AutoSize = true;
            this.radio_permissao3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_permissao3.Location = new System.Drawing.Point(32, 137);
            this.radio_permissao3.Name = "radio_permissao3";
            this.radio_permissao3.Size = new System.Drawing.Size(257, 17);
            this.radio_permissao3.TabIndex = 8;
            this.radio_permissao3.TabStop = true;
            this.radio_permissao3.Text = "Um administrador sem contas de usuário:";
            this.radio_permissao3.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(281, 139);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(428, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Define um unico perfil de administrador que será solicitado em determinadas ações" +
    " do sis-";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(38, 157);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(401, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "tema. A o sistema poderá ser utilizado sem a necessidade de uma conta de usuário." +
    "";
            // 
            // btn_criar_administrador
            // 
            this.btn_criar_administrador.Location = new System.Drawing.Point(64, 127);
            this.btn_criar_administrador.Name = "btn_criar_administrador";
            this.btn_criar_administrador.Size = new System.Drawing.Size(75, 23);
            this.btn_criar_administrador.TabIndex = 0;
            this.btn_criar_administrador.Text = "Criar";
            this.btn_criar_administrador.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(28, 54);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Usuario";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(28, 90);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Senha";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(77, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // FormPrimeiroAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 621);
            this.Controls.Add(this.panel_etapa1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.panel_topo);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_etapa2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrimeiroAcesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assistente de configuração";
            this.Load += new System.EventHandler(this.FormPrimeiroAcesso_Load);
            this.panel_etapa1.ResumeLayout(false);
            this.panel_etapa1.PerformLayout();
            this.panel_topo.ResumeLayout(false);
            this.panel_topo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_etapa2.ResumeLayout(false);
            this.panel_etapa2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Panel panel_etapa1;
        private System.Windows.Forms.Panel panel_topo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_fechar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_nome_banco;
        private System.Windows.Forms.TextBox txt_senha_banco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_user_banco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ip_banco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_teste_db;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_status_conexao;
        private System.Windows.Forms.LinkLabel link_show_error;
        private System.Windows.Forms.Label lbl_errodb;
        private System.Windows.Forms.Panel panel_etapa2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton radio_permissao4;
        private System.Windows.Forms.RadioButton radio_permissao2;
        private System.Windows.Forms.RadioButton radio_permissao1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton radio_permissao3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btn_criar_administrador;
    }
}