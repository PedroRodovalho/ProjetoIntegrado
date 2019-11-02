using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesktop
{
    class RegrasNegocio_acrescimo
    {
        private int id;
        private int id_regra;
        private double acrescimo_parcela;
        private Boolean por_parcela;
        

        public int Id_regra { get => id_regra; set => id_regra = value; }
        public double Acrescimo_parcela { get => acrescimo_parcela; set => acrescimo_parcela = value; }
        public bool Por_parcela { get => por_parcela; set => por_parcela = value; }
        
    }
}
