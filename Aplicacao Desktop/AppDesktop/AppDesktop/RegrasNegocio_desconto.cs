using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesktop
{
    class RegrasNegocio_desconto
    {
        private int id;
        private int id_regra;
        private Boolean v_produto;
        private string condicao_valor_produto;
        private double valor_produto;
        private Boolean v_total;
        private string condicao_valor_total;
        private double valor_total;
         
        private double desconto;

        public int Id { get => id; set => id = value; }
        public int Id_regra { get => id_regra; set => id_regra = value; }
        public bool V_produto { get => v_produto; set => v_produto = value; }
        public string Condicao_valor_produto { get => condicao_valor_produto; set => condicao_valor_produto = value; }
        public double Valor_produto { get => valor_produto; set => valor_produto = value; }
        public bool V_total { get => v_total; set => v_total = value; }
        public string Condicao_valor_total { get => condicao_valor_total; set => condicao_valor_total = value; }
        public double Valor_total { get => valor_total; set => valor_total = value; }
       // public bool Q_produto { get => q_produto; set => q_produto = value; }
       // public string Condicao_quantidade_produto { get => condicao_quantidade_produto; set => condicao_quantidade_produto = value; }
       // public int Quantidade { get => quantidade; set => quantidade = value; }
        public double Desconto { get => desconto; set => desconto = value; }
    }
}
