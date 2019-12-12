using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesktop
{
    public class Lancamento
    {
        private int id;
        private int cod_conta;
        
        private string data_lancamento;

        public int Id { get => id; set => id = value; }
        public int Cod_conta { get => cod_conta; set => cod_conta = value; }
        public string Data_lancamento { get => data_lancamento; set => data_lancamento = value; }
    }
}
