using System;

namespace Model{
    public class Multiplicacao : Operacao{
        public int Calcular(int a, int b){
            return a * b;
        }

        public int Calcular(int[] valores){
            return 0;
        }
    }
}
