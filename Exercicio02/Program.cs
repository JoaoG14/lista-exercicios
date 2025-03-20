using System.CodeDom.Compiler;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo do Volume de um Cilindro");
            Console.WriteLine("--------------------------------");

            Console.Write("Digite o raio da base do cilindro: ");
            decimal raio = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a altura do cilindro: ");
            decimal altura = Convert.ToDecimal(Console.ReadLine());

            decimal pi = (decimal)Math.PI;
            decimal volume = pi * raio * raio * altura;

            Console.WriteLine($"\nO volume do cilindro é {volume:F2} unidades cúbicas");
            Console.WriteLine($"Dimensões do cilindro: Raio = {raio}, Altura = {altura}");
        }
    }
}
