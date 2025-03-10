using System;

namespace RefatorandoComCleanCode.AplicacoesCleanCode.CodigoLimpo
{
    public class Produto
    {
        public Produto(string nome, decimal preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome { get; private set; }
        public decimal Preco { get; private set; }
        public int Quantidade { get; private set; }
        public decimal Total => Preco * Quantidade;

        public void VerificarInformacoes()
        {
            if (string.IsNullOrEmpty(Nome))
                throw new ArgumentException("Produto inválido. Verifique os dados.");
            
            if (Preco <= 0)
                throw new ArgumentException("Produto inválido. Verifique os dados.");
         
            if (Quantidade <= 0)
                throw new ArgumentException("Produto inválido. Verifique os dados.");
        }
    }
}
