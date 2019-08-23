using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
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

        private void button1_Click(object sender, EventArgs e)
        {
            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("bruniin.cfs@gmail.com", "noobzim42");
            MailMessage mail = new MailMessage();
            mail.Sender = new System.Net.Mail.MailAddress("bruniin.cfs@gmail.com", "Bruno");
            mail.From = new MailAddress("bruniin.cfs@gmail.com", "ENVIADOR");
            mail.To.Add(new MailAddress("bc.fsalomao@gmail.com", "RECEBEDOR"));
            mail.Subject = "Contato";
            string message = "teste";
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
    }
}
