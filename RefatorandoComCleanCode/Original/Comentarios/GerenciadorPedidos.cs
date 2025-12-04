using System;
using System.Collections.Generic;

namespace RefatorandoComCleanCode.Original.Comentarios
{
    public class GerenciadorPedidos
    {
        // Lista para armazenar os pedidos
        private List<Pedido> pedidos = new List<Pedido>();

        // Método que adiciona um novo pedido à lista
        public void AddPedido(int id, string cliente, decimal valor, bool pago)
        {
            // Cria um novo pedido
            Pedido p = new Pedido();
            p.Id = id; // Definindo o ID do pedido
            p.Cliente = cliente; // Definindo o nome do cliente
            p.Valor = valor; // Definindo o valor do pedido
            p.Pago = pago; // Definindo se o pedido foi pago

            // Adiciona o pedido à lista de pedidos
            pedidos.Add(p);
        }

        // Método que verifica se o pedido foi pago
        public void Pagamento(int id)
        {
            foreach (var pedido in pedidos)
            {
                // Verifica se o ID do pedido é igual ao informado
                if (pedido.Id == id)
                {
                    if (pedido.Pago)
                    {
                        Console.WriteLine("Pedido pago."); // Informa que o pedido foi pago
                    }
                    else
                    {
                        Console.WriteLine("Pedido não pago."); // Informa que o pedido não foi pago
                    }
                }
            }
        }
    }
}
