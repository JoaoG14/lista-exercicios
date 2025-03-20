namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de Consumo de Combustível por Quilômetro");
            Console.WriteLine("------------------------------------------------");

            Console.Write("Digite a quilometragem inicial do veículo: ");
            decimal quilometragemInicial = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a quilometragem final do veículo: ");
            decimal quilometragemFinal = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a quantidade de combustível consumida durante a viagem (em litros): ");
            decimal combustivelConsumido = Convert.ToDecimal(Console.ReadLine());

            decimal distanciaPercorrida = quilometragemFinal - quilometragemInicial;
            decimal consumoPorQuilometro = combustivelConsumido / distanciaPercorrida;
            decimal consumoPorKm = consumoPorQuilometro;
            decimal consumoKmPorLitro = distanciaPercorrida / combustivelConsumido;

            Console.WriteLine($"\nResultados:");
            Console.WriteLine($"Distância percorrida: {distanciaPercorrida} km");
            Console.WriteLine($"Consumo de combustível: {consumoPorKm:F3} litros/km");
            Console.WriteLine($"Rendimento: {consumoKmPorLitro:F2} km/litro");
        }
    }
}
