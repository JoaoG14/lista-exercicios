namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Padaria Hotpão - Cálculo de Vendas e Poupança");
            Console.WriteLine("---------------------------------------------");

            decimal precoPao = 0.12m;
            decimal precoBroa = 1.50m;
            decimal percentualPoupanca = 10;

            Console.Write("Digite a quantidade de pães franceses vendidos hoje: ");
            int quantidadePaes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a quantidade de broas vendidas hoje: ");
            int quantidadeBroas = Convert.ToInt32(Console.ReadLine());

            decimal totalPaes = quantidadePaes * precoPao;
            decimal totalBroas = quantidadeBroas * precoBroa;
            decimal totalArrecadado = totalPaes + totalBroas;
            decimal valorPoupanca = totalArrecadado * (percentualPoupanca / 100);

            Console.WriteLine($"\nResultados do dia:");
            Console.WriteLine($"Venda de Pães: {quantidadePaes} unidades x R$ {precoPao:F2} = R$ {totalPaes:F2}");
            Console.WriteLine($"Venda de Broas: {quantidadeBroas} unidades x R$ {precoBroa:F2} = R$ {totalBroas:F2}");
            Console.WriteLine($"Total Arrecadado: R$ {totalArrecadado:F2}");
            Console.WriteLine($"Valor a guardar na poupança ({percentualPoupanca}%): R$ {valorPoupanca:F2}");
            Console.WriteLine($"Valor restante: R$ {totalArrecadado - valorPoupanca:F2}");
        }
    }
}
