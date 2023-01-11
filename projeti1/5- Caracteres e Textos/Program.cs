using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("5 - Caracteres e Textos");

        char caractere = 'a'; //Não pode ser vazio
        Console.WriteLine(caractere);

        string frase = "Quem com ferro fere, com ferro será ferido";
        Console.WriteLine(frase);

        string textoComLista = @"Lista de compras:
- Arroz 
- Feijão 
- Carne 
- Danoninho"; //Usando o @ no inicio da string, da pra pular linha

        Console.WriteLine(textoComLista);
        Console.ReadLine();
    }
}