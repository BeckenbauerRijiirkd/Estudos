using System;

namespace ExercicioProposto {
    class Program {
        static void Main(string[] args) {
            Program.Exe4();

        }
        public static void Exe1() {
            Console.WriteLine("Digite o Primeiro Valor");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo Valor");
            int n2 = int.Parse(Console.ReadLine());

            int n3 = (n1 + n2);
            Console.WriteLine("A soma dos valores é: " + n3);
        }
        public static void Exe2() {
            Console.WriteLine("Informe o Valor do raio");
            float Ti = 3.14159F;
            float Raio = float.Parse(Console.ReadLine());

            float Area = (float)(Math.Pow(Raio, 2) * Ti);
            Console.WriteLine("A area deste circulo é: " + Area.ToString("F4"));
        }
        public static void Exe3() {
            Console.WriteLine(" digite 4 valores");
            string[] lista = Console.ReadLine().Split(' ');
            int A = int.Parse(lista[0]);
            int B = int.Parse(lista[1]);
            int C = int.Parse(lista[2]);
            int D = int.Parse(lista[3]);
            Console.WriteLine("A Difenrença é: " + (A * B - C * D));
        }
        public static void Exe4() {
            Console.WriteLine("Informe seu numero: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o numero de horas: ");
            int horas = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor por hora");
            float trab = float.Parse(Console.ReadLine());

            Console.WriteLine("NUMBER = " + n);
            Console.WriteLine("SALARY = U$ " + (horas * trab).ToString("F2"));
        }
    }
}

