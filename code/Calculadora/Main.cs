using System;

public class Main{
    public static void Main(string[] args){
        Menu menu = new Menu();
        menu.Exibir();
    }
}

public class Menu{
    public void Exibir(){
        // Aqui você implementaria a lógica para exibir o menu
        Console.WriteLine("Menu de opções");
    }
}
