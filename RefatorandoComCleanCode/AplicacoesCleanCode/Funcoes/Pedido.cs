using System;

namespace RefatorandoComCleanCode.AplicacoesCleanCode.Funcoes
{
    public class Pedido
    {
        public Pedido(long id, string nomeCliente, decimal valor, bool pago, string enderecoEntrega, ECategoriaEntrega tipoEntrega)
        {
            if (String.IsNullOrEmpty(nomeCliente)) throw new Exception("Não foi informado nome do cliente no pedido.");

            if (valor <= 0) throw new Exception("Valor do pedido não pode ser inferior ou igual a zero.");

            Id = id;
            NomeCliente = nomeCliente;
            Valor = valor;
            Pago = pago;
            EnderecoEntrega = enderecoEntrega;
            TipoEntrega = tipoEntrega;
        }

        public long Id { get; private set; }
        public string NomeCliente { get; private set; }
        public decimal Valor { get; private set; }  
        public bool Pago { get; private set; }
        public string EnderecoEntrega { get; private set; }
        public ECategoriaEntrega TipoEntrega { get; private set; } 
    }
}