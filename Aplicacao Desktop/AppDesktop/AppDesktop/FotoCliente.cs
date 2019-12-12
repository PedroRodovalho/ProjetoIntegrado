namespace AppDesktop
{
    internal class FotoCliente
    {
        private int id;
        private int id_cliente;
        private string caminho_foto;
        private string nome_foto;

        public int Id { get => id; set => id = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Caminho_foto { get => caminho_foto; set => caminho_foto = value; }
        public string Nome_foto { get => nome_foto; set => nome_foto = value; }
    }
}