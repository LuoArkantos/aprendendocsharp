using System;
class Programa
{
    static void Main(String[] args)
    {
        /*Console.WriteLine("Estrutura de repetição While");

        double valorAplicado = 1000;
        double porcentagemMensal = 0.005;// 0.5% q é igual a 0.005;

       while (meses <= 12)
        {
            double juroRendido = valorAplicado * porcentagemMensal;
            valorAplicado = valorAplicado + juroRendido;

            Console.WriteLine("Valor atualizado do mês " + meses + " é de " + valorAplicado);
            Console.WriteLine("Houve um lucro de " + juroRendido);

            meses++;

        }*/
        double valorAplicado = 1000;
        double porcentagemMensal = 1.005;// 0.5% q é igual a 0.005, o 1 significa o 1ma vez o valorAplicado;

        for (int meses = 1; meses <= 12; meses++)
        {
            valorAplicado *= porcentagemMensal;
            Console.WriteLine("Valor atualizado do mês " + meses + " é de " + valorAplicado);

        }


        Console.WriteLine("FIM DO PROGRAMA!");
        Console.ReadLine();
    }
}
