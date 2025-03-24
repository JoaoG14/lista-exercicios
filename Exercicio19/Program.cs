using System;

namespace Exercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 19 - Soma dos números ímpares múltiplos de três de 1 a 500");
            Console.WriteLine("-----------------------------------------------------------");

            int soma = 0;

            Console.WriteLine("Números ímpares múltiplos de 3 entre 1 e 500:");
            
            for (int i = 1; i <= 500; i++)
            {
                if (i % 2 != 0 && i % 3 == 0)
                {
                    Console.Write($"{i} ");
                    soma += i;
                }
            }

            Console.WriteLine("\n-----------------------------------------------------------");
            Console.WriteLine($"A soma de todos os números ímpares múltiplos de 3 entre 1 e 500 é: {soma}");
            
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
