namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o comprimento da caixa: ");
            decimal comprimento = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a largura da caixa: ");
            decimal largura = Convert.ToDecimal(Console.ReadLine());
            
            Console.WriteLine("Digite a altura da caixa: ");
            decimal altura = Convert.ToDecimal(Console.ReadLine());

            decimal resultado = comprimento * largura * altura;

            Console.WriteLine($"O volume da caixa é de {resultado} unidades cúbicas");
        }
    }
}
