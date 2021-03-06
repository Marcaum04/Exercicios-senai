using System;

namespace Pilares_POO.classes
{
    public abstract class Cartao : Pagamento
    {
        public string Bandeira;
        public string Numero;
        public string Titular;
        public string CVV;

        public string SalvarCartao(){
            Console.Write("Digite a bandeira do seu cartão: ");
            Bandeira = Console.ReadLine();

            Console.Write("Digite a numeração do seu cartão: ");
            Numero = Console.ReadLine();
            
            Console.Write("Digite o nome do Titular do cartão: ");
            Titular = Console.ReadLine();

            Console.Write("Digite o código de segurança do seu cartão: ");
            CVV = Console.ReadLine();

            return $"Cartão do numero {Numero} salvo com sucesso!";
        }
    }
}