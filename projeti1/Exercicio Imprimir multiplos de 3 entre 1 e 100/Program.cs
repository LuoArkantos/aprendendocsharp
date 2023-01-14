using System;

class Programa
{
    static void Main(string[] args)
    {
        //IMPRIMIR MULTIPLOS DE 3 entre 1 e 100

        for (int i = 1; i < 100; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }

        //outra opçao
        for (int i = 3; i < 100; i+= 3)
        {
            Console.WriteLine(i);
        }
        
        Console.WriteLine("FIM DO PROGRAMA");
        Console.ReadLine();
    }

}