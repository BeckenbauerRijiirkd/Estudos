using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace classes_atributos_metodos_static {
    class Exercicio1 {

        public static void Exec1() {
            Retangulo r = new Retangulo();


            Console.WriteLine("Entre com a Largura e Altura do Retangulo");
            Console.Write("Largura: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            r.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Area: "+ r.Area().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro: "+ r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: "+ r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
