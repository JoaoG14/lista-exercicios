namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Dias de Vida");
            Console.WriteLine("--------------------------");

            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a sua idade em anos completos: ");
            int idadeAnos = Convert.ToInt32(Console.ReadLine());

            const int diasPorAno = 365;
            int diasDeVida = idadeAnos * diasPorAno;

            Console.WriteLine($"\n{nome.ToUpper()}, VOCÊ JÁ VIVEU {diasDeVida} DIAS.");

            decimal anosEmSemanas = idadeAnos * 52.143m;
            decimal anosEmHoras = diasDeVida * 24m;

            Console.WriteLine($"\nInformações adicionais:");
            Console.WriteLine($"Isso equivale a aproximadamente {anosEmSemanas:F0} semanas.");
            Console.WriteLine($"Ou aproximadamente {anosEmHoras:N0} horas de vida.");

            int idadeEsperada = 80;
            int diasRestantes = (idadeEsperada - idadeAnos) * diasPorAno;
            
            if (idadeAnos < idadeEsperada)
            {
                Console.WriteLine($"\nSe a expectativa média de vida for de {idadeEsperada} anos, ");
                Console.WriteLine($"você ainda tem aproximadamente {diasRestantes:N0} dias pela frente.");
            }
        }
    }
}
