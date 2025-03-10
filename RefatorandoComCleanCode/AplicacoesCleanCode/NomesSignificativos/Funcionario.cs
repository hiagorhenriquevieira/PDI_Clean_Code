namespace RefatorandoComCleanCode.AplicacoesCleanCode.NomesSignificativos
{
    public class Funcionario
    {
        public Funcionario(string nome, ECargo cargo)
        {
            Nome = nome;
            Cargo = cargo;
        }

        public string Nome { get; set; }
        public ECargo Cargo { get; set; }
    }
}
