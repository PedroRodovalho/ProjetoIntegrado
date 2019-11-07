namespace AppDesktop
{
    public class Pagamento
    {
        private int id;
        private int id_venda;
        private double valor;
        private string forma_pagamento;
        private int quantidade_parcelas;

        public int Id { get => id; set => id = value; }
        public int Id_venda { get => id_venda; set => id_venda = value; }
        public double Valor { get => valor; set => valor = value; }
        public string Forma_pagamento { get => forma_pagamento; set => forma_pagamento = value; }
        public int Quantidade_parcelas { get => quantidade_parcelas; set => quantidade_parcelas = value; }
    }
}