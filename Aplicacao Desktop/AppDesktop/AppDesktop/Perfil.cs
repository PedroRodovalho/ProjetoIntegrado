namespace AppDesktop
{
    public class Perfil
    {
        private int id;
        private int id_usuario;
        private string nome;
        private string telefone;
        private int id_permissao;
        private string data_nascimento;
        private string data_cadastro;
        private int ativo;

        public int Id { get => id; set => id = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Data_nascimento { get => data_nascimento; set => data_nascimento = value; }
        public string Data_cadastro { get => data_cadastro; set => data_cadastro = value; }
        public int Id_permissao { get => id_permissao; set => id_permissao = value; }
        public int Ativo { get => ativo; set => ativo = value; }
    }
}