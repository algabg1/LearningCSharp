using System;

namespace View{
    public class Menu{
        public void Exibir(){
            Console.WriteLine("Soma\nSubtração\nMultiplicação\nDivisão\nSair\nDigite a operação desejada: ");
            string operacao = Console.ReadLine();

            Console.WriteLine("Digite o Primeiro Valor: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo Valor: ");
            int b = int.Parse(Console.ReadLine());

            Controller.ControladorCalculadora control = new Controller.ControladorCalculadora();
            int resultado = control.Calcular(operacao, a, b);
            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}
