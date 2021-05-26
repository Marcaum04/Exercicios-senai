namespace POO_Jogador_de_futebol___Entrega.classes
{
    public class Jogador
    {
        private string nome;
        private int dia;
        private int mes;
        private int ano;
        private string nacionalidade;
        private float altura;
        private float peso;

        public string MostrarDados()
        {
            return $@"
Nome: {nome}
Data de nascimento: {dia}/{mes}/{ano}
Nacionalidade: {nacionalidade}
Altura: {altura}
Peso: {peso}";
        }
    }
}