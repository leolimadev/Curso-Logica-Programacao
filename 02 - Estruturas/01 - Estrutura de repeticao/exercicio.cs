using System;

class ProgramaExe01
{
    static void Main()
    {
        decimal saldo = 0;
        decimal valor;

        do
        {
            Console.WriteLine("Digite o valor a ser depositado (ou 0 para sair):");
            valor = Convert.ToDecimal(Console.ReadLine());

            if (valor > 0)
                saldo += valor;

        } while (valor != 0);

        Console.WriteLine($"Saldo final: {saldo:C}");

    }
}































class ProgramaExe02
{
    static void Main()
    {
        decimal saldo = 0;
        Console.WriteLine("Quantas operações você deseja realizar?");
        int operacoes = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < operacoes; i++)
        {
            Console.WriteLine("Digite 'D' para depósito ou 'S' para saque:");
            char tipo = Convert.ToChar(Console.ReadLine().ToUpper());

            Console.WriteLine("Digite o valor:");
            decimal valor = Convert.ToDecimal(Console.ReadLine());

            if (tipo == 'D')
                saldo += valor;
            else if (tipo == 'S' && valor <= saldo)
                saldo -= valor;
            else
                Console.WriteLine("Saque inválido!");

            Console.WriteLine($"Saldo atual: {saldo:C}");
        }

    }
}































class ProgramaExe03
{
    static void Main()
    {
        decimal saldo = 0;

        while (saldo < 10000)
        {
            Console.WriteLine("Digite o valor a ser depositado:");
            decimal valor = Convert.ToDecimal(Console.ReadLine());
            saldo += valor;

            if (saldo >= 10000)
                Console.WriteLine("Limite atingido ou excedido!");
        }

        Console.WriteLine($"Saldo final: {saldo:C}");

    }
}































class ProgramaExe04
{
    static void Main()
    {
        decimal saldo = 0;
        List<string> extrato = new List<string>();

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Digite 'D' para depósito ou 'S' para saque:");
            char tipo = Convert.ToChar(Console.ReadLine().ToUpper());

            Console.WriteLine("Digite o valor:");
            decimal valor = Convert.ToDecimal(Console.ReadLine());

            if (tipo == 'D')
            {
                saldo += valor;
                extrato.Add($"Depósito: {valor:C}");
            }
            else if (tipo == 'S' && valor <= saldo)
            {
                saldo -= valor;
                extrato.Add($"Saque: {valor:C}");
            }
            else
            {
                Console.WriteLine("Operação inválida!");
            }
        }

        Console.WriteLine($"Saldo final: {saldo:C}");
        Console.WriteLine("Extrato:");
        foreach (var linha in extrato)
        {
            Console.WriteLine(linha);
        }

    }
}































class ProgramaExe05
{
    static void Main()
    {
        Console.WriteLine("Digite o saldo inicial:");
        decimal saldo = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Digite a taxa de juros mensal (%):");
        decimal juros = Convert.ToDecimal(Console.ReadLine()) / 100;

        for (int i = 1; i <= 12; i++)
        {
            saldo += saldo * juros;
            Console.WriteLine($"Saldo no mês {i}: {saldo:C}");
        }

    }
}































class ProgramaExe06
{
    static void Main()
    {
        decimal saldo = 5000;
        int saquesRealizados = 0;

        while (saldo >= 100)
        {
            Console.WriteLine("Digite o valor do saque:");
            decimal valor = Convert.ToDecimal(Console.ReadLine());

            if (valor <= saldo)
            {
                saldo -= valor;
                saquesRealizados++;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }

            Console.WriteLine($"Saldo atual: {saldo:C}");
        }

        Console.WriteLine($"Total de saques realizados: {saquesRealizados}");

    }
}































class ProgramaExe07
{
    static void Main()
    {
        decimal conta1 = 5000, conta2 = 3000;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Transferir de Conta 1 para Conta 2? (S/N)");
            char escolha = Convert.ToChar(Console.ReadLine().ToUpper());

            Console.WriteLine("Digite o valor da transferência:");
            decimal valor = Convert.ToDecimal(Console.ReadLine());

            if (escolha == 'S' && valor <= conta1)
            {
                conta1 -= valor;
                conta2 += valor;
            }
            else if (escolha == 'N' && valor <= conta2)
            {
                conta2 -= valor;
                conta1 += valor;
            }
            else
            {
                Console.WriteLine("Transferência inválida.");
            }

            Console.WriteLine($"Saldo Conta 1: {conta1:C}, Saldo Conta 2: {saldo2:C}");
        }

    }
}































class ProgramaExe08
{
    static void Main()
    {
        decimal saldo = 0;

        for (int i = 1; i <= 12; i++)
        {
            saldo += 500;
            Console.WriteLine($"Saldo no mês {i}: {saldo:C}");
        }

    }
}































class ProgramaExe09
{
    static void Main()
    {
        decimal somaSaldo = 0;

        for (int i = 1; i <= 6; i++)
        {
            Console.WriteLine($"Digite o saldo do mês {i}:");
            decimal saldo = Convert.ToDecimal(Console.ReadLine());
            somaSaldo += saldo;
        }

        decimal mediaSaldo = somaSaldo / 6;
        Console.WriteLine($"Média do saldo mensal: {mediaSaldo:C}");

    }
}































class ProgramaExe10
{
    static void Main()
    {
        decimal saldo = 5000;
        int tentativas = 0;

        while (tentativas < 3)
        {
            Console.WriteLine("Digite o valor do saque:");
            decimal valor = Convert.ToDecimal(Console.ReadLine());

            if (valor <= 1000 && valor <= saldo)
            {
                saldo -= valor;
                Console.WriteLine($"Saque realizado. Saldo atual: {saldo:C}");
                break;
            }
            else
            {
                Console.WriteLine("Saque inválido. O valor deve ser até R$ 1000.");
                tentativas++;
            }
        }

        if (tentativas == 3)
            Console.WriteLine("Número máximo de tentativas excedido.");

    }
}