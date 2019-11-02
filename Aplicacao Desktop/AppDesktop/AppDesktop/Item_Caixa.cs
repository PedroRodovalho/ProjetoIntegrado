using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesktop
{
    class Item_Caixa
    {
        private int id;
        private string produto;
        private double preco;
        private int quantidade;

        public int Id { get => id; set => id = value; }
        public string Produto { get => produto; set => produto = value; }
        public double Preco { get => preco; set => preco = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
    }
}
