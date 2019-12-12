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
        private string nome;
        private string cargo;
        private int id_permissao;
        private string email;
        private int ativo;
        public int Id { get => id; set => id = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Login { get => login; set => login = value; }
        
        public string Email { get => email; set => email = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public int Id_permissao { get => id_permissao; set => id_permissao = value; }
        public int Ativo { get => ativo; set => ativo = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}