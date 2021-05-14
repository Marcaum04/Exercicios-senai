using System;

namespace Catálogo_de_produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            int array = 10;
            string[] nome = new string[array];
            float[] preco = new float[array];
            int[] desconto = new int[array];
            string promocao;

            int menu;
            int cont = 0;
            int novoProduto;
do
{
            Console.Write(@"
______________________________
||Bem-vindo a vendinha do zé||
||__________________________||            
||   O que deseja fazer?    || 
||__________________________||
||  1 - Cadastrar produtos  ||
||   2 - Listar produtos    ||
||         0 - Sair         ||
||__________________________||
||  Digite:  ");
            menu = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (menu)
            {
                case 1:
                    do
                    {

                        Console.Write(@"
_________________________________            
||    Qual nome do produto?    || 
||_____________________________||
||  Digite: ");
                        nome[cont] = Console.ReadLine();

                        Console.Write(@"
_________________________________            
||    Qual preço do produto?   || 
||_____________________________||
||  Digite: ");
                        preco[cont] = float.Parse(Console.ReadLine());

                        Console.Write(@"
_________________________________            
|| O produto está em promoção? || 
||_____________________________||
||          1 - Sim            ||
||          0 - Não            ||
||_____________________________||
||  Digite: ");
                        desconto[cont] = int.Parse(Console.ReadLine());
                        cont++;

                        Console.Write(@"
_____________________________________            
|| Deseja cadastrar outro produto? || 
||_________________________________||
||            1 - Sim              ||
||            0 - Não              ||
||_________________________________||
||  Digite: ");
                        novoProduto = int.Parse(Console.ReadLine());
                    } while (novoProduto == 1);
                    break;
                case 2:
                    for (var i = 0; i < cont; i++)
                    {
                        if (desconto[i] == 1)
                        {
                            promocao = "Sim";
                        }
                        else
                        {
                            promocao = "Não";
                        }
                        if (nome[i] != null)
                        {

                            Console.Write($@"
______________________________            
||        Produto {i + 1}    
||__________________________||
||      Nome: {nome[i]}  
||      Preço: {preco[i]:C2}    
||      Em Promoção: {promocao}         
||__________________________|| ");
                        }
                    }
                    break;
                case 0:
                    Console.WriteLine(@"Obrigado por catalogar na vendinha do zé
            Volte sempre!");
                    break;
            }

} while (menu != 0);
        }
    }
}
