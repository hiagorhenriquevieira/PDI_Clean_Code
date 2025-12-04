namespace RefatorandoComCleanCode.AplicacoesCleanCode.Comentarios
{
    public class Pedido
    {
        public Pedido(int idPedido, string nomeCliente, decimal valorVenda, bool pagamentoEfetivado)
        {
            IdPedido = idPedido;
            NomeCliente = nomeCliente;
            ValorVenda = valorVenda;
            PagamentoEfetivado = pagamentoEfetivado;
        }

        public int IdPedido { get; private set; }
        public string NomeCliente { get; private set; }
        public decimal ValorVenda { get; private set; }
        public bool PagamentoEfetivado { get; private set; }

    }
}
