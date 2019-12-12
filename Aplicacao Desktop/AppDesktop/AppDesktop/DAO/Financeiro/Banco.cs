using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesktop
{
    class Banco
    {
        private int id;
        private int cod;
        private string banco;

        public int Id { get => id; set => id = value; }
        public int Cod { get => cod; set => cod = value; }
        public string Nome { get => banco; set => banco = value; }

        public string ToString()
        {
            return Nome + "-" + Cod;
        }
    }

}
