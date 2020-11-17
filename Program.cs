using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculadora
            //Escreva um algoritmo que receba o número inteiro e exiba sua tabuada até 10
            Console.WriteLine("TABUADA"); 
            Console.WriteLine("Digite um número inteiro:");
            int numero = int.Parse(Console.ReadLine());

            int formula, contador;
            for (contador = 1; contador <= 10; ++contador)
            {
                formula =  numero * contador;
                Console.WriteLine(numero + " X " + contador + " = " + formula);

                //erro prescisa ser resolvido

        }
    }
}
