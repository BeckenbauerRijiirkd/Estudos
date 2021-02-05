using System;
using System.Globalization;

namespace Course {
    class Produto {

        private string _nome;
        private double _preco;
        private int _quantidade;


        public Produto() {
            _quantidade = 10;
        }
        public Produto(string nome, double preco, int quantidade) : this(){
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string GetNome() {
            return _nome;
        }

        public void SetNome(string nome) {
            if (nome != null && nome.Length > 1) { 
            _nome = nome;
            }
            else { Console.WriteLine("O nome não atingiu os requisitos");
            }
        }

        public double GetPreco() {
            return _preco;
        }

        public int GetQuantidade() {
            return _quantidade;
        }

        public double ValorTotalEmEstoque() {

            return (_preco * _quantidade);
        }

        public void AdicionarProdutos(int quantidade) {
            _quantidade = _quantidade + quantidade;

        }

        public void RemoverProdutos(int quantidaderemo) {
            _quantidade = _quantidade - quantidaderemo;
        }

        public override string ToString() {
            return _nome
                + ", $"
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " Unidades , Valor Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
