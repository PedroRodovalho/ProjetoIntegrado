using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesktop.DAO
{
    class Cliente
    {
        private int id;
        private string nome;
        private string telefone;
        private string tipo_cliente;
        private string cpf;
        private string data_nascimento;
        private string data_cadastro;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Tipo_cliente { get => tipo_cliente; set => tipo_cliente = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Data_nascimento { get => data_nascimento; set => data_nascimento = value; }
        public string Data_cadastro { get => data_cadastro; set => data_cadastro = value; }
    }
}
