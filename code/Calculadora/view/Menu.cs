using System;

namespace View{
    public class Menu{
        public void Exibir(){
            Console.WriteLine("Soma\nSubtração\nMultiplicação\nDivisão\nSair\nDigite a operação desejada: ");
            string operacao = Console.ReadLine();

            Console.WriteLine("Digite o Primeiro Valor: ");
            int a = Console.ReadLine();

            Console.WriteLine("Digite o Segundo Valor: ");
            int b = Console.ReadLine();

            ControladorCalculadora control = new ControladorCalculadora();
            int resultado = control.Calcular(operacao, a, b);
            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}
