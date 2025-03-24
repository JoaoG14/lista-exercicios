using System;

namespace Exercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 20 - Cálculo da tabuada de N");
            Console.WriteLine("-----------------------------------------------------------");

            int n = 0;
            bool entradaValida = false;

            while (!entradaValida)
            {
                Console.Write("Digite um valor para N (entre 1 e 10): ");
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out n) && n >= 1 && n <= 10)
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Valor inválido! Digite um número entre 1 e 10.");
                }
            }

            Console.WriteLine($"\nTabuada do {n}:");
            Console.WriteLine("-----------------------------------------------------------");

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {n} = {i * n}");
            }

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
