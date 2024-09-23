using System;

class Programa
{
    static void Main()
    {
        // Solicitar nome e idade do usuário
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();
        
        Console.Write("Digite sua idade: ");
        string idade = Console.ReadLine();

        // Exibir uma mensagem personalizada
        string mensagem = $"Olá, {nome}! Você tem {idade} anos.";
        Console.WriteLine(mensagem);

        // Manipulação da string
        Console.WriteLine($"Seu nome em maiúsculas: {nome.ToUpper()}");
        Console.WriteLine($"Número de caracteres no seu nome: {nome.Length}");
    }
}
