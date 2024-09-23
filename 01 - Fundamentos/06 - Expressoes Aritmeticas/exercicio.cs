using System;

class Programa
{
    static void Main()
    {
        // Solicita dois números ao usuário
        Console.Write("Digite o primeiro número: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        // Realiza operações aritméticas
        int soma = numero1 + numero2;
        int subtracao = numero1 - numero2;
        int multiplicacao = numero1 * numero2;
        double divisao = (double)numero1 / numero2;  // Convertendo para double para obter resultado decimal
        int resto = numero1 % numero2;

        // Exibe os resultados
        Console.WriteLine($"Soma: {soma}");
        Console.WriteLine($"Subtração: {subtracao}");
        Console.WriteLine($"Multiplicação: {multiplicacao}");
        Console.WriteLine($"Divisão: {divisao}");
        Console.WriteLine($"Resto da divisão: {resto}");
    }
}
