using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AppDesktop
{
    class EnviarEmail
    {
        public EnviarEmail()
        {

        }

        public bool Envia(string remetente,string destinatario, string mensagem,string assunto)
        {
            MailMessage mail = new MailMessage();
            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("bruniin.cfs@gmail.com", "noobzim42");
            mail = new MailMessage();
            mail.Sender = new System.Net.Mail.MailAddress("bruniin.cfs@gmail.com", "Bruno");
            mail.From = new MailAddress("bruniin.cfs@gmail.com", remetente);
            mail.To.Add(new MailAddress(destinatario, "RECEBEDOR"));
            mail.Subject = "Recuperação de Senha";
            string message = mensagem;
            

            mail.Body = " Mensagem do site:<br/> Nome <br/> Mensagem : " + message;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;

            
            try
            {

                client.Send(mail);
                return true;
            }
            catch (System.Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                mail = null;
            }

            return false;
        }

    }
}
