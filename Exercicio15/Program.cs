namespace Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de IMC (Índice de Massa Corporal)");
            Console.WriteLine("--------------------------------------------");

            Console.Write("Digite o peso em kg: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura em metros: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / Math.Pow(altura, 2);

            string condicao;

            if (imc < 18.5)
            {
                condicao = "Abaixo do peso";
            }
            else if (imc < 25)
            {
                condicao = "Peso normal";
            }
            else if (imc < 30)
            {
                condicao = "Entre 25 e 30";
            }
            else if (imc <= 30)
            {
                condicao = "Acima do peso";
            }
            else
            {
                condicao = "Acima de 30 obeso";
            }

            Console.WriteLine($"\nResultados:");
            Console.WriteLine($"Peso: {peso:F2} kg");
            Console.WriteLine($"Altura: {altura:F2} m");
            Console.WriteLine($"IMC: {imc:F2}");
            Console.WriteLine($"Condição: {condicao}");
        }
    }
}
