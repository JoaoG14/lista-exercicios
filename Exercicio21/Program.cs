using System;

namespace Exercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 21 - Cálculo do Fatorial");
            Console.WriteLine("-----------------------------------------------------------");

            int a = 0;
            bool entradaValida = false;

            while (!entradaValida)
            {
                Console.Write("Digite um valor para A (número positivo): ");
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out a) && a >= 0)
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Valor inválido! Digite um número inteiro positivo.");
                }
            }

            long resultado = 1;
            string sequencia = "";

            if (a == 0 || a == 1)
            {
                resultado = 1;
                sequencia = a.ToString();
            }
            else
            {
                sequencia = a.ToString();
                for (int i = a - 1; i >= 1; i--)
                {
                    resultado *= i + 1;
                    sequencia += $" x {i}";
                }
            }

            Console.WriteLine("\nSequência do cálculo:");
            Console.WriteLine($"{a}! = {sequencia} = {resultado}");

            Console.WriteLine("\nInformações sobre Fatorial:");
            Console.WriteLine("Um fatorial é o produto de todos os números inteiros positivos menores ou iguais a um dado número.");
            Console.WriteLine("Por definição, 0! = 1 e 1! = 1");

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
