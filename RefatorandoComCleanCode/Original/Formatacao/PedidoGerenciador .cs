using System;
using System.Collections.Generic;

namespace RefatorandoComCleanCode.Original.Formatacao
{
    public class PedidoGerenciador
    {
        private List<Pedido> peds = new List<Pedido>(); public void AdicionarPedido(int id, string cliente, decimal valor, bool pago) { Pedido p = new Pedido(); p.Id = id; p.NomeCliente = cliente; p.Valor = valor; p.Pago = pago; peds.Add(p); }
        public void StatusPedido(int id) { foreach (var p in peds) { if (p.Id == id) { if (p.Pago) { Console.WriteLine("Pago"); } else { Console.WriteLine("Não Pago"); } } } }
    }
}
