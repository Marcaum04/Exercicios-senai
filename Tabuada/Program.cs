using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, multiplicador, tabuada;
            numero = 0;
            multiplicador = 1;
            Console.WriteLine("Tabuada iniciada");

            while (numero < 10)
            {
                numero++;
                Console.WriteLine($"\nTabuada do {numero}");
                multiplicador = 1;
                while (multiplicador <= 10)
                {
                    tabuada = numero * multiplicador;
                    Console.WriteLine($"{numero} x {multiplicador} = {tabuada}");
                    multiplicador++;
                }
            }
        }
    }
}
