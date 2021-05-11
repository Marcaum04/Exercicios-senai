using System;

namespace Comparador_de_valores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comparador de valores iniciados\n");
            int[] numeros = null;
            int quantidade = 10;
            numeros = new int[quantidade];

            for (var i = 0; i <= (10 - 1); i++)
            {
                Console.Write("Digite o numéro " + (i + 1) + ": ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            int um = 1;

            double numeroMaior = 0;
            double numeroMenor = 0;
            double maior = 0;
            double menor = 0;

            while (um < 9)
            {
                int primeiro;
                primeiro = numeros[um];
                numeroMaior = numeros[0] + 1;
                numeroMenor = numeros[0] - 1;


                if (numeroMaior < primeiro)
                {
                    maior = primeiro;
                }
                else if (numeroMenor > primeiro)
                {
                    menor = primeiro;
                }
                
                um++;
            }

            Console.WriteLine($"O maior número digitado foi: {maior}");
            Console.WriteLine($"O menor número digitado foi: {menor}");

        }
    }
}
