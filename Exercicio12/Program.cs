namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de Aumento Salarial e Descontos");
            Console.WriteLine("---------------------------------------");

            Console.Write("Digite o salário atual do funcionário: R$ ");
            decimal salarioInicial = Convert.ToDecimal(Console.ReadLine());

            const decimal percentualAumento = 15.0m;
            const decimal percentualImposto = 8.0m;

            decimal valorAumento = salarioInicial * (percentualAumento / 100);
            decimal salarioComAumento = salarioInicial + valorAumento;

            decimal valorImposto = salarioComAumento * (percentualImposto / 100);
            decimal salarioFinal = salarioComAumento - valorImposto;

            Console.WriteLine($"\nResultados:");
            Console.WriteLine($"Salário inicial: R$ {salarioInicial:F2}");
            Console.WriteLine($"Aumento de {percentualAumento}%: R$ {valorAumento:F2}");
            Console.WriteLine($"Salário após o aumento: R$ {salarioComAumento:F2}");
            Console.WriteLine($"Desconto de impostos ({percentualImposto}%): R$ {valorImposto:F2}");
            Console.WriteLine($"Salário final: R$ {salarioFinal:F2}");

            decimal aumentoReal = salarioFinal - salarioInicial;
            decimal percentualRealAumento = (aumentoReal / salarioInicial) * 100;

            Console.WriteLine($"\nAumento real: R$ {aumentoReal:F2} ({percentualRealAumento:F2}%)");
        }
    }
}
