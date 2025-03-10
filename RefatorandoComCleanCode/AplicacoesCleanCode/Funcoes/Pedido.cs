using System;

namespace RefatorandoComCleanCode.AplicacoesCleanCode.Funcoes
{
    public class Pedido
    {
        public long Id { get; set; }
        public string NomeCliente { get; set; }
        public decimal Valor { get; set; }
        public bool Pago { get; set; }
        public string EnderecoEntrega { get; set; }
        public ECategoriaEntrega TipoEntrega { get; set; }

        public bool Validar()
        {
            if (String.IsNullOrEmpty(NomeCliente)) return false;

            if (Valor <= 0) return false;

            return true;
        }
    }
}
