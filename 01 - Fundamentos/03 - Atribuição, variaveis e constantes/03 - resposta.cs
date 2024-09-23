using System;

class Programa
{
    static void Main()
    {
        // Variáveis
        string nome = "João";
        int idade = 30;
        double salario = 5000.00;

        // Constante
        const double TAXA_IMPOSTO = 0.1;

        // Cálculo do salário após imposto
        double salarioAposImposto = salario - (salario * TAXA_IMPOSTO);

        // Saída dos valores
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Salário após imposto: {salarioAposImposto}");
    }
}

