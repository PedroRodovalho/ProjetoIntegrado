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
        private string nome;
        private string tel;
        private string email;
        private string cnpj;

        public int Id { get => id; set => id = value; }
        
        public string Nome { get => nome; set => nome = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Email { get => email; set => email = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
    }
}
