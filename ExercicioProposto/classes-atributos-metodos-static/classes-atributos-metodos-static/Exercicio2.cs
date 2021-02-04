using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace classes_atributos_metodos_static {
    class Exercicio2 {
        public static void Exec2() {
            Funcionario F = new Funcionario();

            Console.Write("Nome: ");
            F.Nome = Console.ReadLine();

            Console.Write("Salario Bruto: ");
            F.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            F.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionario: "+F.ToString());

            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double Porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            F.AumentarSalario(Porc);

            Console.WriteLine("Dados atualizados: "+F.ToString());


        
        }

    }
}
