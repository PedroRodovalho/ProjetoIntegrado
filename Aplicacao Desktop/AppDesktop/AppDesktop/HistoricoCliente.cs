namespace AppDesktop
{
    internal class HistoricoCliente
    {
        private int id_cliente;
        private int id_venda;
        private double valor_final;
        private string data_venda;

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Id_venda { get => id_venda; set => id_venda = value; }
        public double Valor_final { get => valor_final; set => valor_final = value; }
        public string Data_venda { get => data_venda; set => data_venda = value; }
    }
}