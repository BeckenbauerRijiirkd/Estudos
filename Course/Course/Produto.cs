using System;
using System.Globalization;

namespace Course {
    class Produto {

        public string Nome;
        public double Preco;
        public int Quantidade;
        public int quantity;

        public Produto(string nome, double preco, int quantidade) {

            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
            Quantidade = 0;
        }

        public double ValorTotalEmEstoque() {

            return (Preco * Quantidade);
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade = Quantidade + quantidade;

        }

        public void RemoverProdutos(int quantidaderemo) {
            Quantidade = Quantidade - quantidaderemo;
        }

        public override string ToString() {
            return Nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " Unidades , Valor Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
