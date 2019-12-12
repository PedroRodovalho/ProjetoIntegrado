using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesktop.BEATMAIL
{
    public class Mensagem
    {
        private int id;
        private string remetente;
        private string destinatario;
        private string assunto;
        private string texto;
        private string data_envio;
        private string hora_envio;

        public int Id { get => id; set => id = value; }
        public string Remetente { get => remetente; set => remetente = value; }
        public string Destinatario { get => destinatario; set => destinatario = value; }
        public string Assunto { get => assunto; set => assunto = value; }
        public string Texto { get => texto; set => texto = value; }
        public string Data_envio { get => data_envio; set => data_envio = value; }
        public string Hora_envio { get => hora_envio; set => hora_envio = value; }

    }
}
