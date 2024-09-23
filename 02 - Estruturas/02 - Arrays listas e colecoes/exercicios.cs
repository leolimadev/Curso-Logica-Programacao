class ProgramaExe01
{
    static void Main()
    {
        int[] numeros = new int[5];
        int soma = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write("Digite um número: ");
            numeros[i] = int.Parse(Console.ReadLine());
            soma += numeros[i];
        }
        Console.WriteLine($"A soma dos números é: {soma}");
    }
}






























class ProgramaExe02
{
    static void Main()
    {
        int[] numeros = { 10, 30, 50, 20, 40 };
        int maior = numeros[0];

        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > maior)
                maior = numeros[i];
        }
        Console.WriteLine($"O maior número é: {maior}");
    }
}






























class ProgramaExe03
{
    static void Main()
    {
        int[] numeros = { 15, 5, 12, 2, 8 };
        Array.Sort(numeros);

        Console.WriteLine("Array ordenado: ");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}






























class ProgramaExe04
{
    static void Main()
    {
        int[] numeros = { 1, 2, 3, 4, 5 };
        Array.Reverse(numeros);

        Console.WriteLine("Array invertido: ");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}






























class ProgramaExe05
{
    static void Main()
    {
        List<int> numeros = new List<int>();
        string entrada;

        while (true)
        {
            Console.Write("Digite um número ou 'sair' para parar: ");
            entrada = Console.ReadLine();
            if (entrada.ToLower() == "sair")
                break;

            numeros.Add(int.Parse(entrada));
        }

        Console.WriteLine("Números digitados: ");
        foreach (int numero in numeros)
            Console.WriteLine(numero);

        numeros.RemoveAll(n => n % 2 == 0);
        Console.WriteLine("Lista sem números pares: ");
        foreach (int numero in numeros)
            Console.WriteLine(numero);

    }
}






























class ProgramaExe06
{
    static void Main()
    {
        List<string> nomes = new List<string> { "Ana", "Carlos", "João", "Maria" };
        Console.Write("Digite um nome para verificar: ");
        string nome = Console.ReadLine();

        if (nomes.Contains(nome))
            Console.WriteLine($"{nome} está na lista.");
        else
            Console.WriteLine($"{nome} não foi encontrado.");

    }
}






























class ProgramaExe07
{
    static void Main()
    {
        Dictionary<string, double> alunos = new Dictionary<string, double>();
        string nome;
        double nota, soma = 0;

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Digite o nome do aluno: ");
            nome = Console.ReadLine();

            Console.Write("Digite a nota do aluno: ");
            nota = double.Parse(Console.ReadLine());

            alunos.Add(nome, nota);
            soma += nota;
        }

        Console.WriteLine($"A média das notas é: {soma / alunos.Count}");

    }
}






























class ProgramaExe08
{
    static void Main()
    {
        Queue<string> filaAtendimento = new Queue<string>();

        filaAtendimento.Enqueue("João");
        filaAtendimento.Enqueue("Maria");
        filaAtendimento.Enqueue("Pedro");

        Console.WriteLine($"{filaAtendimento.Dequeue()} foi atendido.");
    }
}






























class ProgramaExe09
{
    static void Main()
    {
        Stack<string> acoes = new Stack<string>();

        acoes.Push("Escrever Texto");
        acoes.Push("Formatar Texto");
        acoes.Push("Salvar Documento");

        Console.WriteLine($"Desfazer: {acoes.Pop()}");
    }
}






























class ProgramaExe10
{
    static void Main()
    {
        HashSet<int> numerosUnicos = new HashSet<int>();
        int numero;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());
            numerosUnicos.Add(numero);
        }

        Console.WriteLine("Números únicos: ");
        foreach (int num in numerosUnicos)
            Console.WriteLine(num);
    }
}






























