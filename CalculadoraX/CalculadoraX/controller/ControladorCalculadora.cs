using Model;

namespace Controller{
    public class ControladorCalculadora{
        public int Calcular(string operacao, int a, int b){
            Calculadora calc = new Calculadora();
            return calc.Calcular(operacao, a, b);
        }
    }
}
