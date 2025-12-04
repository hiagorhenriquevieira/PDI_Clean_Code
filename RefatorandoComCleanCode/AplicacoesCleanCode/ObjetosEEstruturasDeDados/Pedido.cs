using System;

namespace RefatorandoComCleanCode.AplicacoesCleanCode.ObjetosEEstruturasDeDados
{
    public class Pedido
    {
        public Pedido(int idPedido, string nomeCliente, decimal valor, bool pago)
        {
            if (string.IsNullOrEmpty(nomeCliente))
            {
                throw new Exception("Nome do cliente não foi preenchido corretamente.");
            }
            if (!pago)
            {
                throw new Exception($"O pedido {idPedido} do cliente {nomeCliente} ainda não foi pago.");
            }

            IdPedido = idPedido;
            NomeCliente = nomeCliente;
            Valor = valor;
            Pago = pago;
        }

        public readonly int IdPedido;
        public string NomeCliente { get; private set; }
        public decimal Valor { get; private set; }
        public bool Pago { get; private set; }
    }
}