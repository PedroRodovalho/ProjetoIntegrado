using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesktop
{
    class ItemVenda
    {
        private int id;
        private int id_venda;
        private int id_produto;
        private string item;
        private double preco;
        private int quantidade;
        private int id_promocao;

        public int Id { get => id; set => id = value; }
        public int Id_venda { get => id_venda; set => id_venda = value; }
        public int Id_produto { get => id_produto; set => id_produto = value; }
        public string Item { get => item; set => item = value; }
        public double Preco { get => preco; set => preco = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public int Id_promocao { get => id_promocao; set => id_promocao = value; }
    }
}
