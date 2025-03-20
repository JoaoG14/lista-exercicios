namespace Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verificador de Número Par ou Ímpar");
            Console.WriteLine("----------------------------------");

            Console.Write("Digite um número inteiro: ");

            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                bool ehPar = numero % 2 == 0;

                Console.WriteLine($"\nO número {numero} é {(ehPar ? "PAR" : "ÍMPAR")}.");
            }
            else
            {
                Console.WriteLine("\nEntrada inválida. Por favor, digite um número inteiro válido.");
            }
        }
    }
}
