using System;
using POO_Polimorfismo.Classes;

namespace POO_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            MegaMan m = new MegaMan();
            Zero z = new Zero();

            Console.WriteLine(m.Pular());
            Console.WriteLine(m.Correr());
            Console.WriteLine("\n" + z.Pular());
            Console.WriteLine(z.Correr());
        }
    }
}
