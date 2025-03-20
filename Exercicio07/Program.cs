namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de Média Ponderada de Duas Provas");
            Console.WriteLine("----------------------------------------");

            Console.Write("Digite a nota da primeira prova: ");
            decimal nota1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o peso da primeira prova: ");
            decimal peso1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a nota da segunda prova: ");
            decimal nota2 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o peso da segunda prova: ");
            decimal peso2 = Convert.ToDecimal(Console.ReadLine());

            decimal mediaPonderada = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);

            Console.WriteLine($"\nResultados:");
            Console.WriteLine($"Nota 1: {nota1} (Peso: {peso1})");
            Console.WriteLine($"Nota 2: {nota2} (Peso: {peso2})");
            Console.WriteLine($"Média Ponderada: {mediaPonderada:F2}");
        }
    }
}
