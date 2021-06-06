using System;
using Conversor_de_moedas_static.classes;

namespace Conversor_de_moedas_static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Conversor de moedas!");
            Console.Write("\nDigite o valor em reais: ");
            float ValorEmReal = float.Parse(Console.ReadLine());

            Console.Write("O valor em dolar é ");
            Console.WriteLine(Conversor.RealParaDolar(ValorEmReal));

            Console.Write("\nDigite o valor em dolar: ");
            float ValorEmDolar = float.Parse(Console.ReadLine());

            Console.Write("O valor em reais é ");
            Console.WriteLine(Conversor.DolarParaReal(ValorEmDolar));
        }
    }
}
