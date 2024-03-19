using System;

namespace Model{
    public class Subtracao : Operacao{
        public int Calcular(int a, int b){
            return a - b;
        }

        public int Calcular(int[] valores){
            return 0;
        }
    }
}
