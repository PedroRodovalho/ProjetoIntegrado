using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesktop
{
    public class Permissao
    {
        private int id;
        private string nome;
        private int insert;
        private int delete;
        private int adm;
        private int update;
        private int select;

        public int Insert { get => insert; set => insert = value; }
        public int Delete { get => delete; set => delete = value; }
        public int Adm { get => adm; set => adm = value; }
        public int Update { get => update; set => update = value; }
        public int Select { get => select; set => select = value; }
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}
