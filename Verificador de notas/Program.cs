using System;

namespace Verificador_de_notas
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota;
            bool notaValida;

            Console.Write("Escreva uma nota de 1 a 10: ");
            nota = double.Parse(Console.ReadLine());
            notaValida = false;

            while (notaValida == false)
            {
                if (nota <= 10 && nota >= 0)
                {
                    notaValida = true;
                    Console.WriteLine("Obrigado sua nota foi armazenada.");
                }
                else
                {

                    Console.Write("Nota inválida escreva uma nota de 1 a 10: ");
                    nota = double.Parse(Console.ReadLine());
                }

            }
        }
    }
}


