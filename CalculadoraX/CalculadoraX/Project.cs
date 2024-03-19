using System;

public class Main{
    public static void Calculadora(string[] args){
        Menu menu = new Menu();
        menu.Exibir();
    }
}

public class Menu{
    public void Exibir(){
        Console.WriteLine("Menu de opções");
    }
}
