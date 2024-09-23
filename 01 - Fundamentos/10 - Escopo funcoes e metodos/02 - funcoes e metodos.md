# Funções e Métodos em C#

Funções e métodos são blocos de código que executam tarefas específicas. Em C#, a diferença entre função e método é que funções normalmente são associadas a linguagens de programação mais procedurais, enquanto métodos são funções associadas a classes. Em C#, usamos o termo "método".

##  O que é um Método?

Um método é uma forma de agrupar código que realiza uma tarefa específica. Ele pode receber dados (parâmetros) e pode ou não retornar um valor.

**Estrutura Básica de um Método em C#**:

```csharp
retorno NomeDoMetodo(tipoParametro parametro)
{
    // Código do método
    return valor; // Opcional, dependendo do tipo de retorno
}
```

- retorno: O tipo de dado que o método retornará (int, string, void, etc.).
- NomeDoMetodo: O nome do método, que deve ser significativo e descrever o que ele faz.
- tipoParametro: O tipo e nome dos parâmetros que o método recebe. Pode ser opcional se o método não precisar de parâmetros.
- return: Opcional, usado apenas se o método retornar um valor.

## Métodos com Retorno

Métodos que retornam um valor precisam especificar o tipo de retorno e usar a instrução return para devolver um valor ao local onde o método foi chamado.

Exemplo: Método com Retorno

```csharp
using System;

class Program
{
    static int Soma(int a, int b)
    {
        return a + b;
    }

    static void Main()
    {
        int resultado = Soma(5, 3);
        Console.WriteLine("O resultado da soma é: " + resultado);
    }
}
```

- Soma: Método que recebe dois parâmetros (a e b) e retorna a soma deles.
- Main: Chama o método Soma passando os valores 5 e 3 como argumentos e armazena o resultado na variável resultado.

## Métodos Sem Retorno (void)

Métodos que não precisam retornar um valor são declarados com o tipo de retorno void.

**Exemplo: Método Sem Retorno**

```csharp
using System;

class Program
{
    static void ExibirMensagem(string mensagem)
    {
        Console.WriteLine(mensagem);
    }

    static void Main()
    {
        ExibirMensagem("Olá, bem-vindo ao programa!");
    }
}
```

- ExibirMensagem: Método que recebe uma string como parâmetro e exibe a mensagem no console. Não possui retorno (void).
- Main: Chama o método ExibirMensagem passando uma string como argumento.

## Métodos com Múltiplos Parâmetros

Você pode definir métodos com múltiplos parâmetros, que são separados por vírgulas.

**Exemplo:**

```csharp
static void MostrarInfo(string nome, int idade)
{
    Console.WriteLine($"Nome: {nome}, Idade: {idade}");
}
```

- MostrarInfo: Método que recebe dois parâmetros (nome e idade) e exibe as informações.

## Chamando Métodos e Passando Argumentos

Para usar um método, você precisa "chamar" ele no seu código, passando os argumentos necessários.

**Exemplo de Chamada de Método:**

```csharp
MostrarInfo("Carlos", 25); // Passando "Carlos" e 25 como argumentos
```

## Escopo e Métodos

Variáveis definidas dentro de um método só podem ser usadas dentro desse método. Isso significa que elas têm escopo de método.

**Exemplo:**

```csharp
static void ExemploEscopo()
{
    int numero = 10; // Escopo local ao método ExemploEscopo
    Console.WriteLine(numero);
}

// ERRO: 'numero' não é acessível fora do método 'ExemploEscopo'
```

## Resumo

- Escopo: Determina onde uma variável é acessível. Pode ser de classe, método ou bloco.
- Métodos: São blocos de código que executam tarefas específicas e podem retornar valores.
- Métodos podem ter parâmetros (dados que eles recebem para processar) e podem retornar valores.

O escopo das variáveis dentro dos métodos é local ao método, ou seja, essas variáveis não podem ser acessadas fora dele.