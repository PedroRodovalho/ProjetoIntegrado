using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesktop
{

    public class Usuario
    {

        private int id;
        private string login;
        private string senha;
        private string email;
        public int Id { get => id; set => id = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Login { get => login; set => login = value; }
        
        public string Email { get => email; set => email = value; }
    }
}