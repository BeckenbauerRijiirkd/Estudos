using System;
using System.Globalization;
using System.Transactions;

namespace MetodosEstaticos {
    class Program {

        static void Main(string[] args){

            

            Console.WriteLine("Entre com o valor do raio: ");

            

            double raio = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));

            double Vol = Calculadora.Volume(raio);
            Console.WriteLine("Volume: " + Vol.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Pi: "+ Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        
    }
}
