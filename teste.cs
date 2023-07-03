using System;

public class Registro
{
    public static void Main()
    {
        Console.WriteLine("Digite sua idade:");
        int idade = int.Parse(Console.ReadLine());

        if (idade >= 18)
        {
            Console.WriteLine("Você pode fazer um cartão.");
        }
        else
        {
            Console.WriteLine("Ainda não pode fazer um cartão de débito e crédito. Somente com autorização do responsável.");

            Console.WriteLine("Digite 'sim' ou 'nao':");
            string escolha = Console.ReadLine();

            if (escolha == "sim")
            {
                Console.WriteLine("Digite o seu CPF:");
                string Senha = Console.ReadLine();
				
                Console.WriteLine("Digite seu nome:");
				string Nome = Console.ReadLine();
				
				Console.WriteLine("Data de nascimento");
				string Idade = Console.ReadLine();
				
				Console.WriteLine("Nome do pai");
				string Pai = Console.ReadLine();
				
				Console.WriteLine("CPF do pai");
				string CPFPai = Console.ReadLine();
				
				Console.WriteLine("Nome da mae");
				string Mae = Console.ReadLine();
				
				Console.WriteLine("CPF da mae");
				string CPFMae = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("obrigado por visitar nosso site");
            }
        }
    }
}