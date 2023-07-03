using System;
using System.Text.RegularExpressions;

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

    public static void IdentificacaoPessoal()
    {

        Console.WriteLine("Digite seu nome completo:");
        string nome = Console.ReadLine();

        Console.WriteLine("Data de nascimento:");
        string dataNascimento = Console.ReadLine();

        Console.WriteLine("Digite a sua nacionalidade:");
        string nacionalidade = Console.ReadLine();

        Console.WriteLine("Digite o seu estado civil:");
        string civil = Console.ReadLine();

        Console.WriteLine("Digite o seu RG:");
        string rg = Console.ReadLine();

        Console.WriteLine("Digite o seu CPF:");
        string cpf = Console.ReadLine();

        Console.WriteLine("Digite seu email:");
        string email = Console.ReadLine();

        bool emailValido = IsValidEmail(email);

        if (emailValido)
        {
            Console.WriteLine("Email válido.");
        }
        else
        {
            Console.WriteLine("Email inválido.");
        }

        Console.WriteLine("Digite o número de telefone:");
        string telefone = Console.ReadLine();
    }

    public static void ParaContato()
    {
        Console.WriteLine("Digite seu email:");
        string email = Console.ReadLine();

        bool emailValido = IsValidEmail(email);

        if (emailValido)
        {
            Console.WriteLine("Email válido.");
        }
        else
        {
            Console.WriteLine("Email inválido.");
        }

        Console.WriteLine("Digite o número de telefone:");
        string telefone = Console.ReadLine();
    }

    public static void Main()
    {
        Console.WriteLine("Digite sua idade:");
        int idade = int.Parse(Console.ReadLine());

        if (idade >= 18)
        {
            Console.WriteLine("Você pode fazer um cartão.");
            IdentificacaoPessoal();
            ParaContato();
        }
        else
        {
            Console.WriteLine("Ainda não pode fazer um cartão de crédito. Somente com autorização do responsável.");

            Console.WriteLine("Digite 'sim' ou 'nao':");
            string escolha = Console.ReadLine();

            if (escolha == "sim")
            {
                IdentificacaoPessoal();
                InformarDadosResponsaveis();
                ParaContato();

                Console.WriteLine("Digite sua senha");
                string senha = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Obrigado por visitar nosso site.");
            }
        }
    }

    static bool IsValidEmail(string email)
    {
        string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
        Regex regex = new Regex(pattern);
        return regex.IsMatch(email);
    }
}
