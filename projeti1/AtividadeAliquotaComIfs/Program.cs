using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 3300.0;
        Console.WriteLine("O seu salário é de R$ " + salario);

        //ifs aqui
        if (salario >= 1900.0 && salario <= 2800.0)
        {
            double porcentagem = 7.5;
            double deducao = salario * (porcentagem / 100);

            Console.WriteLine(@"Com base no seu Salário, o IR é de 7.5% 
E pode deduzir na declaração um valor de R$ " + deducao);
        }
        
        if (salario >= 2800.01 && salario <= 3751.00)
        {
            double porcentagem = 15;
            double deducao = salario * (porcentagem / 100);

            
            Console.WriteLine(@"Com base no seu Salário, o IR é de 15% 
E pode deduzir na declaração um valor de R$ " + deducao);
        }
        
        if (salario >= 3751.01 && salario <= 4664.00)
        {
            double porcentagem = 22.5;
            double deducao = salario * (porcentagem / 100);

            Console.WriteLine(@"Com base no seu Salário, o IR é de 15%
E pode deduzir na declaração um valor de R$ " + deducao);
        }

        Console.WriteLine("FIM DO PROGRAMA");
        Console.ReadLine();

    }
}