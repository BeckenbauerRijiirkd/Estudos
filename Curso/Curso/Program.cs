using System;
using System.Globalization;

namespace Curso {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com seu nome completo");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa ?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto");
            float preco = float.Parse(Console.ReadLine());

            Console.WriteLine("Entre seu ultimo nome, idade e altuca ");
            string[] lista = Console.ReadLine().Split(' ');
            string x = lista[0];
            int y = int.Parse(lista[1]);
            float z = float.Parse(lista[2]);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z.ToString("F2", CultureInfo.InvariantCulture));
            
        
        
        }
    }
}