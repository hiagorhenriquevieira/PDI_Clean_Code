using RefatorandoComCleanCode.AplicacoesCleanCode.CodigoLimpo;
using RefatorandoComCleanCode.AplicacoesCleanCode.NomesSignificativos;
using RefatorandoComCleanCode.Original.CodigoLimpo;
using RefatorandoComCleanCode.Original.NomesSignificativos;
using System;
using System.Text;

namespace RefatorandoComCleanCode
{
    class Program
    {
        static void Main(string[] args)
        {
            CodigoLimpo();
         
            Console.WriteLine("---------------------------------------------------");

            NomesSignificativos();

        }

        private static void NomesSignificativos()
        {
            Console.WriteLine("Nomes Significativos -------");

            MetodoSemNomesSignificativos();
            Console.WriteLine();
            MetodoComNomesSignificativos();
        }

        private static void MetodoSemNomesSignificativos()
        {
            var u = new U();

            u.A("Bartolomeu", 1);
            u.A("Monkey D. Luffy", 2);
            u.A("Roronoa Zoro", 3);

            if (u.B("Bartolomeu"))
            {
                u.C();
            }
            else
            {
                Console.WriteLine("Funcionario não tem acesso as informações gerais.");
            }
        }

        private static void MetodoComNomesSignificativos()
        {
            var definicaoDeAcesso = new DefinicaoDeAcesso();

            definicaoDeAcesso.AdicionarFuncionario("Bartolomeu", ECargo.Gerente);
            definicaoDeAcesso.AdicionarFuncionario("Monkey D. Luffy", ECargo.Atendente);
            definicaoDeAcesso.AdicionarFuncionario("Roronoa Zoro", ECargo.Estagiario);

            if (definicaoDeAcesso.ValidarAcessoFuncionario("Bartolomeu"))
            {
                Console.WriteLine(definicaoDeAcesso.ListarFuncionariosCadastrados());
            }
            else
            {
                Console.WriteLine("Funcionario não tem acesso as informações gerais.");
            }
        }

        private static void CodigoLimpo()
        {
            Console.WriteLine("Código Limpo -------");

            MetodoSemCodigoLimpo();
            Console.WriteLine("");
            MetodoComCodigoLimpo();
        }

        private static void MetodoSemCodigoLimpo()
        {
            Console.WriteLine("Exemplo 1: Original");
            var p = new P();

            p.A(n: "Anador", p: 10, q: 2);

            p.B();
        }

        private static void MetodoComCodigoLimpo()
        {
            Console.WriteLine("Exemplo 1: Refatorado");
            Console.WriteLine("");

            var vendaProduto = new VendaProduto();

            var produto = new Produto(nome: "Anador", preco: 10, quantidade: 2);

            produto.VerificarInformacoes();

            vendaProduto.AdicionarProduto(produto);

            Console.WriteLine(vendaProduto.ObterInformacoesDosProdutos());
        }
    }
}
