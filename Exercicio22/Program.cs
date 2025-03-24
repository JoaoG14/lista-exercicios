using System;
using System.Collections.Generic;

namespace Exercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 22 - Sequência de Fibonacci");
            Console.WriteLine("-----------------------------------------------------------");

            int limite = 0;
            bool entradaValida = false;

            while (!entradaValida)
            {
                Console.Write("Digite um número limite para a sequência de Fibonacci: ");
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out limite) && limite > 0)
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Valor inválido! Digite um número inteiro positivo.");
                }
            }

            List<int> fibonacci = new List<int>();

            if (limite >= 1)
                fibonacci.Add(0);
            if (limite >= 2)
                fibonacci.Add(1);

            int proximo = 1;
            while (proximo <= limite)
            {
                int tamanho = fibonacci.Count;
                if (tamanho >= 2)
                {
                    proximo = fibonacci[tamanho - 1] + fibonacci[tamanho - 2];
                    if (proximo <= limite)
                        fibonacci.Add(proximo);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine($"\nSequência de Fibonacci até {limite}:");
            Console.Write("Sequência: ");
            foreach (int numero in fibonacci)
            {
                Console.Write($"{numero} ");
            }

            Console.WriteLine("\n\nInformações sobre a Sequência de Fibonacci:");
            Console.WriteLine("A sequência de Fibonacci é uma sucessão de números em que cada número é a soma dos dois anteriores.");
            Console.WriteLine("Começa com 0 e 1, e os próximos elementos são: 0, 1, 1, 2, 3, 5, 8, 13, 21, ...");

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
