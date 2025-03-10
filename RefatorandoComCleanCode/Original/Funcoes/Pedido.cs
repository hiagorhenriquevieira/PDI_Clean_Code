namespace RefatorandoComCleanCode.Original.Funcoes
{
    public class Pedido
    {
        public long Id { get; set; }
        public string NomeCliente { get; set; }
        public decimal Valor { get; set; }
        public bool Pago { get; set; }
        public string EnderecoEntrega{ get; set; }
        public int TipoEntrega{ get; set; }
    }
}
