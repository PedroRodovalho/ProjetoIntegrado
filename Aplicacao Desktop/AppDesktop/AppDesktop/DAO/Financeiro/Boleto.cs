using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesktop
{
    class Boleto
    {
        private int id_conta;
        private string cod_barras;

        public int Id_conta { get => id_conta; set => id_conta = value; }
        public string Cod_barras { get => cod_barras; set => cod_barras = value; }
    }
}
