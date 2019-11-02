using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesktop
{
    class RegraBy_valorTotal
    {
        private int id;
        private int id_regra;
        private int prioridade;
        private string condicao;
        private double valor;
        private double desconto;

        public int Id { get => id; set => id = value; }
        public int Id_regra { get => id_regra; set => id_regra = value; }
        public int Prioridade { get => prioridade; set => prioridade = value; }
        public string Condicao { get => condicao; set => condicao = value; }
        public double Valor { get => valor; set => valor = value; }
        public double Desconto { get => desconto; set => desconto = value; }
    }
}
