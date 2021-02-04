using System;
using System.Globalization;

namespace Primeirosexercícios {
    class Exercicio2 {

        public static void Exe2() {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Informe os dados pedidos ");
            Console.Write("Nome: ");
            p1.nome = Console.ReadLine();
            Console.Write("Salario: ");
            p1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe os dados pedidos 2° Pessoa ");
            Console.Write("Nome: ");
            p2.nome = Console.ReadLine();
            Console.Write("Salario: ");
            p2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salaraioM = ((p1.salario + p2.salario) / 2);

            Console.WriteLine("Salario Medio é {0}", (salaraioM.ToString("F2", CultureInfo.InvariantCulture)));


        }

    
    }
}
