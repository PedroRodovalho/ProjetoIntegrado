using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesktop
{
    class Notificacao
    {
        private int id;
        private int id_remetente;
        private int id_destinatario;
        private string nomeRemetente;
        private string assunto;
        private string mensagem;
        private string tipo;
        private string status;

        public int Id { get => id; set => id = value; }
        public int Id_remetente { get => id_remetente; set => id_remetente = value; }
        public int Id_destinatario { get => id_destinatario; set => id_destinatario = value; }
        public string Assunto { get => assunto; set => assunto = value; }
        public string Mensagem { get => mensagem; set => mensagem = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Status { get => status; set => status = value; }
        public string NomeRemetente { get => nomeRemetente; set => nomeRemetente = value; }
    }
}
