using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesktop
{
    public class Favorecido
    {
        private int id;
        private string nome;
        private string cpf_cpnj;
        private int id_banco;
        private string agencia;
        private string conta;
        private string classificacao;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf_cpnj { get => cpf_cpnj; set => cpf_cpnj = value; }
        public int Id_banco { get => id_banco; set => id_banco = value; }
        public string Agencia { get => agencia; set => agencia = value; }
        public string Conta { get => conta; set => conta = value; }
        public string Classificacao { get => classificacao; set => classificacao = value; }
    }
}
