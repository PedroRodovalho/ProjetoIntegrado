using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesktop
{
    interface PrioridadeRegraDeNegocioInterface
    {
        bool Executa(string regra, Venda venda, List<Item_Caixa> listaItens);

    }
}
