using System;

namespace While {
    class Program {
        static void Main(string[] args) {
            int senha = 2002;
            Console.WriteLine("Digite a Senha");
            int input = int.Parse(Console.ReadLine());
            while (input != senha) {

                if (input != senha){
                    Console.WriteLine("Senha Incorreta");
                    }
                Console.WriteLine("Digite a Senha");
                input = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Senha Correta");
            }
        }
    }

