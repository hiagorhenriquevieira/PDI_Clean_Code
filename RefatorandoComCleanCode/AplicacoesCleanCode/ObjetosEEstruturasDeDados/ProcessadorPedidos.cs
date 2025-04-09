using System;
using System.Linq;

namespace RefatorandoComCleanCode.AplicacoesCleanCode.ObjetosEEstruturasDeDados
{
    public class ProcessadorPedidos
    {
        public void Processar(Pedido pedido)
        {
            if (!pedido.Validar()) 
            {
                Console.WriteLine(pedido.Notifications.FirstOrDefault().Message);
                return;
            };

            Console.WriteLine($"Processando pedido {pedido.IdPedido}...");
        }
    }
}
