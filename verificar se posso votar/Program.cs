using System;

namespace verificar_se_posso_votar
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoNascimento;

            Console.WriteLine("Verificador de idade para votar iniciado\n");

            Console.Write("Digite seu ano de nascimento: ");
            anoNascimento = int.Parse(Console.ReadLine());

            VerificarIdade(Idade( anoNascimento));

        }

        static void VerificarIdade(int idade){
            if(idade >= 18){
                Console.WriteLine("Você tem que votar obrigatoriamente");
            }else if(idade == 16 || idade == 17){
                Console.WriteLine("Você tem idade para votar, mas isso é opcional");
            }else{
                Console.WriteLine("Você não tem idade para votar");
            }
        }

        static int Idade(int anoNascimento){
            int idade, anoAtual;
            anoAtual = DateTime.Now.Year;
            idade = anoAtual - anoNascimento;
            return(idade);
        }
    }
}