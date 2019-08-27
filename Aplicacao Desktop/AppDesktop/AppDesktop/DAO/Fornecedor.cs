using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesktop.DAO
{
    class Fornecedor
    {
        private int id;
        private int codigo;
        private string nome;
        private string tel;
        private string email;

        public int Id { get => id; set => id = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Email { get => email; set => email = value; }
    }
}
