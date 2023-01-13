using System;
using System.IO.Pipes;

class Programa
{
    static void Main(String[] args)
    {
        /* Encadeamento do FOR é quando usamos o FOR dentro de um laço FOR existente
         Por Exemplo:
        
         O valor do rendimento cresce 1 por cento por ano, assim em cada ano, o 
        investimento é multiplicado mensalmente pela porcentagem atualizada anual
        dos juros.

        Ex: No ano 1, o juro é de 0.5%, no ano 2 o juro é de 0.6% e aí por diante
        No ano 1, todo mes é adicionado 0.5% ao investimento
        No ano 2, todo mes é adicionado 0.6% ao investimento...
        Crescente até que se atinja o teto de anos (5 anos no caso)

         */

        Console.WriteLine("RENDIMENTO DE POUPANÇA COM ACRESCIMO ANUAL DE JUROS");

        double investimento = 1000;
        double rendimento = 1.005;

        for (int ano = 1; ano <= 5; ano++)
        {
            rendimento += 0.001;
            Console.WriteLine(@"

Porcentagem do ano " + ano +" foi igual a "+rendimento+@"

");

            for(int mes = 1; mes <= 12; mes++)
            {
                investimento *= rendimento;
                Console.WriteLine("Resultado do investimento do mes " + mes + " do ano " + ano +':');
                Console.WriteLine(investimento + @"
");
            }
            Console.WriteLine("Neste ano você acumulou o valor de R$: " + investimento);
        }

        Console.WriteLine("FIM DO PROGRAMA");
        Console.ReadLine();
    }
}
