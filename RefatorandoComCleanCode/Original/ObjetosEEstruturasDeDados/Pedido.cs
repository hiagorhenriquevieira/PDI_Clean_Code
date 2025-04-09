using System;

namespace RefatorandoComCleanCode.Original.ObjetosEEstruturasDeDados
{
    public class Pedido
    {
        public int Id;
        public string Cliente;
        public decimal Valor;
        public bool Pago;
    }

    public class ProcessadorPedidos
    {
        public void Processar(Pedido pedido)
        {
            if (!pedido.Pago)
            {
                Console.WriteLine($"Pedido {pedido.Id} do cliente {pedido.Cliente} ainda não foi pago.");
            }
            else
            {
                Console.WriteLine($"Processando pedido {pedido.Id}...");
            }
        }
    }
}
