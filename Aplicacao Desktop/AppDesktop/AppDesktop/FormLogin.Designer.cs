﻿namespace AppDesktop
{
    partial class FormLogin
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel_nova_senha = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_nova_senha = new System.Windows.Forms.TextBox();
            this.btn_enviar_nova_senha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_confirmar_senha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.panel_nova_senha.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(151, 120);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(108, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Esqueci minha senha";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btn_entrar
            // 
            this.btn_entrar.Location = new System.Drawing.Point(142, 151);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(75, 28);
            this.btn_entrar.TabIndex = 5;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_usuario.Location = new System.Drawing.Point(64, 74);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(43, 13);
            this.lbl_usuario.TabIndex = 2;
            this.lbl_usuario.Text = "Usuario";
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_usuario.Location = new System.Drawing.Point(116, 71);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(143, 20);
            this.txt_usuario.TabIndex = 3;
            this.txt_usuario.TextChanged += new System.EventHandler(this.txt_usuario_TextChanged);
            // 
            // txt_senha
            // 
            this.txt_senha.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_senha.Location = new System.Drawing.Point(116, 97);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(143, 20);
            this.txt_senha.TabIndex = 4;
            this.txt_senha.UseSystemPasswordChar = true;
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_senha.Location = new System.Drawing.Point(69, 100);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(38, 13);
            this.lbl_senha.TabIndex = 2;
            this.lbl_senha.Text = "Senha";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.LightGray;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 282);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(374, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // panel_nova_senha
            // 
            this.panel_nova_senha.BackColor = System.Drawing.SystemColors.Control;
            this.panel_nova_senha.Controls.Add(this.groupBox1);
            this.panel_nova_senha.Location = new System.Drawing.Point(12, 12);
            this.panel_nova_senha.Name = "panel_nova_senha";
            this.panel_nova_senha.Size = new System.Drawing.Size(330, 201);
            this.panel_nova_senha.TabIndex = 7;
            this.panel_nova_senha.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_nova_senha);
            this.groupBox1.Controls.Add(this.btn_enviar_nova_senha);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_confirmar_senha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(20, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 135);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Redefinir Senha";
            // 
            // txt_nova_senha
            // 
            this.txt_nova_senha.Location = new System.Drawing.Point(103, 19);
            this.txt_nova_senha.Name = "txt_nova_senha";
            this.txt_nova_senha.Size = new System.Drawing.Size(176, 20);
            this.txt_nova_senha.TabIndex = 1;
            this.txt_nova_senha.UseSystemPasswordChar = true;
            // 
            // btn_enviar_nova_senha
            // 
            this.btn_enviar_nova_senha.Location = new System.Drawing.Point(17, 68);
            this.btn_enviar_nova_senha.Name = "btn_enviar_nova_senha";
            this.btn_enviar_nova_senha.Size = new System.Drawing.Size(262, 45);
            this.btn_enviar_nova_senha.TabIndex = 2;
            this.btn_enviar_nova_senha.Text = "Enviar";
            this.btn_enviar_nova_senha.UseVisualStyleBackColor = true;
            this.btn_enviar_nova_senha.Click += new System.EventHandler(this.btn_enviar_nova_senha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Senha";
            // 
            // txt_confirmar_senha
            // 
            this.txt_confirmar_senha.Location = new System.Drawing.Point(103, 42);
            this.txt_confirmar_senha.Name = "txt_confirmar_senha";
            this.txt_confirmar_senha.Size = new System.Drawing.Size(176, 20);
            this.txt_confirmar_senha.TabIndex = 1;
            this.txt_confirmar_senha.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Confirmar senha";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(374, 304);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel_nova_senha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrar";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel_nova_senha.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel_nova_senha;
        private System.Windows.Forms.Button btn_enviar_nova_senha;
        private System.Windows.Forms.TextBox txt_confirmar_senha;
        private System.Windows.Forms.TextBox txt_nova_senha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}