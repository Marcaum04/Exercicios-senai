using System;
namespace POO_Cafeteira___Entrega.classes
{
    public class Cafeteira
    {
        private int acucarDisponivel = 1000;
        public string fazerCafe()
        {
            Console.WriteLine(@"Sim(S) / Não(N)
Você deseja fazer café com açucar?");
            string cafeAcucar = Console.ReadLine().ToLower();
            if (cafeAcucar == "s")
            {
                Console.WriteLine(@"Sim(S) / Não(N)
Deseja escolher quantas gramas de açucar?");
                string escolha = Console.ReadLine().ToLower();
                if (escolha == "s")
                {
                    Console.WriteLine("Quantas gramas de açucar deseja colocar?");
                    int gramas = int.Parse(Console.ReadLine());
                    return $@"As {gramas} gramas de açucar foram adicionadas ao seu café
Seu café com açucar está pronto!";
                }
                else if (escolha == "n")
                {

                    return @"A configuração padrão é de 10 gramas que já foram adicionadas ao seu café
Seu café com açucar está pronto!";
                }
                else
                {
                    return "Comando inválido";
                }

            }
            else if (cafeAcucar == "n")
            {
                return "Seu café sem açucar está pronto!";
            }
            else
            {
                return "Comando inválido";
            }
        }


    }
}
