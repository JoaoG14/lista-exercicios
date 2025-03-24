using System;

namespace Exercicio23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 23 - FizzBuzz");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Números de 1 a 100, substituindo:");
            Console.WriteLine("- Múltiplos de 3 por 'Fizz'");
            Console.WriteLine("- Múltiplos de 5 por 'Buzz'");
            Console.WriteLine("- Múltiplos de ambos por 'FizzBuzz'");
            Console.WriteLine("-----------------------------------------------------------\n");

            for (int i = 1; i <= 100; i++)
            {
                bool multiplo3 = (i % 3 == 0);
                bool multiplo5 = (i % 5 == 0);

                if (multiplo3 && multiplo5)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("FizzBuzz ");
                }
                else if (multiplo3)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Fizz ");
                }
                else if (multiplo5)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Buzz ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"{i} ");
                }

                Console.ResetColor();

                if (i % 10 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine("\n\nInformação sobre FizzBuzz:");
            Console.WriteLine("O 'FizzBuzz' é um problema de programação comum usado em entrevistas de emprego");
            Console.WriteLine("para testar o conhecimento básico de programação dos candidatos.");

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
