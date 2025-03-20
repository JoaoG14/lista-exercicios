namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo da Área de um Terreno Retangular");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Imobiliária Imobilis - Cálculo de Área de Terrenos");
            Console.WriteLine();

            Console.Write("Digite o comprimento do terreno (metros): ");
            decimal comprimento = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a largura do terreno (metros): ");
            decimal largura = Convert.ToDecimal(Console.ReadLine());

            decimal area = comprimento * largura;
            decimal areaEmMetrosQuadrados = area;

            Console.WriteLine($"\nResultados:");
            Console.WriteLine($"Dimensões do terreno: {comprimento}m x {largura}m");
            Console.WriteLine($"Área total do terreno: {areaEmMetrosQuadrados:F2} m²");

            if (areaEmMetrosQuadrados < 100)
            {
                Console.WriteLine("Classificação: Terreno Pequeno");
            }
            else if (areaEmMetrosQuadrados >= 100 && areaEmMetrosQuadrados <= 500)
            {
                Console.WriteLine("Classificação: Terreno Médio");
            }
            else
            {
                Console.WriteLine("Classificação: Terreno Grande");
            }
        }
    }
}
