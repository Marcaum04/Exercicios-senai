using System;

namespace Sequencia_de_fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b, c;

            a = -1;
            b = 1;
            c = 0;

            while (c < 500)
            {
                c = a + b;
                a = b;
                b = c;
                Console.Write(c + " ");
            }
        }
    }
}
