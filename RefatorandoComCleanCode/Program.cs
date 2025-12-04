using System;

namespace RefatorandoComCleanCode
{
    class Program
    {
        static void Main(string[] args)
        {
            CapituloCodigoLimpo();

            CapituloNomesSignificativos();

            CapituloFuncoes();

            CapituloComentarios();
        }

        #region CodigoLimpo
        private static void CapituloCodigoLimpo()
        {
            MetodoSemCodigoLimpo();

            MetodoComCodigoLimpo();
        }

        private static void MetodoSemCodigoLimpo()
        {
            var p = new Original.CodigoLimpo.P();

            p.A(n: "Anador", p: 10, q: 2);

            p.B();
        }

        private static void MetodoComCodigoLimpo()
        {
            try
            {
                var vendaProduto = new AplicacoesCleanCode.CodigoLimpo.VendaProduto();

                var produto = new AplicacoesCleanCode.CodigoLimpo.Produto(nome: "Anador", preco: 10, quantidade: 2);

                vendaProduto.AdicionarProduto(produto);

                Console.WriteLine(vendaProduto.ObterInformacoesDosProdutos());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #endregion

        #region NomesSignificativos
        private static void CapituloNomesSignificativos()
        {
            MetodoSemNomesSignificativos();

            MetodoComNomesSignificativos();
        }

        private static void MetodoSemNomesSignificativos()
        {
            var u = new Original.NomesSignificativos.U();

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
            var definicaoDeAcesso = new AplicacoesCleanCode.NomesSignificativos.DefinicaoDeAcesso();

            definicaoDeAcesso.AdicionarFuncionario("Bartolomeu", AplicacoesCleanCode.NomesSignificativos.ECargo.Gerente);
            definicaoDeAcesso.AdicionarFuncionario("Monkey D. Luffy", AplicacoesCleanCode.NomesSignificativos.ECargo.Atendente);
            definicaoDeAcesso.AdicionarFuncionario("Roronoa Zoro", AplicacoesCleanCode.NomesSignificativos.ECargo.Estagiario);

            if (definicaoDeAcesso.ValidarAcessoFuncionario("Bartolomeu"))
            {
                Console.WriteLine(definicaoDeAcesso.ListarFuncionariosCadastrados());
            }
            else
            {
                Console.WriteLine("Funcionario não tem acesso as informações gerais.");
            }
        }
        #endregion

        #region Funcoes
        private static void CapituloFuncoes()
        {
            MetodoExemploFuncoesLegado();
            
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
                var processadorDePedido = new AplicacoesCleanCode.Funcoes.ProcessadorPedidos();
                var pedido = new AplicacoesCleanCode.Funcoes.Pedido(1, "Hiagor", 10, false, "Rua 10, número 1092 centro", AplicacoesCleanCode.Funcoes.ECategoriaEntrega.Padrao);

                processadorDePedido.ProcessarPedido(pedido);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Não foi possivel processar o pedido.{Environment.NewLine}Mensagem: {ex.Message}");
            }
        }
        #endregion

        #region Comentarios
        private static void CapituloComentarios()
        {
            MetodoExemploDeCodigoComentado();

            MetodoExemploDeCodigoSemComentario();

        }

        private static void MetodoExemploDeCodigoComentado()
        {
            //Criação do gerenciador de pedidos, para a adição individual de cada pedido.
            var gerenPedido = new Original.Comentarios.GerenciadorPedidos();
            //Adicionar valores de ID, nome do cliente, valor do pagamento, e se já está pago.
            gerenPedido.AddPedido(1,"hiagor", 10, true);
        }

        private static void MetodoExemploDeCodigoSemComentario()
        {
            var gerenciadorDePedidos = new AplicacoesCleanCode.Comentarios.GerenciadorPedidos();
            gerenciadorDePedidos.AdicionarPedido(idPedido: 1, nomeCliente: "Hiagor", valorVenda: 10, pagamentoEfetivado: true);

            gerenciadorDePedidos.VerificarPagamento(1);
        }

        #endregion
    }
}