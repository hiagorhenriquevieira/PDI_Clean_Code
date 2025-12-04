using System;
using System.Collections.Generic;

namespace RefatorandoComCleanCode.AplicacoesCleanCode.Comentarios
{
    public class GerenciadorPedidos
    {
        private List<Pedido> _pedidos = new();

        public void AdicionarPedido(int idPedido, string nomeCliente, decimal valorVenda, bool pagamentoEfetivado)
        {
            Pedido novoPedido = new(idPedido, nomeCliente, valorVenda,  pagamentoEfetivado);

            _pedidos.Add(novoPedido);
        }

        public void VerificarPagamento(int idPedidoSelecionado)
        {
            foreach (var pedido in _pedidos)
            {
                if (pedido.IdPedido == idPedidoSelecionado)
                {
                    if (pedido.PagamentoEfetivado)
                    {
                        Console.WriteLine("Pedido pago.");
                    }
                    else
                    {
                        Console.WriteLine("Pedido não pago.");
                    }
                }
            }
        }
    }
}
