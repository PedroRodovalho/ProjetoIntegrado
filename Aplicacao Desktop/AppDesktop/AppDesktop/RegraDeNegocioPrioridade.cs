using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesktop
{
    class RegraDeNegocioPrioridade
    {
        private int id;
        private int id_regra;
        private int regra_quantidade;
        private int regra_valor_total;
        private int regra_valor_produto;

        public int Id { get => id; set => id = value; }
        public int Id_regra { get => id_regra; set => id_regra = value; }
        public int Regra_quantidade { get => regra_quantidade; set => regra_quantidade = value; }
        public int Regra_valor_total { get => regra_valor_total; set => regra_valor_total = value; }
        public int Regra_valor_produto { get => regra_valor_produto; set => regra_valor_produto = value; }
    }
}
