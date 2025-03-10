using System;
using System.Collections.Generic;

namespace RefatorandoComCleanCode.AplicacoesCleanCode.Comentarios
{
    public class GerenciadorPedidos
    {
        private List<Pedido> _pedidos = new List<Pedido>();

        public void AdicionarPedido(int id, string cliente, decimal valor, bool pago)
        {
            Pedido novoPedido = new(id,cliente,valor,pago);

            _pedidos.Add(novoPedido);
        }

        public void VerificarPagamento(int idPedidoSelecionado)
        {
            foreach (var pedido in _pedidos)
            {
                if (pedido.Id == idPedidoSelecionado)
                {
                    if (pedido.Pago)
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
