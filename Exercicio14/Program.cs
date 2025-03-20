namespace Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Organizando três números em ordem decrescente");
            Console.WriteLine("--------------------------------------------");

            Console.Write("Digite o primeiro valor inteiro: ");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo valor inteiro (diferente do primeiro): ");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            while (valor2 == valor1)
            {
                Console.Write("Valor repetido! Digite um valor diferente do primeiro: ");
                valor2 = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Digite o terceiro valor inteiro (diferente dos anteriores): ");
            int valor3 = Convert.ToInt32(Console.ReadLine());

            while (valor3 == valor1 || valor3 == valor2)
            {
                Console.Write("Valor repetido! Digite um valor diferente dos anteriores: ");
                valor3 = Convert.ToInt32(Console.ReadLine());
            }

            int[] valores = { valor1, valor2, valor3 };

            Array.Sort(valores);
            Array.Reverse(valores);

            Console.WriteLine("\nValores em ordem decrescente:");
            Console.WriteLine($"{valores[0]} > {valores[1]} > {valores[2]}");
        }
    }
}
