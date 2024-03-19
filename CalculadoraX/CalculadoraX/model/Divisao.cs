using System;

namespace Model{
    public class Divisao : IOperacao{
        public int Calcular(int a, int b){
            if (b == 0){
                throw new ArgumentException("Divisor não pode ser zero.");
            }
            return a / b;
        }

        public int Calcular(int[] valores){
            return 0;
        }
    }
}
