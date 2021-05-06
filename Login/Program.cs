using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome, senha;
	        
	        Console.Write("Digite seu nome de usuário: ");
	        nome = Console.ReadLine();
	        
	        Console.Write("Digite sua senha: ");
	        senha = Console.ReadLine();
	        
	        while(nome == senha){
	            Console.WriteLine("Sua senha não pode ser igual ao seu nome");
	            Console.Write("Digite uma senha diferente do nome de usuário: ");
	            senha = Console.ReadLine();
	            }
            
            Console.WriteLine("Cadastro concluído");
        }
    }
}
