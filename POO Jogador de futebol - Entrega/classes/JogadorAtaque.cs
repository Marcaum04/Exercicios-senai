namespace POO_Jogador_de_futebol___Entrega.classes
{
    public class JogadorAtaque : Jogador
    {
        public string Aposentar(){
            if(idade < 35){
                return "você ainda está na idade para jogar";
            }else{
                return "Você está na idade para se aposentar";
            }
        }
    }
}