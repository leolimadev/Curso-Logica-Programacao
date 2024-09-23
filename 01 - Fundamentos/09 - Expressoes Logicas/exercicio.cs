using System;

class Programa
{
    static void Main()
    {
        // Solicita o nome do usuário
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        // Solicita a idade do usuário
        Console.Write("Digite sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        // Verifica se o nome não está vazio e se a idade é maior ou igual a 18
        if (!string.IsNullOrEmpty(nome) && idade >= 18)
        {
            Console.WriteLine("Cadastro permitido.");
        }
        else
        {
            Console.WriteLine("Cadastro não permitido.");
        }
    }
}
