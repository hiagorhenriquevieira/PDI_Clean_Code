using System;
using System.Collections.Generic;

namespace RefatorandoComCleanCode.Original.Funcoes
{
    public class ProcessadorPedidos
    {
        private List<Pedido> pedidos = new List<Pedido>();

        public void ProcessarPedido(long id, string nomeCliente, decimal valor, bool pago, string enderecoEntrega, int tipoEntrega)
        {
            if (string.IsNullOrEmpty(nomeCliente) || valor <= 0)
            {
                Console.WriteLine("Pedido inválido.");
                return;
            }

            Pedido pedido = new Pedido
            {
                Id = id,
                NomeCliente = nomeCliente,
                Valor = valor,
                Pago = pago,
                EnderecoEntrega = enderecoEntrega,
                TipoEntrega = tipoEntrega
            };

            pedidos.Add(pedido);

            if (pago)
            {
                Console.WriteLine("Pedido pago. Enviando para entrega...");
                if (tipoEntrega == 1)
                {
                    Console.WriteLine("Entrega expressa selecionada.");
                }
                else
                {
                    Console.WriteLine("Entrega padrão selecionada.");
                }
            }
            else
            {
                Console.WriteLine("Aguardando pagamento.");
            }
        }
    }
}
