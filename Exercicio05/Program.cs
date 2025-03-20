namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de Salário Total do Vendedor");
            Console.WriteLine("-----------------------------------");

            Console.Write("Digite o salário base do vendedor: R$ ");
            decimal salarioBase = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o valor total de vendas: R$ ");
            decimal totalVendas = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o percentual de comissão sobre as vendas (%): ");
            decimal percentualComissao = Convert.ToDecimal(Console.ReadLine());

            decimal comissao = totalVendas * (percentualComissao / 100);
            decimal salarioTotal = salarioBase + comissao;

            Console.WriteLine($"\nResultados:");
            Console.WriteLine($"Salário Base: R$ {salarioBase:F2}");
            Console.WriteLine($"Comissão ({percentualComissao}%): R$ {comissao:F2}");
            Console.WriteLine($"Salário Total: R$ {salarioTotal:F2}");
        }
    }
}
