namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo da Média Harmônica das Notas");
            Console.WriteLine("-----------------------------------");

            Console.Write("Digite quantas notas deseja informar: ");
            int quantidadeNotas = Convert.ToInt32(Console.ReadLine());

            if (quantidadeNotas <= 0)
            {
                Console.WriteLine("Quantidade de notas inválida!");
                return;
            }

            decimal somaInversos = 0;
            decimal[] notas = new decimal[quantidadeNotas];

            for (int i = 0; i < quantidadeNotas; i++)
            {
                Console.Write($"Digite a {i + 1}ª nota: ");
                notas[i] = Convert.ToDecimal(Console.ReadLine());
                
                if (notas[i] <= 0)
                {
                    Console.WriteLine("Erro: Notas devem ser maiores que zero para calcular a média harmônica.");
                    return;
                }
                
                somaInversos += 1 / notas[i];
            }

            decimal mediaHarmonica = quantidadeNotas / somaInversos;

            Console.WriteLine("\nNotas informadas:");
            for (int i = 0; i < quantidadeNotas; i++)
            {
                Console.WriteLine($"Nota {i + 1}: {notas[i]}");
            }

            Console.WriteLine($"\nMédia Harmônica: {mediaHarmonica:F2}");
        }
    }
}
