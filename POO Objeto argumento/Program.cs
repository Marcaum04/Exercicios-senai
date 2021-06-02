using System;
using POO_Objeto_argumento.classes;

namespace POO_Objeto_argumento
{
    class Program
    {
        static void Main(string[] args)
        {
            string jogos;

            Produto p1 = new Produto(1, "Red Dead Redemption 2 (RDR2)", 499f);
            Produto p2 = new Produto(2, "Grand Theft Auto 5 (GTA5)", 56.90f);
            Produto p3 = new Produto(3, "Detroit Become Human (DBH)", 120.5f);
            Produto p4 = new Produto(4, "Celeste (CLT)", 22.99f);

            Console.WriteLine("Quais desses produtos você deseja adicionar ao seu carrinho?");
            Console.WriteLine($@"
{p1.preco:C2} - {p1.nome}
{p2.preco:C2} - {p2.nome}
{p3.preco:C2} - {p3.nome}
{p4.preco:C2} - {p4.nome}
");
            Carrinho carrinho = new Carrinho();
            Carrinho opcoes = new Carrinho();

            jogos = Console.ReadLine().ToLower();
            switch (jogos)
            {
                case "rdr2":
                    carrinho.AdicionarProduto(p1);
                    break;
                case "gta5":
                    carrinho.AdicionarProduto(p2);
                    break;
                case "dbh":
                    carrinho.AdicionarProduto(p3);
                    break;
                case "clt":
                    carrinho.AdicionarProduto(p4);
                    break;
            }
            Console.WriteLine();

            carrinho.MostrarProdutos();
        }
    }
}
