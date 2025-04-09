namespace RefatorandoComCleanCode.AplicacoesCleanCode.Formatacao
{
    public class Pedido
    {
        public Pedido(int id, string cliente, decimal valor, bool pago)
        {
            Id = id;
            NomeCliente = cliente;
            Valor = valor;
            Pago = pago;
        }

        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public decimal Valor { get; set; }
        public bool Pago { get; set; }
    }
}
