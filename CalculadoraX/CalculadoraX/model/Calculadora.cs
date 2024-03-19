using System;

namespace Model{
    public class Calculadora{
        public int Calcular(string operacao, int a, int b){
            IOperacao op = null;

            if (operacao.Equals("soma", StringComparison.OrdinalIgnoreCase)){
                op = new Somar();
            }
            else if (operacao.Equals("divisao", StringComparison.OrdinalIgnoreCase)){
                op = new Divisao();
            }
            else if (operacao.Equals("subtracao", StringComparison.OrdinalIgnoreCase)){
                op = new Subtracao();
            }
            else if (operacao.Equals("multiplicacao", StringComparison.OrdinalIgnoreCase)){
                op = new Multiplicacao();
            }
            return op.Calcular(a, b);
        }
    }
}
