using System;

public class Registro
{
	public static void InformarDadosResponsaveis()
    {
        Console.WriteLine("CPF do pai:");
        string cpfPai = Console.ReadLine();

        Console.WriteLine("CPF da mãe:");
        string cpfMae = Console.ReadLine();

        Console.WriteLine("Nome do pai:");
        string pai = Console.ReadLine();

        Console.WriteLine("Nome da mãe:");
        string mae = Console.ReadLine();
    }
	
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
                string cpf = Console.ReadLine();

                Console.WriteLine("Digite seu nome:");
                string nome = Console.ReadLine();

                Console.WriteLine("Data de nascimento:");
                string dataNascimento = Console.ReadLine();

                InformarDadosResponsaveis();
            }
            else
            {
                Console.WriteLine("Obrigado por visitar nosso site.");
            }
        }
    }

    
}
