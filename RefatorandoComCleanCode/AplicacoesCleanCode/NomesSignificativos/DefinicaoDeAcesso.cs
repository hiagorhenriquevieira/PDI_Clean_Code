using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefatorandoComCleanCode.AplicacoesCleanCode.NomesSignificativos
{
    public class DefinicaoDeAcesso
    {
        private List<Funcionario> _funcionarios = new List<Funcionario>();

        public void AdicionarFuncionario(string nome, ECargo cargo) 
            => _funcionarios.Add(new Funcionario(nome, cargo));


        public void RemoverFuncionario(Funcionario funcionario) 
            => _funcionarios.Remove(funcionario);

        public bool ValidarAcessoFuncionario(string nome)
        {
           return _funcionarios.Where(x => x.Nome == nome && x.Cargo == ECargo.Gerente).Any();
        }

        public string ListarFuncionariosCadastrados()
        {
            var texto = new StringBuilder();

            foreach (var funcionario in _funcionarios)
            {
                texto.AppendLine($"Nome: {funcionario.Nome} | Cargo: {funcionario.Cargo}");
            }

            return texto.ToString();
        }

    }
}
