using System;
class Programa
{
    static void Main(String[] args)
    {
        Console.WriteLine("7 - Condicionais");

        int idade = 18;
        int acompanhantes = 1;

        bool grupo = acompanhantes > 0; //armazena dados Booleanos (True or False)

        //And == && , Or == || , Not == ! 
        
        if (idade >= 18 && grupo)
        {
            Console.WriteLine("Acesso Autorizado. Bem vindo!");
        }

        else
        {
            Console.WriteLine("Acesso Negado!");
        }




        Console.ReadLine();
    }
}
