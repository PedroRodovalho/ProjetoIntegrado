using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesktop
{
    class Conta
    {
        private int id;
        private int cod;
        private int id_favorecido;
        private int id_banco;
        private int id_devedor;
        private string forma_pagamento;
        private double valor;
        private string data_criacao;
        private string hora_criacao;
        private string data_vencimento;
        private string tipo;
        private string sub_tipo;
        private string descricao;
        private string tipo_debito;
        private string status;

        public int Id { get => id; set => id = value; }
        public int Id_favorecido { get => id_favorecido; set => id_favorecido = value; }
        public int Id_banco { get => id_banco; set => id_banco = value; }
        public int Id_devedor { get => id_devedor; set => id_devedor = value; }
        public string Forma_pagamento { get => forma_pagamento; set => forma_pagamento = value; }
        public double Valor { get => valor; set => valor = value; }
        public string Data_criacao { get => data_criacao; set => data_criacao = value; }
        public string Hora_criacao { get => hora_criacao; set => hora_criacao = value; }
        public string Data_vencimento { get => data_vencimento; set => data_vencimento = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Sub_tipo { get => sub_tipo; set => sub_tipo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Tipo_debito { get => tipo_debito; set => tipo_debito = value; }
        public int Cod { get => cod; set => cod = value; }
        public string Status { get => status; set => status = value; }
    }
}
