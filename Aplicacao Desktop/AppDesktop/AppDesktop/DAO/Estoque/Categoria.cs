using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesktop.DAO
{
    class Categoria

    {
        private int id;
        private string categoria;

        public int Id { get => id; set => id = value; }
        
        public string Nome { get => categoria; set => categoria = value; }
    }
}
