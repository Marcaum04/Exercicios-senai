using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem personagem1 = new Personagem();
            Personagem personagem2 = new Personagem();
            Personagem personagem3 = new Personagem();
            Personagem personagem4 = new Personagem();
            Personagem personagem5 = new Personagem();

            Inimigo Thanos = new Inimigo();

            int acao;
            int escolha;
            bool repeticao;

            personagem1.nome = "Homem de ferro";
            personagem1.forca = 15;
            personagem1.vida = 75;
            personagem1.armadura = 9;

            personagem2.nome = "Capitão América";
            personagem2.forca = 17;
            personagem2.vida = 80;
            personagem2.armadura = 6;

            personagem3.nome = "Homem-Aranha";
            personagem3.forca = 13;
            personagem3.vida = 60;
            personagem3.armadura = 8;

            personagem4.nome = "Hulk";
            personagem4.forca = 20;
            personagem4.vida = 90;
            personagem4.armadura = 3;

            personagem5.nome = "Pantera Negra";
            personagem5.forca = 15;
            personagem5.vida = 70;
            personagem5.armadura = 9;

            Console.Write($@"
______________________________________________________
||             Game Derrote o Thanos                ||
||__________________________________________________||
|| Escolha 1 Personagem para tentar derrotar Thanos ||
|| 1 - {personagem1.nome}
|| 2 - {personagem2.nome}
|| 3 - {personagem3.nome}
|| 4 - {personagem4.nome}
|| 5 - {personagem5.nome}
||__________________________________________________||
|| Digite o número do personagem: ");
            escolha = int.Parse(Console.ReadLine());
            Console.Write("||__________________________________________________||");

            repeticao = false;

            switch (escolha)
            {
                case 1:
                    while (repeticao == false)
                    {
                        Console.WriteLine(@"
_____________________________________
|| Você deseja defender ou atacar? ||
||_________________________________||
||         1 - Atacar              ||
||         2 - Defender            ||
||_________________________________||");
                        acao = int.Parse(Console.ReadLine());
                        if (acao == 1)
                        {
                            personagem1.vida = personagem1.vida - Thanos.forca;
                            Thanos.vida = Thanos.vida - personagem1.forca;
                            Console.Write($@"
______________________________________________________
|| Você deu um dano de {personagem1.forca} no Thanos
|| E ele te deu um dano de {Thanos.forca}
|| Sua vida atual é de {personagem1.vida}
|| e a vida atual de Thanos é de {Thanos.vida}
||____________________________________________________");
                        }
                        else if (acao == 2)
                        {
                            personagem1.vida = personagem1.vida - Thanos.forca;
                            personagem1.vida = personagem1.vida + personagem1.armadura;
                            Console.WriteLine($@"
______________________________________________________
|| Você deu um dano de 0 no Thanos
|| E ele te deu um dano de {Thanos.forca}
|| Sua vida atual é de {personagem1.vida}
|| e a vida atual de Thanos é de {Thanos.vida}
||____________________________________________________");
                        }
                        if (personagem1.vida <= 0)
                        {
                            Console.WriteLine("\nQue pena Thanos derrotou você de uma maneira implacável e seu plano foi concluído");
                            repeticao = true;
                        }
                        if (Thanos.vida <= 0)
                        {
                            Console.WriteLine("\nParabéns você derrotou o Thanos de uma maneira quase impossível");
                            repeticao = true;
                        }
                    }
                    break;
                case 2:
                    while (repeticao == false)
                    {
                        Console.WriteLine(@"
_____________________________________
|| Você deseja defender ou atacar? ||
||_________________________________||
||         1 - Atacar              ||
||         2 - Defender            ||
||_________________________________||");
                        acao = int.Parse(Console.ReadLine());
                        if (acao == 1)
                        {
                            personagem2.vida = personagem2.vida - Thanos.forca;
                            Thanos.vida = Thanos.vida - personagem2.forca;
                            Console.Write($@"
______________________________________________________
|| Você deu um dano de {personagem2.forca} no Thanos
|| E ele te deu um dano de {Thanos.forca}
|| Sua vida atual é de {personagem2.vida}
|| e a vida atual de Thanos é de {Thanos.vida}
||____________________________________________________");
                        }
                        else if (acao == 2)
                        {
                            personagem2.vida = personagem2.vida - Thanos.forca;
                            personagem2.vida = personagem2.vida + personagem2.armadura;
                            Console.WriteLine($@"
______________________________________________________
|| Você deu um dano de 0 no Thanos
|| E ele te deu um dano de {Thanos.forca}
|| Sua vida atual é de {personagem2.vida}
|| e a vida atual de Thanos é de {Thanos.vida}
||____________________________________________________");
                        }
                        if (personagem2.vida <= 0)
                        {
                            Console.WriteLine("\nQue pena Thanos derrotou você de uma maneira implacável e seu plano foi concluído");
                            repeticao = true;
                        }
                        if (Thanos.vida <= 0)
                        {
                            Console.WriteLine("\nParabéns você derrotou o Thanos de uma maneira quase impossível");
                            repeticao = true;
                        }
                    }
                    break;
                case 3:
                    while (repeticao == false)
                    {
                        Console.WriteLine(@"
_____________________________________
|| Você deseja defender ou atacar? ||
||_________________________________||
||         1 - Atacar              ||
||         2 - Defender            ||
||_________________________________||");
                        acao = int.Parse(Console.ReadLine());
                        if (acao == 1)
                        {
                            personagem3.vida = personagem3.vida - Thanos.forca;
                            Thanos.vida = Thanos.vida - personagem3.forca;
                            Console.Write($@"
______________________________________________________
|| Você deu um dano de {personagem3.forca} no Thanos
|| E ele te deu um dano de {Thanos.forca}
|| Sua vida atual é de {personagem3.vida}
|| e a vida atual de Thanos é de {Thanos.vida}
||____________________________________________________");
                        }
                        else if (acao == 2)
                        {
                            personagem3.vida = personagem3.vida - Thanos.forca;
                            personagem3.vida = personagem3.vida + personagem3.armadura;
                            Console.WriteLine($@"
______________________________________________________
|| Você deu um dano de 0 no Thanos
|| E ele te deu um dano de {Thanos.forca}
|| Sua vida atual é de {personagem3.vida}
|| e a vida atual de Thanos é de {Thanos.vida}
||____________________________________________________");
                        }
                        if (personagem3.vida <= 0)
                        {
                            Console.WriteLine("\nQue pena Thanos derrotou você de uma maneira implacável e seu plano foi concluído");
                            repeticao = true;
                        }
                        if (Thanos.vida <= 0)
                        {
                            Console.WriteLine("\nParabéns você derrotou o Thanos de uma maneira quase impossível");
                            repeticao = true;
                        }
                    }
                    break;
                case 4:
                    while (repeticao == false)
                    {
                        Console.WriteLine(@"
_____________________________________
|| Você deseja defender ou atacar? ||
||_________________________________||
||         1 - Atacar              ||
||         2 - Defender            ||
||_________________________________||");
                        acao = int.Parse(Console.ReadLine());
                        if (acao == 1)
                        {
                            personagem4.vida = personagem4.vida - Thanos.forca;
                            Thanos.vida = Thanos.vida - personagem4.forca;
                            Console.Write($@"
______________________________________________________
|| Você deu um dano de {personagem4.forca} no Thanos
|| E ele te deu um dano de {Thanos.forca}
|| Sua vida atual é de {personagem4.vida}
|| e a vida atual de Thanos é de {Thanos.vida}
||____________________________________________________");
                        }
                        else if (acao == 2)
                        {
                            personagem4.vida = personagem4.vida - Thanos.forca;
                            personagem4.vida = personagem4.vida + personagem4.armadura;
                            Console.WriteLine($@"
______________________________________________________
|| Você deu um dano de 0 no Thanos
|| E ele te deu um dano de {Thanos.forca}
|| Sua vida atual é de {personagem4.vida}
|| e a vida atual de Thanos é de {Thanos.vida}
||____________________________________________________");
                        }
                        if (personagem4.vida <= 0)
                        {
                            Console.WriteLine("\nQue pena Thanos derrotou você de uma maneira implacável e seu plano foi concluído");
                            repeticao = true;
                        }
                        if (Thanos.vida <= 0)
                        {
                            Console.WriteLine("\nParabéns você derrotou o Thanos de uma maneira quase impossível");
                            repeticao = true;
                        }
                    }
                    break;
                case 5:
                    while (repeticao == false)
                    {
                        Console.WriteLine(@"
_____________________________________
|| Você deseja defender ou atacar? ||
||_________________________________||
||         1 - Atacar              ||
||         2 - Defender            ||
||_________________________________||");
                        acao = int.Parse(Console.ReadLine());
                        if (acao == 1)
                        {
                            personagem5.vida = personagem5.vida - Thanos.forca;
                            Thanos.vida = Thanos.vida - personagem5.forca;
                            Console.Write($@"
______________________________________________________
|| Você deu um dano de {personagem5.forca} no Thanos
|| E ele te deu um dano de {Thanos.forca}
|| Sua vida atual é de {personagem5.vida}
|| e a vida atual de Thanos é de {Thanos.vida}
||____________________________________________________");
                        }
                        else if (acao == 2)
                        {
                            personagem5.vida = personagem5.vida - Thanos.forca;
                            personagem5.vida = personagem5.vida + personagem5.armadura;
                            Console.WriteLine($@"
______________________________________________________
|| Você deu um dano de 0 no Thanos
|| E ele te deu um dano de {Thanos.forca}
|| Sua vida atual é de {personagem5.vida}
|| e a vida atual de Thanos é de {Thanos.vida}
||____________________________________________________");
                        }
                        if (personagem5.vida <= 0)
                        {
                            Console.WriteLine("\nQue pena Thanos derrotou você de uma maneira implacável e seu plano foi concluído");
                            repeticao = true;
                        }
                        if (Thanos.vida <= 0)
                        {
                            Console.WriteLine("\nParabéns você derrotou o Thanos de uma maneira quase impossível");
                            repeticao = true;
                        }
                    }
                    break;
            }

        }

    }
}
