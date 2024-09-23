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

        // Realiza comparações
        Console.WriteLine($"O primeiro número é igual ao segundo? {numero1 == numero2}");
        Console.WriteLine($"O primeiro número é diferente do segundo? {numero1 != numero2}");
        Console.WriteLine($"O primeiro número é maior que o segundo? {numero1 > numero2}");
        Console.WriteLine($"O primeiro número é menor que o segundo? {numero1 < numero2}");
        Console.WriteLine($"O primeiro número é maior ou igual ao segundo? {numero1 >= numero2}");
        Console.WriteLine($"O primeiro número é menor ou igual ao segundo? {numero1 <= numero2}");
    }
}
