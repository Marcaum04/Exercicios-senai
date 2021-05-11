using System;

namespace Comparador_de_valores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comparador de valores iniciados\n");
            // Array que vai guardar os 10 números declarado
            int[] numeros = null;
            int quantidade = 10;
            numeros = new int[quantidade];

            // Looping para armazenar 10 números do array
            for (var i = 0; i <= (10 - 1); i++)
            {
                Console.Write("Digite o numéro " + (i + 1) + ": ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            // Variável para alterar o array
            int um = 1;

            double numeroMaior = 0;
            double numeroMenor = 0;

            // Número menor e maior igual a primeiro valor do array
            numeroMaior = numeros[0];
            numeroMenor = numeros[0];

            while (um < 9)
            {
                //variável que vai ser o array sendo alterado
                int primeiro;
                primeiro = numeros[um];

                // Se o número maior foi menor que o número atual na variavel "primeiro"
                if (numeroMaior < primeiro)
                {
                    // Numero maior igual número atual na variável "primeiro" 
                    numeroMaior = primeiro;
                }
                // Se o número menor foi maior que o número atual na variavel "primeiro"
                if (numeroMenor > primeiro)
                {
                    // Numero menor igual número atual na variável "primeiro" 
                    numeroMenor = primeiro;
                }

                um++;
            }

            Console.WriteLine($"O maior número digitado foi: {numeroMaior}");
            Console.WriteLine($"O menor número digitado foi: {numeroMenor}");

        }
    }
}
