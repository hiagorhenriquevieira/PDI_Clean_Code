using System;

namespace RefatorandoComCleanCode.AplicacoesCleanCode.CodigoLimpo
{
    public class Produto
    {
        public Produto(string nome, decimal preco, int quantidade)
        {
            VerificarInformacoes(nome, preco, quantidade);

            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome { get; private set; }
        public decimal Preco { get; private set; }
        public int Quantidade { get; private set; }
        public decimal Total => Preco * Quantidade;

        private void VerificarInformacoes(string nome, decimal preco, int quantidade)
        {
            if (string.IsNullOrEmpty(nome))
                throw new ArgumentException("Produto inválido. Verifique os dados.");
            
            if (preco <= 0)
                throw new ArgumentException("Produto inválido. Verifique os dados.");
         
            if (quantidade <= 0)
                throw new ArgumentException("Produto inválido. Verifique os dados.");
        }
    }
}
