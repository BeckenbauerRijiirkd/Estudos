using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {
            while (true){
                Console.WriteLine("Entre com com os dadeos");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine());
                

                Produto p = new Produto(nome, preco);

                Produto p3 = new Produto {
                    Nome = "TV",
                    Preco = 500.00,
                    Quantidade = 1
                };

                

                Console.WriteLine("Dados do produto: " + p.ToString());
                Console.WriteLine();

                Console.Write("Digite a quantidade a ser adicionada ao estoque: ");
                int qte = int.Parse(Console.ReadLine());
                p.AdicionarProdutos(qte);

                Console.WriteLine("Dados do produto Atualizado: " + p.ToString());
                Console.WriteLine();

                Console.Write("Digite a quantidade a ser removida do estoque: ");
                int qte2 = int.Parse(Console.ReadLine());
                p.RemoverProdutos(qte2);

                if (p.Quantidade <= 0) {
                    Console.WriteLine("Quantidade minima atingida");
                }

                Console.WriteLine("Dados do produto Atualizado: " + p.ToString());
            }
        }
    }
}
