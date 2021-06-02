using System;
using System.Collections.Generic;

namespace POO_Objeto_argumento.classes
{
    public class Carrinho
    {
        public float valorTotal { get; set; }

        List<Produto> carrinho = new List<Produto>();
        List<Produto> opcoes = new List<Produto>();

        public void AdicionarOpcao(Produto produto)
        {
            opcoes.Add(produto);
        }
        public void AdicionarProduto(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void RemoverProduto(Produto produto)
        {
            carrinho.Remove(produto);
        }

        public void MostrarProdutos()
        {
            if (carrinho != null)
            {
                foreach (Produto p in carrinho)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($@"{p.preco:C2} - {p.nome}");
                    Console.ResetColor();
                }
                MostrarTotal();
            }
        }
        public void MostrarTotal()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            valorTotal = 0;
            if (carrinho != null)
            {
                foreach (Produto p in carrinho)
                {
                    valorTotal += p.preco;
                }
                Console.WriteLine($@"
Total do carrinho {valorTotal:C2}
");
            }else{
                Console.WriteLine(@"
Seu carrinho está vazio!");
            }
            Console.ResetColor();
        }

        public void AlterarItem (int _codigo, Produto _novoProduto){
            carrinho.Find(x => x.codigo == _codigo).nome = _novoProduto.nome;
            carrinho.Find(x => x.codigo == _codigo).preco = _novoProduto.preco;
        }
    }
}