using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesktop.DAO
{
    class Endereco
    {
        private int id;
        private int id_cliente;
        private string rua;
        private int numero;
        private string bairro;
        private string cep;
        private string cidade;
        private string uf;

        public int Id { get => id; set => id = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Rua { get => rua; set => rua = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Uf { get => uf; set => uf = value; }
    }
}
