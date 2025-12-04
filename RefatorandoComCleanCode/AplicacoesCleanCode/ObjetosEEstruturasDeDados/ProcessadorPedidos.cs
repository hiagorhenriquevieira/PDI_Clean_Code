using System;

namespace RefatorandoComCleanCode.AplicacoesCleanCode.ObjetosEEstruturasDeDados
{
    public class ProcessadorPedidos
    {
        public void Processar(Pedido pedido)
        {
            Console.WriteLine($"Processando pedido {pedido.IdPedido}...");
        }
    }
}