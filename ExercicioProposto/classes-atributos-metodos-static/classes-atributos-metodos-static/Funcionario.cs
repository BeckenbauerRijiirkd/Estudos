using System;
using System.Collections.Generic;
using System.Text;

namespace classes_atributos_metodos_static {
    class Funcionario {
        public String Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porcentagem) {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
        }
        public override string ToString() {
            return Nome
                + ", $ " + SalarioLiquido()
                ;
        }
    }
}
