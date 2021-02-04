using System;
using System.Globalization;

namespace ResolucaoTriangulo {
    class Program {
        static void Main(string[] args) {

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();


            Console.WriteLine("Entre com as Medidas do triangulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double areaX = x.Area();

            Console.WriteLine(areaX);

            Console.WriteLine("Entre com as Medidas do triangulo y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaY = y.Area();

            Console.WriteLine(areaY);

            Console.WriteLine("A area do triagulo X é : " + (areaX.ToString("F4",CultureInfo.InvariantCulture)));
            Console.WriteLine("A area do triagulo y é : " + (areaY.ToString("F4", CultureInfo.InvariantCulture)));


            if (areaX > areaY){
                Console.WriteLine("A area do Triangulo X é maior");
            }
            else if(areaX == areaY){
                Console.WriteLine("Os Triangulos tem a mesma area");
            }
            else {
                Console.WriteLine("A area do Triangulo y é maior");//
            }
        }
    }
}
