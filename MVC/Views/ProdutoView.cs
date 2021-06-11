using System;
using System.Collections.Generic;
using MVC.Models;

namespace MVC.Views
{
    public class ProdutoView
    {
        public void Listar(List<Produto> produto){

            foreach (Produto item in produto)
            {
                Console.WriteLine($"\nCódigo: {item.Codigo}");  
                Console.WriteLine($"Nome: {item.Nome}");  
                Console.WriteLine($"Preco: {item.Preco:C2}");  
                
            }
        }

        public Produto CadastrarProduto(){
            Produto produto = new Produto();

            Console.Write($"Digite o código do produto: ");
            produto.Codigo = int.Parse(Console.ReadLine());

            Console.Write($"Digite o nome do produto: ");
            produto.Nome = Console.ReadLine();

            Console.Write($"Digite o Preco do produto: ");
            produto.Preco = float.Parse(Console.ReadLine());

            return produto;
            
        }
    }
}