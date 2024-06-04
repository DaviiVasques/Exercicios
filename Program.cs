<<<<<<< HEAD
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
=======
﻿using System;
using System.Globalization;

namespace Principal
{
    class Program
    {
        static void Main(string [] args)
        {
            
            //Fazer um programa onde guarda um N numeros de itens e faz a média do preço de intens
            
            Console.Write("Digite a quantidade de itens que vai ser adicionados: ");
            int qtdeItens = int.Parse(Console.ReadLine() ?? "00");

            string[] NomeItens = new string[qtdeItens];
            double[] PrecoItens = new double[qtdeItens];

            for (int i = 0; i < qtdeItens; i++)
            {
                Console.Write("Digite o nome dos itens: ");
                NomeItens[i] = Console.ReadLine() ?? "";
                Console.Write("Digite o preço do produto: ");
                PrecoItens[i] = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
            }

            double soma = 0.0;

            for (int i = 0; i < qtdeItens; i++)
            {
                soma += PrecoItens[i];
            }

            double avg = soma / qtdeItens;

            string ItensList = "";
            for (int i = 0; i < NomeItens.Length; i++)
            {
                ItensList += NomeItens[i];
                if (i < NomeItens.Length - 1)
                ItensList += ", ";
            }

            string MediaFormatada = avg.ToString("F3", CultureInfo.InvariantCulture);
            Console.WriteLine($"A média dos preços dos produtos {ItensList} é: {MediaFormatada}");
            
        }
    }
}
>>>>>>> 21b53d73c3e12f95c605826332f84ea268330237
