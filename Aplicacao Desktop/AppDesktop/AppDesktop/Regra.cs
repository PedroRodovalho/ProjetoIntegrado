using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesktop
{
    class Regra
    {
        private int id;
        private int id_regra;
        private string atribuicao;
        private string condicao;
        private double parametro;
        private double desconto;

        public int Id { get => id; set => id = value; }
        public int Id_regra { get => id_regra; set => id_regra = value; }
        public string Condicao { get => condicao; set => condicao = value; }
        public double Parametro { get => parametro; set => parametro = value; }
        public double Desconto { get => desconto; set => desconto = value; }
        public string Atribuicao { get => atribuicao; set => atribuicao = value; }
    }
}
