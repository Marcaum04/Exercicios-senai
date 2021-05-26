using System;
using POO_Jogador_de_futebol___Entrega.classes;

namespace POO_Jogador_de_futebol___Entrega
{
    class Program
    {
        static void Main(string[] args)
        {
            string posicao;
            bool verificacao = true;

            JogadorAtaque ataque = new JogadorAtaque();
            JogadorMeio meio = new JogadorMeio();
            JogadorDefesa defesa = new JogadorDefesa();

            do
            {
            Console.WriteLine(@" (A)Ataque, (M)Meio-Campo e (D)Defesa
Digite em que posição você joga: ");
            posicao = Console.ReadLine().ToLower();
            switch (posicao)
            {
                case "a":
                ataque.BuscarDados();
                Console.WriteLine(ataque.MostrarDados(ataque.Idade()));
                Console.WriteLine(ataque.Aposentar());
                    break;
                case "m":
                meio.BuscarDados();
                Console.WriteLine(meio.MostrarDados(meio.Idade()));
                Console.WriteLine(meio.Aposentar());
                    break;
                case "d":
                defesa.BuscarDados();
                Console.WriteLine(defesa.MostrarDados(defesa.Idade()));
                Console.WriteLine(defesa.Aposentar());
                    break;
                default:
                    Console.WriteLine("Comando inválido digite novamente");
                    verificacao = false;
                    break;
            }
            } while (verificacao == false);

        }
    }
}
