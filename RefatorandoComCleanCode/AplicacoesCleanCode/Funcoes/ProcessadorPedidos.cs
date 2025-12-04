using System;

namespace RefatorandoComCleanCode.AplicacoesCleanCode.Funcoes
{
    public class ProcessadorPedidos
    {
        public void ProcessarPedido(Pedido pedidoCompra)
        {
            var retornoPedido = RealizarEnvioPedido(pedidoCompra);

            if (!retornoPedido)
            {
                Console.WriteLine("Aguardando pagamento.");
                return;
            }

            Console.WriteLine($"O pedido {pedidoCompra.Id} foi realizado.");

            RealizarDespacho(pedidoCompra);
        }

        private static void RealizarDespacho(Pedido pedidoCompra)
        {
            switch (pedidoCompra.TipoEntrega)
            {
                case ECategoriaEntrega.Expresso:
                    Console.WriteLine("Entrega expressa selecionada.");
                    break;

                default:
                    Console.WriteLine("Entrega padrão selecionada.");
                    break;
            }
        }

        private static bool RealizarEnvioPedido(Pedido pedidoCompra)
        {
            return pedidoCompra.Pago;
        }
    }
}