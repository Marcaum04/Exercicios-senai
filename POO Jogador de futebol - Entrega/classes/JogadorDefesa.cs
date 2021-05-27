namespace POO_Jogador_de_futebol___Entrega.classes
{
    public class JogadorDefesa : Jogador
    {
        public string Aposentar()
        {
            if (idade < 40)
            {
                return "você ainda está na idade para jogar";
            }
            else
            {
                return "É recomendado que você se aposente na sua idade atual";

            }
        }
    }
}