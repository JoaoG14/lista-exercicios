namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verificação de Número Primo");
            Console.WriteLine("--------------------------");

            Console.Write("Digite um número inteiro positivo: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero <= 1)
            {
                Console.WriteLine($"{numero} não é um número primo.");
                Console.WriteLine("Números primos são maiores que 1.");
                return;
            }

            bool ehPrimo = VerificarSePrimo(numero);

            if (ehPrimo)
            {
                Console.WriteLine($"{numero} é um número primo.");
            }
            else
            {
                Console.WriteLine($"{numero} não é um número primo.");
                
                Console.WriteLine("\nDivisores:");
                for (int i = 1; i <= numero; i++)
                {
                    if (numero % i == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }

        static bool VerificarSePrimo(int numero)
        {
            if (numero <= 1)
                return false;
            
            if (numero <= 3)
                return true;
            
            if (numero % 2 == 0 || numero % 3 == 0)
                return false;
            
            for (int i = 5; i * i <= numero; i += 6)
            {
                if (numero % i == 0 || numero % (i + 2) == 0)
                    return false;
            }
            
            return true;
        }
    }
}
