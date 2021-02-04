using System;
using System.Globalization;

namespace SegundoProblema___Poo {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto();

            
            Console.WriteLine("Entre com com os dadeos");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

            Console.WriteLine("Dados do produto: "+p.ToString() );
            Console.WriteLine();

            Console.Write("Digite a quantidade a ser adicionada ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine("Dados do produto Atualizado: "+p.ToString());
            Console.WriteLine();

            Console.Write("Digite a quantidade a ser removida do estoque: ");
            int qte2 = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte2);

            if (p.Quantidade <= 0){
                Console.WriteLine("Quantidade minima atingida");
            }

            Console.WriteLine("Dados do produto Atualizado: " + p.ToString());

        }
    }
}
