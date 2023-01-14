using System;
class Programa
{
    static void Main(String[] args)
    {
        //Console.BackgroundColor = ConsoleColor.Red; //cor de fundo das letras
        Console.WriteLine("11 - Break");


        //com BREAK
        for (int numeroDeLinhas = 0; numeroDeLinhas <= 10; numeroDeLinhas++)
        {
            Console.WriteLine();
            for(int numeroDeColunas = 0; numeroDeColunas <= 10; numeroDeColunas++)
            {
                Console.Write("*");
                if (numeroDeColunas >= numeroDeLinhas)
                {
                    break;
                }
            }
        }

        //sem BREAK
        for (int numeroDeLinhas = 0; numeroDeLinhas <= 10; numeroDeLinhas++)
        {
            Console.WriteLine();

            for (int numeroDeColunas = 0; numeroDeColunas <= numeroDeLinhas; numeroDeColunas++)
            {
                Console.Write("*");
            }
        }

            Console.WriteLine("FIM DO PROGRAMA");
        Console.ReadLine();
    }
}
