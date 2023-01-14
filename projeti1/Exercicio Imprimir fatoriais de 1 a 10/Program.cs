using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("IMPRIMIR FATORIAIS DE 1 A 10");

        int fatorial = 1;
        int numero = 10;

        for (int contador = 1; contador <= numero; contador++)
        {
            fatorial = contador * fatorial;
            Console.WriteLine("O fatorial de " + contador + " é: " + fatorial);
        }
        int fatorial2 = 1;
        for (int contador = 1; contador <=10; contador++)
        {
            fatorial2 *= contador;
            Console.WriteLine(fatorial2);
        }

        Console.ReadLine();
    }
}