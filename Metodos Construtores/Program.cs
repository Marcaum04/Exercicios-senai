using System;
using Metodos_Construtores.Classes;

namespace Metodos_Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo Metodos construtores");

            Produto p = new Produto();

            Console.WriteLine("Produto 1(Construtor sem argumentos)");
            Console.WriteLine($"Codigo: {p.Codigo}\nNome: {p.Nome}\nDescrição: {p.Descricao}\nItens em estoque: {p.Estoque}\n");
            
            Produto p2 = new Produto(45);
            Console.WriteLine("Produto 2(Construtor com 1 argumento)");
            Console.WriteLine($"Codigo: {p2.Codigo}\nNome: {p2.Nome}\nDescrição: {p2.Descricao}\nItens em estoque: {p2.Estoque}\n");
           
            Produto p3 = new Produto(49, "Manga", "Mangas belas e docinhas", 40);
            Console.WriteLine("Produto 3(Construtor com 4 argumentos)");
            Console.WriteLine($"Codigo: {p3.Codigo}\nNome: {p3.Nome}\nDescrição: {p3.Descricao}\nItens em estoque: {p3.Estoque}");
        }
    }
}
