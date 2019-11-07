using AppDesktop.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDesktop
{
    public partial class FormRecuperaSenha : Form
    {
        public FormRecuperaSenha()
        {
            InitializeComponent();
        }
      
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        Usuario usuario;
        string senha = "";
        private void btn_enviar_Click(object sender, EventArgs e)
        {
            groupBox_mensagem.Visible = false;
            string login = txt_usuario.Text;
            usuario = usuarioDAO.BuscaUsuario(login);
            senha = usuario.Senha;
            lblInfo.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            MessageBox.Show(senha);
            if (senha == null)
            {
                groupBox_mensagem.Visible = true; 
                lblInfo.AutoSize = true;
                lblInfo.ForeColor = Color.Red;
                
                lblInfo.Text = "● Usuário informado não está cadastra-\ndo!";
            }
            else
            {
                groupBox_mensagem.Visible = true;
                backgroundWorker1.RunWorkerAsync();
                lblInfo.ForeColor = Color.Blue;
                lblInfo.Text = "● Só um minutinho, já estamos enviando um \nemail com a sua nova senha :)!";
            }
            //MailMessage mail = new MailMessage();
            //System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
            //client.Host = "smtp.gmail.com";
            //client.EnableSsl = true;
            //client.Credentials = new System.Net.NetworkCredential("bruniin.cfs@gmail.com", "noobzim42");
            //mail = new MailMessage();
            //mail.Sender = new System.Net.Mail.MailAddress("bruniin.cfs@gmail.com", "Bruno");
            //mail.From = new MailAddress("bruniin.cfs@gmail.com", "BEAT SYSTEM");
            //mail.To.Add(new MailAddress("bc.fsalomao@gmail.com", "RECEBEDOR"));
            //mail.Subject = "Recuperação de Senha";
            //string message = "Olá, sua senha é: " + senha;

            //mail.Body = " Mensagem do site:<br/> Nome <br/> Mensagem : " + message;
            //mail.IsBodyHtml = true;
            //mail.Priority = MailPriority.High;


            //try
            //{

            //    client.Send(mail);
            //}
            //catch (System.Exception erro)
            //{
            //    MessageBox.Show(erro.Message);
            //}
            //finally
            //{
            //    mail = null;
            //}

           


        }
        static void Enviar()
        {
            
        }

        private void FormRecuperaSenha_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            MailMessage mail = new MailMessage();
            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("bruniin.cfs@gmail.com", "noobzim42");
            mail = new MailMessage();
            mail.Sender = new System.Net.Mail.MailAddress("bruniin.cfs@gmail.com", "Bruno");
            mail.From = new MailAddress("bruniin.cfs@gmail.com", "BEAT SYSTEM - Gestor de contas");
            mail.To.Add(new MailAddress("bc.fsalomao@gmail.com", "RECEBEDOR"));
            mail.Subject = "Recuperação de Senha";
            string message = "Olá, sua senha é: " + senha;
            MessageBox.Show(senha);

            mail.Body = " Mensagem do site:<br/> Nome <br/> Mensagem : " + message;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;

          
            try
            {

                client.Send(mail);
                
            }
            catch (System.Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                mail = null;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblInfo.Text = "ENVIANDO EMAIL";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblInfo.ForeColor = Color.Green;
            lblInfo.Text = "● PRONTINHO! E-Mail enviado com sucesso, agora é só acessar seu e-mail, e pegar sua nova senha!";
            groupBox_redefinirSenha.Visible = true;
            groupBox2.Enabled = false;
        }

        private void btn_concluir_Click(object sender, EventArgs e)
        {
            string senha_atual, nova_senha, confirmar_senha;
            senha_atual = txt_senha_atual.Text;
            if(senha_atual.Equals(senha))
            {
                nova_senha = txt_nova_senha.Text;
                confirmar_senha = txt_confirmar_senha.Text;
                if (nova_senha.Equals(confirmar_senha)) usuarioDAO.RedefineSenha(nova_senha,usuario.Id);
                else MessageBox.Show("Confirmação de senha invalida");
            }
            else
            {
                MessageBox.Show("Senha incorreta!");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
