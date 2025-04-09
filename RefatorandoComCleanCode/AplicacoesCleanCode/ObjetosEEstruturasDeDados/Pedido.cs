using Flunt.Notifications;
using Flunt.Validations;
using System.Linq;

namespace RefatorandoComCleanCode.AplicacoesCleanCode.ObjetosEEstruturasDeDados
{
    public class Pedido : Notifiable<Notification>
    {
        public Pedido(int id, string cliente, decimal valor, bool pago)
        {
            IdPedido = id;
            NomeCliente = cliente;
            Valor = valor;
            Pago = pago;
        }

        public readonly int IdPedido;
        private string NomeCliente { get; set; }
        private decimal Valor { get; set; }
        private bool Pago { get; set; }

        public bool Validar()
        {
            AddNotifications(new Contract<Notification>().IsNullOrWhiteSpace(NomeCliente, "Nome do cliente não foi preenchido corretamente."));
            AddNotifications(new Contract<Notification>().IsFalse(Pago, $"O pedido {IdPedido} do cliente {NomeCliente} ainda não foi pago."));

            return !Notifications.Any();
        }
    }
}
