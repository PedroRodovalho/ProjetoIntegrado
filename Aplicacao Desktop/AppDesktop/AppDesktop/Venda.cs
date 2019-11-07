namespace AppDesktop
{
    public class Venda
    {
        private int id;
        
        private string data;
        private double valor_total;
        private double valor_final;
        private double desconto;
        private int quantidade_itens;
        private int regra_aplicada;

        public int Id { get => id; set => id = value; }
  
        public string Data { get => data; set => data = value; }
        public double Valor_total { get => valor_total; set => valor_total = value; }
        public double Valor_final { get => valor_final; set => valor_final = value; }
        public int Quantidade_itens { get => quantidade_itens; set => quantidade_itens = value; }
        public int Regra_aplicada { get => regra_aplicada; set => regra_aplicada = value; }
        public double Desconto { get => desconto; set => desconto = value; }
    }
}