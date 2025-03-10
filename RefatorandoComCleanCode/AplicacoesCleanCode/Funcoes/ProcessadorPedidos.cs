﻿using System;

namespace RefatorandoComCleanCode.AplicacoesCleanCode.Funcoes
{
    public class ProcessadorPedidos
    {
        public void ProcessarPedido(Pedido pedidoCompra)
        {
            if (!pedidoCompra.Validar())
            {
                Console.WriteLine($"Não é possível processar o pedido {pedidoCompra.Id}. Verifique todos os campos e tente novamente.");
                return;
            }

            var retornoPedido = RealizarEnvioPedido(pedidoCompra);

            if (!retornoPedido)
            {
                Console.WriteLine("Aguardando pagamento.");
                return;
            }

                Console.WriteLine($"O pedido {pedidoCompra.Id} foi realizado.");

                RealizarDespacho(pedidoCompra);
        }

        private void RealizarDespacho(Pedido pedidoCompra)
        {
            switch (pedidoCompra.TipoEntrega)
            {
                case ECategoriaEntrega.Expresso:
                    //DespachoEntregaExpressa
                    Console.WriteLine("Entrega expressa selecionada.");
                    break;

                default:
                    //DespachoEntregaPadrao
                    Console.WriteLine("Entrega padrão selecionada.");
                    break;
            }
        }

        private bool RealizarEnvioPedido(Pedido pedidoCompra)
        {
            //-- envio do pedido
           return pedidoCompra.Pago;
        }
    }
}
