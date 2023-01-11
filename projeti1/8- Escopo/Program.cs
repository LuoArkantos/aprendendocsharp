using System;
class Programa
{
    static void Main(String[] args)
    {
        Console.WriteLine("7 - Condicionais");

        int idade = 18;
        int acompanhantes = 0;

        bool grupo = acompanhantes > 0; //armazena dados Booleanos (True or False)

        //And == && , Or == || , Not == ! 

        /// ESCOPO:
        /// 
        /// Se uma variável for criada dentro de um if, ou qualquer outra 
        /// condicional ou estrutura, ela não tem efeito global, impossivel
        /// ser usada em outro lugar fora de onde ela foi atribuida
        ///
        /// Retorna Valores Locais, não globais
        /// 

        bool acompanhado = acompanhantes > 0;
        string textoSobreAcompanhante;


        if (acompanhado)
        {
            textoSobreAcompanhante = "O cliente está acompanhado";
            Console.WriteLine(textoSobreAcompanhante);
        }
        else
        {
            textoSobreAcompanhante = "O cliente está sozinho";
            Console.WriteLine(textoSobreAcompanhante);
        }

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
