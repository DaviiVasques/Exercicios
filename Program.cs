using System;

namespace Teste
{
    public class Program
    {
        static void Main(string[] args)
        {
            Estudantes[] vect = new Estudantes[10];
            Console.Write("Quantos quartos serão alugados? ");
            int QuartosAlugados = int.Parse(Console.ReadLine());
            for (int i = 1; i <= QuartosAlugados; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                while (quarto < 0 || quarto >= 10 || vect[quarto] != null)
                {
                    Console.Write("Quarto já ocupado ou inválido, tente outro quarto: ");
                    quarto = int.Parse(Console.ReadLine());
                }

                vect[quarto] = new Estudantes(nome, email);
            }

            Console.WriteLine("\nQuartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine($"Quarto {i}: {vect[i].Nome}, {vect[i].Email}");
                }
            }

        }
    }
}