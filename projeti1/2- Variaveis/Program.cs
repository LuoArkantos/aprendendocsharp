using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 2 - Criando Variáveis");
        int idade;
        
        idade = 25;
        Console.WriteLine(idade);

        idade = 31 - 1;
        Console.WriteLine("Minha idade passou a ser " + idade);
        
        idade = 21 * 1 - 1;
        Console.WriteLine("E então passou a ser " + idade);

        idade = (5+5) * 2 + 1 - 1;
        Console.WriteLine("Depois foi " + idade);

        idade = 5 + (5 * 2);
        Console.WriteLine("E então " + idade + " anos de Idade");

        Console.ReadLine();
    }
}