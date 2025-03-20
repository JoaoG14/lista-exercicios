namespace Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operação com Dois Valores");
            Console.WriteLine("-------------------------");

            Console.Write("Digite o primeiro valor inteiro (A): ");
            if (!int.TryParse(Console.ReadLine(), out int valorA))
            {
                Console.WriteLine("Valor inválido! O programa será encerrado.");
                return;
            }

            Console.Write("Digite o segundo valor inteiro (B): ");
            if (!int.TryParse(Console.ReadLine(), out int valorB))
            {
                Console.WriteLine("Valor inválido! O programa será encerrado.");
                return;
            }

            int resultado;
            string operacao;

            if (valorA == valorB)
            {
                resultado = valorA + valorB;
                operacao = "Soma";
            }
            else
            {
                resultado = valorA * valorB;
                operacao = "Multiplicação";
            }

            Console.WriteLine($"\nValor A: {valorA}");
            Console.WriteLine($"Valor B: {valorB}");
            Console.WriteLine($"Os valores são {(valorA == valorB ? "IGUAIS" : "DIFERENTES")}");
            Console.WriteLine($"Operação realizada: {operacao}");
            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}
