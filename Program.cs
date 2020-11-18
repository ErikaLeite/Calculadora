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
            Console.WriteLine("  "); 
            Console.WriteLine("Digite um número inteiro:");
            int numero = int.Parse(Console.ReadLine());

            int resultado, contador;
            for (contador = 0; contador <= 10; ++contador)
            {
                resultado =  numero * contador;
                Console.WriteLine(numero+ " X " +contador + " = " +resultado);
                //contatenação é juntar elementos do código
                //interpolação 
            }
        }
    }
}
