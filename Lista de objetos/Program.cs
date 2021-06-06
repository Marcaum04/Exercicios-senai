using System;
using System.Collections.Generic;
using Lista_de_objetos.Classes;

namespace Lista_de_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            produtos.Add(new Produto(1, "Headset Gamer HyperX Cloud Stinger", 259.90f));
            produtos.Add(new Produto(2, "Smart TV LG 50´ 4K NanoCell", 2599f));
            produtos.Add(new Produto(3, "Monitor Gamer LED Asus TUF Gaming 27´", 1599.90f));
            produtos.Add(new Produto(4, "Microfone Gamer HyperX QuadCast", 899.90f));
            produtos.Add(new Produto(5, "Notebook Gamer Lenovo Intel Core i7-10750H", 6399.90f));

            foreach (Produto p in produtos)
            {
                Console.WriteLine($"{p.Nome} - {p.Preco:C2}");
            }

            produtos.RemoveAt(2);

            Console.WriteLine("\nLista alterada:");
            foreach (Produto p in produtos)
            {
                Console.WriteLine($"{p.Nome} - {p.Preco:C2}");
            }

            Produto atualizar = produtos.Find(item => item.Codigo == 4);

            atualizar.Preco = 799.90f;

            produtos.RemoveAll(item => item.Codigo == 4);

            produtos.Insert(3, atualizar);
            
            Console.WriteLine("\nLista atualizada:");
            foreach (Produto p in produtos)
            {
                Console.WriteLine($"{p.Nome} - {p.Preco:C2}");
            }
        }
    }
}
