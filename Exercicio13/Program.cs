namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verificar se a soma de A + B é menor que C");
            Console.WriteLine("------------------------------------------");

            Console.Write("Digite o valor de A: ");
            double valorA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            double valorB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            double valorC = Convert.ToDouble(Console.ReadLine());

            double soma = valorA + valorB;

            Console.WriteLine($"\nA = {valorA}");
            Console.WriteLine($"B = {valorB}");
            Console.WriteLine($"C = {valorC}");
            Console.WriteLine($"Soma de A + B = {soma}");

            if (soma < valorC)
            {
                Console.WriteLine("\nA soma de A + B é MENOR que C.");
            }
            else if (soma == valorC)
            {
                Console.WriteLine("\nA soma de A + B é IGUAL a C.");
            }
            else
            {
                Console.WriteLine("\nA soma de A + B é MAIOR que C.");
            }
        }
    }
}
