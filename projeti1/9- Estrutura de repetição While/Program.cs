using System;
class Programa
{
    static void Main(String[] args)
    {
        Console.WriteLine("Estrutura de repetição While");

        double valorAplicado = 1000;
        double porcentagemMensal = 0.005;/* 0.5% q é igual a 0.005*/;
        int meses = 1;

        while(meses <= 12)
        {
            double juroRendido = valorAplicado * porcentagemMensal;
            valorAplicado = valorAplicado + juroRendido;

            Console.WriteLine("Valor atualizado do mês " + meses + " é de " + valorAplicado);
            Console.WriteLine("Houve um lucro de " + juroRendido);

            meses++;

        }


        Console.WriteLine("FIM DO PROGRAMA!");
        Console.ReadLine();
    }
}
