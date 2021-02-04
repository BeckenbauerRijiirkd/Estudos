using System;

namespace For {
    class Program {
        static void Main(string[] args) {
            int numero = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int i = 1; i <= numero; i++) {
                Console.Write("Digite o {0} Numero",(i));
                soma = (int.Parse(Console.ReadLine())+(soma));           
            }
            Console.WriteLine("A soma dos valores é: {0}", (soma));
        }
    }
}
