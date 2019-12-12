namespace AppDesktop
{
    internal class PerfilAcesso
    {
        private int id;
        private string nomeAcesso;
        private string descricao;
        private string status;

        public int Id { get => id; set => id = value; }
        public string NomeAcesso { get => nomeAcesso; set => nomeAcesso = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Status { get => status; set => status = value; }
    }
}