using AppDesktop.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDesktop
{
    public partial class FormLogin : Form
    {
        Boolean conectado = false;

        FormHome contexto;
        public FormLogin(FormHome contexto)
        {
            this.contexto = contexto;
            InitializeComponent();

        }
        public void ArredondaFormulario()
        {
            GraphicsPath PastaGrafica = new GraphicsPath();
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, this.Size.Width, this.Size.Height));
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(this.Width - 12, 1, 12, 13));
            PastaGrafica.AddPie(this.Width - 24, 1, 24, 26, 270, 90);
            PastaGrafica.SetMarkers();
            this.Region = new Region(PastaGrafica);
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {

           // ArredondaFormulario();
            Config config_banco = new Config();
            string con = config_banco.getConexao();

            conectado = config_banco.verificaConexao();

            if (conectado)
            {
                toolStripStatusLabel1.Text = "CONECTADO";
                toolStripStatusLabel1.ForeColor = Color.Green;
            }
            else
            {
                toolStripStatusLabel1.Text = "DESCONECTADO";
                toolStripStatusLabel1.ForeColor = Color.Red;
            }
        }
        UsuarioDAO userDAO = new UsuarioDAO();
        Usuario user = new Usuario();
        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if (conectado)
            {

                Usuario usuario = new Usuario();
                usuario.Login = txt_usuario.Text;
                usuario.Senha = txt_senha.Text;

                
                user = userDAO.validaLogin(usuario);
                if (user == null)
                {
                    lbl_mensagem.Text = "Usuário ou senha incorretos.";
                    lbl_mensagem.Visible = true;
                }
                else if(user.Ativo == 0){
                    MessageBox.Show("Esta conta se encontrada inativada, por favor, entre em contato com o admnistrador do sistema!");
                    lbl_mensagem.Text = "Usuario inativo";
                    lbl_mensagem.Visible = true;
                }
                else
                {
                    
                    bool primeiro_login = userDAO.VerificaPrimeiroLogin(user);
                    if (primeiro_login)
                    {
                        
                        FormPrimeiroAcessoUsuario formPrimeiroAcessoUsuario = new FormPrimeiroAcessoUsuario(user);
                        DialogResult result = formPrimeiroAcessoUsuario.ShowDialog(); 
                        if(result == DialogResult.OK)
                        {
                            
                            CriarNovaSenha();

                        }
                    }
                    else
                    {
                        contexto.usuario = user;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Falha de conexão");
            }



        }
        public void CriarNovaSenha()
        {
            panel_login.Visible = false;
            panel_nova_senha.Visible = true;
            

        }
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRecuperaSenha formRecuperar_senha = new FormRecuperaSenha();
            formRecuperar_senha.ShowDialog();

        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        public static string alfanumericoAleatorio(int tamanho)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvxyz0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, tamanho)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            return result;
        }

        private void btn_enviar_nova_senha_Click(object sender, EventArgs e)
        {
            string nova_senha = txt_nova_senha.Text;
            string senha_confirmacao = txt_confirmar_senha.Text;

            if (nova_senha.Equals(senha_confirmacao))
            {
                userDAO.RedefineSenha(nova_senha, user.Id);
                userDAO.RemovePrimeiroAcesso(user);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Senhas não coincindem.");
            }
        }

   
    }
}
