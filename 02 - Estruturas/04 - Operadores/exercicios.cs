class ProgramaExe01
{
    static void Main()
    {
        decimal saldo = -50;
        string status = saldo >= 0 ? "Positiva" : "Negativa";
        Console.WriteLine($"A conta está {status}");
    }
}
































class ProgramaExe02
{
    static void Main()
    {
        decimal preco1 = 150;
        decimal preco2 = 120;
        string resultado = preco1 < preco2 ? "Produto 1 é mais barato" : preco1 > preco2 ? "Produto 2 é mais barato" : "Ambos têm o mesmo preço";
        Console.WriteLine(resultado);
    }
}
































class ProgramaExe03
{
    static void Main()
    {
        decimal valorCompra = 600;
        decimal frete = valorCompra > 500 ? 0 : 50;
        Console.WriteLine($"O valor do frete é: R$ {frete}");
    }
}
































class ProgramaExe04
{
    static void Main()
    {
        decimal salario = 3000;
        int performance = 85;
        decimal bonus = performance > 80 ? salario * 0.20M : salario * 0.10M;
        Console.WriteLine($"O bônus será de: R$ {bonus}");
    }
}
































class ProgramaExe05
{
    static void Main()
    {
        int tentativas = 3;
        Console.WriteLine($"Tentativas restantes: {--tentativas}"); // Pré-decremento
        Console.WriteLine($"Tentativas restantes agora: {tentativas}"); // Exibe o valor atualizado
    }
}
































class ProgramaExe06
{
    static void Main()
    {
        int participante1 = 50;
        int participante2 = 45;
        participante1++; // Incrementa a pontuação do participante 1
        string lideranca = participante1 > participante2 ? "Participante 1 lidera" : "Participante 2 lidera";
        Console.WriteLine(lideranca);
    }
}
































class ProgramaExe07
{
    static void Main()
    {
        bool acessoPermitido = true;
        decimal saldoConta = 1000;
        string mensagem = acessoPermitido ? $"Acesso permitido. Saldo: R$ {saldoConta}" : "Acesso negado.";
        Console.WriteLine(mensagem);
    }
}
































class ProgramaExe08
{
    static void Main()
    {
        int estoque = 10;
        Console.WriteLine($"Estoque antes da venda: {estoque}");
        Console.WriteLine($"Estoque atualizado após a venda: {estoque--}"); // Pós-decremento, exibe o valor antes de decrementar
        Console.WriteLine($"Estoque final: {estoque}"); // Exibe o valor atualizado após decrementar
    }
}
































class ProgramaExe09
{
    static void Main()
    {
        int vendas = 98;
        ++vendas; // Pré-incremento
        string resultado = vendas >= 100 ? "Meta atingida!" : "Meta não atingida!";
        Console.WriteLine(resultado);
    }
}
































class ProgramaExe10
{
    static void Main()
    {
        int idade = 17;
        string entrada = idade >= 18 ? "Entrada permitida" : "Entrada negada";
        Console.WriteLine(entrada);
    }
}
