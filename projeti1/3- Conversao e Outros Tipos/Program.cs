using System;
class Programa
{
    static void Main(String[] args)
    {
        Console.WriteLine("4 - Conversão e Outros Tipos");

        int valorInteiro = 25;
        Console.WriteLine(valorInteiro);

        double deInteiroParaDouble = (double)valorInteiro; //Recebe o valor inteiro e transforma em Double para ser fracionado
        Console.WriteLine("De Inteiro para Double - " + deInteiroParaDouble / 2);

        long numeroGrande = 2000000000000000000;
        Console.WriteLine("Var tipo Long - " + numeroGrande);

        short numeroPequeno = 15000; // Ideal para armazenar algo como Quantidade de convidados, numero de modelos ou algo de quantidade não tão grande.
        Console.WriteLine("Var tipo Short - " + numeroPequeno);

        float numeroFloat = 1.62f; //como Double, porém mais preciso e deve ter f afrente do numero
        Console.WriteLine("Var tipo Float - " + numeroFloat);



        Console.ReadLine();

    }
}
