using System;
using System.Globalization;

namespace SegundoProblema___Poo {
    class Produto {

        public string Nome;
        public double Preco;
        public int Quantidade;
        public int quantity;

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
                +", $"
                +Preco.ToString("F2", CultureInfo.InvariantCulture)
                +", "
                +Quantidade
                +" Unidades , Valor Total: $"
                +ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
