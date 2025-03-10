using System.ComponentModel;

namespace RefatorandoComCleanCode.AplicacoesCleanCode.NomesSignificativos
{
    public enum ECargo
    {
       [Description("Gerente")]
        Gerente = 1,
       [Description("Atendente")]
        Atendente = 2,
       [Description("Estagiario")]
        Estagiario = 3
    }
}
