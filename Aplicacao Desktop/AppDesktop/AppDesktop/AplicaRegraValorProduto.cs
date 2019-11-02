using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDesktop
{
    class AplicaRegraValorProduto
    {
        public AplicaRegraValorProduto()
        {

        
        MessageBox.Show("APLICANDO REGRA VALOR PRODUTO");
        }

        public string GetRegra(List<Item_Caixa> listt)
        {
            string nome = listt[0].Produto;
            return nome;
        }
    }
}
