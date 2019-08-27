namespace AppDesktop.DAO
{
    public class Estoque
    {
        private int id;
        private int cod;
        private string produto;
        private int quantidade;
        private double custo;
        private double preco;
        private string data;
        private int fornecedor;
        private double peso;
        private string categoria;
        private string marca;
        private string descricao;

        public int Id { get => id; set => id = value; }
        public int Cod { get => cod; set => cod = value; }
        public string Produto { get => produto; set => produto = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public double Custo { get => custo; set => custo = value; }
        public double Preco { get => preco; set => preco = value; }
        public string Data { get => data; set => data = value; }
        public int Fornecedor { get => fornecedor; set => fornecedor = value; }
        public double Peso { get => peso; set => peso = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Descricao { get => descricao; set => descricao = value; }
    }
}