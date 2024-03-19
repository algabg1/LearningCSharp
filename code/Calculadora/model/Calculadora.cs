using System;

namespace Model{
    public class Calculadora{
        public int Calcular(string operacao, int a, int b){
            Operacao op = null;

            if (operacao.Equals("soma", StringComparison.OrdinalIgnoreCase)){
                op = new Somar();
            }
            else if (operacao.Equals("divisao", StringComparison.OrdinalIgnoreCase)){
                op = new Divisao();
            }
            return op.Calcular(a, b);
        }
    }
}
