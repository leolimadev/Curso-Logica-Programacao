using System;

class Programa
{
    static void Main()
    {
        // Solicita a idade do usuário
        Console.Write("Digite sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        // Verifica as faixas etárias
        if (idade < 12)
        {
            Console.WriteLine("Você é uma criança.");
        }
        else if (idade < 18)
        {
            Console.WriteLine("Você é adolescente.");
        }
        else if (idade < 65)
        {
            Console.WriteLine("Você é adulto.");
        }
        else
        {
            Console.WriteLine("Você é idoso.");
        }
    }
}
