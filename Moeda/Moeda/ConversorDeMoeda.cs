namespace Moeda {
    class ConversorDeMoeda {

        public static double Conversao(double cotacao, double dolar) {
            double IOF = 0.06;
            IOF = (cotacao * dolar) * IOF;
            double resultado = (cotacao * dolar) + IOF;
            
            return resultado;
        }

    }
}
