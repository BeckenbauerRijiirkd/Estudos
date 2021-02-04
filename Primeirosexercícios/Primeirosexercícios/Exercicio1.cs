using System;
using System.Collections.Generic;
using System.Text;

namespace Primeirosexercícios {
    class Exercicio1 {
        public static void Exe1() {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoal: ");
            Console.Write("Nome: ");
            p1.nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoal: ");
            Console.Write("Nome: ");
            p2.nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.idade = int.Parse(Console.ReadLine());

            if (p1.idade > p2.idade) {
                Console.WriteLine("{0} é mais velho {1} anos que {2}", (p1.nome) ,(p1.idade - p2.idade), (p2.nome));
            }
            else {
                Console.WriteLine("{0} é mais velho {1} anos que {2}", (p2.nome), (p2.idade - p1.idade), (p1.nome));
            }
        }
    }
}
