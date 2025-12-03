using RefatorandoComCleanCode.AplicacoesCleanCode.CodigoLimpo;
using RefatorandoComCleanCode.AplicacoesCleanCode.Funcoes;
using RefatorandoComCleanCode.AplicacoesCleanCode.NomesSignificativos;
using RefatorandoComCleanCode.Original.CodigoLimpo;
using RefatorandoComCleanCode.Original.NomesSignificativos;
using System;

namespace RefatorandoComCleanCode
{
    class Program
    {
        static void Main(string[] args)
        {
            CapituloCodigoLimpo();

            Console.WriteLine("---------------------------------------------------");

            CapituloNomesSignificativos();

            Console.WriteLine("---------------------------------------------------");

            CapituloFuncoes();
        }

        private static void CapituloCodigoLimpo()
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
            try
            {
                Console.WriteLine("Exemplo 1: Refatorado");
                Console.WriteLine("");

                var vendaProduto = new VendaProduto();

                var produto = new Produto(nome: "Anador", preco: 10, quantidade: 2);

                vendaProduto.AdicionarProduto(produto);

                Console.WriteLine(vendaProduto.ObterInformacoesDosProdutos());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void CapituloNomesSignificativos()
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

        private static void CapituloFuncoes()
        {
            Console.WriteLine("Funções -------");
            MetodoExemploFuncoesLegado();
            Console.WriteLine();
            MetodoExemploFuncoesRefatorado();

        }

        private static void MetodoExemploFuncoesLegado()
        {
            var processadorDePedido = new Original.Funcoes.ProcessadorPedidos();
            processadorDePedido.ProcessarPedido(id: 1, nomeCliente: "Hiagor", valor: 10, pago: false, enderecoEntrega: "Rua 10, número 1092 centro", tipoEntrega: 2);
        }

        private static void MetodoExemploFuncoesRefatorado()
        {
            try
            {
                var processadorDePedido = new ProcessadorPedidos();
                var pedido = new Pedido(1, "Hiagor", 10, false, "Rua 10, número 1092 centro", ECategoriaEntrega.Padrao);

                processadorDePedido.ProcessarPedido(pedido);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Não foi possivel processar o pedido.{Environment.NewLine}Mensagem: {ex.Message}");
            }
        }
    }
}