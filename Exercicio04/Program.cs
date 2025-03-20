namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de Temperatura: Celsius para Fahrenheit");
            Console.WriteLine("-----------------------------------------------");

            Console.Write("Digite a temperatura em graus Celsius: ");
            decimal temperaturaCelsius = Convert.ToDecimal(Console.ReadLine());

            decimal temperaturaFahrenheit = (temperaturaCelsius * 9 / 5) + 32;

            Console.WriteLine($"\n{temperaturaCelsius}°C equivale a {temperaturaFahrenheit}°F");
        }
    }
}
