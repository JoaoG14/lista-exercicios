namespace Exercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números Ímpares entre 100 e 200");
            Console.WriteLine("-------------------------------");
            
            Console.WriteLine("\nExibindo todos os números ímpares entre 100 e 200:");
            Console.WriteLine();

            int contador = 0;
            
            for (int numero = 101; numero <= 199; numero += 2)
            {
                Console.Write($"{numero,4} ");
                contador++;
                
                if (contador % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
            
            Console.WriteLine("\n\nForam encontrados {0} números ímpares no intervalo.", contador);
            
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
