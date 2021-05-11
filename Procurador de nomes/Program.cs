using System;

namespace Procurador_de_nomes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = null;
            int quantidade = 10;
            nomes = new string[quantidade];

            string comparar;

            for (var i = 0; i <= (10 - 1); i++)
            {
                Console.Write("Digite o nome " + (i + 1) + ": ");
                nomes[i] = Console.ReadLine().ToLower();
            }

            Console.Write("Digite um nome para que eu procure: ");
            comparar = Console.ReadLine().ToLower();

            int c = 0;

            bool nomeAchado = false;

            foreach (var item in nomes)
            {
                if (nomes[c] == comparar)
                {
                    nomeAchado = true;
                }
                c++;
            }

            if (nomeAchado == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nACHEI!!!!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNão achei T-T");
            }
        }
    }
}
