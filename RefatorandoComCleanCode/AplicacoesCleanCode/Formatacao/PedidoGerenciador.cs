using System;
using System.Collections.Generic;
using System.Linq;

namespace RefatorandoComCleanCode.AplicacoesCleanCode.Formatacao
{
    public class PedidoGerenciador
    {
        private List<Pedido> _pedidos = new List<Pedido>();

        public void AdicionarPedido(int id, string cliente, decimal valor, bool pago)
        {
            Pedido novoPedido = new(id, cliente, valor, pago);

            _pedidos.Add(novoPedido);
        }

        public void ExibirStatusPedido(int idPedidoSelecionado)
        {
            var pediddo = _pedidos.FirstOrDefault(pedido => pedido.Id == idPedidoSelecionado);

            if (pediddo is null)
            {
                Console.WriteLine("Pedido não encontrado");
                return;
            }

            var status = pediddo.Pago ? "Pago" : "Não Pago";

            Console.WriteLine($"Status do pedido {pediddo.Id}: {status}");

        }
    }
}
