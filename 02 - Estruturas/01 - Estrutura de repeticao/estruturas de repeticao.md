# Explicando Estruturas de Repetição

As estruturas de repetição (ou loops) permitem que um bloco de código seja executado várias vezes de acordo com uma condição específica. Em C#, existem três estruturas principais de repetição:

- for
- while
- do...while

## Estrutura for

O loop for é usado quando sabemos de antemão quantas vezes queremos repetir um bloco de código. Ele é composto por três partes: a inicialização de uma variável, a condição de continuação e a atualização da variável.

Sintaxe:
```csharp
for (inicialização; condição; incremento/decremento)
{
    // Código a ser repetido
}
```

- Inicialização: Normalmente, uma variável de contagem é inicializada (por exemplo, int i = 0).

- Condição: O loop continua enquanto a condição for verdadeira.

- Incremento/Decremento: Após cada iteração, a variável é incrementada ou decrementada.

Exemplo:
```csharp
using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("O valor de i é: " + i);
        }
    }
}
```

**Explicação**: O loop for começa com i = 0 e continua enquanto i for menor que 5. A cada iteração, i é incrementado em 1. O valor de i é impresso em cada iteração.

## Estrutura while

O loop while é utilizado quando não sabemos exatamente quantas vezes o loop deve ser executado, mas continuamos enquanto uma condição for verdadeira.

Sintaxe:

```csharp
while (condição)
{
    // Código a ser repetido
}
```

- Condição: O loop é executado enquanto a condição for verdadeira. Se a condição for falsa logo no início, o loop nem é executado.

Exemplo:

```csharp
using System;

class Program
{
    static void Main()
    {
        int contador = 0;

        while (contador < 5)
        {
            Console.WriteLine("Contagem: " + contador);
            contador++;  // Incremento
        }
    }
}

```

## Estrutura do...while

O loop do-while é semelhante ao while, mas a principal diferença é que ele garante que o bloco de código seja executado pelo menos uma vez, pois a condição é verificada após a execução.

Ou seja, o código de dentro do loop é executado uma vez, depois a condição é validada para saber se segue no loop ou sai dele, diferente do while que valida antes de entrar.

Sintaxe:
```csharp
do
{
    // Código a ser executado
} while (condição);
```

Exemplo:
```csharp
int contador = 0;
do
{
    Console.WriteLine($"Contador: {contador}");
    contador++;
} while (contador < 5);
```

## Interrompendo os laços

- Break: Interrompe a execução do loop antes que a condição se torne falsa e não executa mais o loop.

- Continue: Pula para a próxima iteração do loop sem executar o restante do código.

Exemplo:
```csharp
for (int i = 0; i < 10; i++)
{
    if (i == 5)
        break; // Para o loop quando i for 5
    
    if (i % 2 == 0)
        continue; // Pula os números pares
    
    Console.WriteLine(i); // Exibe somente números ímpares até 5
}
```

## Quando usar cada estrutura:

- For: Quando sabemos o número exato de iterações.
- While: Quando a quantidade de iterações depende de uma condição.
- Do-While: Quando precisamos garantir que o código seja executado ao menos uma vez.

