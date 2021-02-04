using System;
using System.Globalization;

namespace Moeda {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Qual é a cotação do dolar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dolares você vai comprar ?");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais: " + ConversorDeMoeda.Conversao(cotacao, dolar));

        }
    }
}
