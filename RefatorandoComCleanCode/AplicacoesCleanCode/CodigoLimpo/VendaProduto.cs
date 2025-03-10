using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefatorandoComCleanCode.AplicacoesCleanCode.CodigoLimpo
{
    public class VendaProduto
    {
        private List<Produto> _produtos = new List<Produto>();

        public string ObterInformacoesDosProdutos()
        {
            var informacoes = new StringBuilder();

            informacoes.AppendLine("Produtos da lista:");

            foreach (var produto in _produtos)
            {
                informacoes.AppendLine($"Produto: {produto.Nome} | preço: {produto.Preco} | quantidade:{produto.Quantidade}");
            }

            informacoes.AppendLine($"Total:{_produtos.Sum(x => x.Total)}");

            return informacoes.ToString();
        }

        public void AdicionarProduto(Produto produto)
        {
            if (produto == null)
            throw new ArgumentNullException(nameof(produto), "O produto não pode ser nulo.");
            
            _produtos.Add(produto);
        }

        public void RemoverProduto(Produto produto) 
            => _produtos.Remove(produto);

    }
}
