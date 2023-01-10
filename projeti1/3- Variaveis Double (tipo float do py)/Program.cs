using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("3 - Variáveis tipo Double");

        double salarioBase;
        salarioBase = 1235.23;
        Console.WriteLine("Salário Base: " + salarioBase);

        double beneficios;
        beneficios = 350;
        Console.WriteLine("Valor dos Beneficios: " + beneficios);

        double descontos;
        descontos = 120.50;
        Console.WriteLine("Total de Descontos: " + descontos);

        double salarioTotal;
        salarioTotal = salarioBase + beneficios - descontos;
        Console.WriteLine("O Salário Base + os Benefícios - os Descontos é igual a: " + salarioTotal);

        Console.ReadLine();
    }
}