using System;
using POO_Cafeteira___Entrega.classes;

namespace POO_Cafeteira___Entrega
{
    class Program
    {
        static void Main(string[] args)
        {
            Cafeteira cafeteira = new Cafeteira();

            Console.WriteLine("Super CafeteiraTabajaras Plus++ inicializada");
            Console.WriteLine(cafeteira.fazerCafe());
        }
    }
}
