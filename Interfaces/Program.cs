using System;
using Interfaces.Classes;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            bool primeiraVerificacao = false;
            bool segundaVerificacao = false;

            int outroProduto;
            int id = 0;

            Carrinho carrinho = new Carrinho();

            do
            {

                Produto produto = new Produto();

                Console.Write("Digite o nome do produto: ");
                produto.Nome = Console.ReadLine();

                Console.Write("Digite o Preco do produto: ");
                produto.Preco = float.Parse(Console.ReadLine());

                produto.Codigo = id;


                carrinho.Cadastrar(produto);

                id++;

                do
                {
                    Console.WriteLine(@"
Deseja cadastrar mais um produto?
1 - Sim
0 - Não");
                    outroProduto = int.Parse(Console.ReadLine());
                    switch (outroProduto)
                    {
                        case 1:
                            primeiraVerificacao = true;
                            segundaVerificacao = true;
                            break;
                        case 0:
                            primeiraVerificacao = true;
                            segundaVerificacao = false;
                            break;
                        default:
                            primeiraVerificacao = false;
                            break;
                    }
                } while (primeiraVerificacao == false);

            } while (segundaVerificacao == true);

            Console.WriteLine("\nProdutos cadastrados:");
            carrinho.Listar();
        }
    }
}
