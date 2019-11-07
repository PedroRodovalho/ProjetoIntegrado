using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesktop
{
    class RegrasNegocio
    {


        private int id;
        private string nome;
        private string tipo_venda;
        private string tipo;
        private int parcela_min;
        private int parcela_max;
        private string ativa;


        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Parcela_min { get => parcela_min; set => parcela_min = value; }
        public int Parcela_max { get => parcela_max; set => parcela_max = value; }
        public string Tipo_venda { get => tipo_venda; set => tipo_venda = value; }
        public string Ativa { get => ativa; set => ativa = value; }
    }
}
