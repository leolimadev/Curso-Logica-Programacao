# Introdução: O que é Tipagem de Dados?

Tipagem de Dados é a forma como uma linguagem de programação define e trabalha com diferentes tipos de dados (como números, texto, booleanos, etc.).

Em C#, toda variável precisa ter um tipo específico definido quando é declarada, como int, string, bool, etc.

C# não é dinâmico, com por exemplo o javascript, uma vez que você define um tipo você não pode mudar o tipo em tempo de execução isso porque c# é uma linguagem fortemente tipada.

## O que é uma Linguagem Fortemente Tipada?

Linguagem Fortemente Tipada significa que o tipo de uma variável não pode ser alterado após sua declaração. Em C#, uma vez que você define o tipo de uma variável, você só pode armazenar valores compatíveis com esse tipo.

Isso ajuda a evitar erros e a tornar o código mais seguro, já que o compilador verifica o tipo dos dados para evitar operações inválidas.

## Tipos de Dados em C#

Em C#, os tipos de dados são divididos principalmente em dois grupos: tipos primitivos (ou tipos simples) e tipos complexos (ou tipos de referência).

### 1. Tipos Primitivos (Tipos de Valor)

Estes são os tipos básicos que C# oferece e são armazenados diretamente na memória.

- Inteiros (int, long, short, byte):
    - int: Números inteiros entre -2.147.483.648 e 2.147.483.647.
    ```csharp
    int idade = 25;  // Armazena um valor inteiro
    ```  
- Números de Ponto Flutuante (float, double, decimal):
    - float: Números com casas decimais. Precisa do sufixo f.
    ```csharp
    float temperatura = 36.6f;  // Suporta números decimais com menos precisão
    ```  
    - double: Padrão para números com casas decimais.
    ```csharp
    double peso = 70.5;  // Números decimais com precisão maior
    ```  
    - decimal: Usado para cálculos financeiros, com precisão muito alta. Precisa do sufixo m.
    ```csharp
    decimal preco = 19.99m;  // Muito útil para cálculos monetários
    ```  

- Caractere (char):
    - Armazena um único caractere.
    ```csharp
    char inicial = 'J';  // Armazena um único caractere
    ```  
- Texto (string):
    - Armazena uma sequência de caracteres (texto).
    ```csharp
    string nome = "Maria";  // Armazena um texto
    ```  
- Booleano (bool):
    - Pode ter apenas dois valores: true ou false.
    ```csharp
    bool ativo = true;  // Armazena um valor booleano
    ```
### 2. Tipos Complexos (Tipos de Referência)

Estes são tipos que podem referenciar objetos na memória, como arrays, classes, e strings (embora string seja tratada de forma especial).

- Arrays:
    - Uma coleção de elementos do mesmo tipo.
    ```csharp
    int[] numeros = { 1, 2, 3, 4, 5 };  // Array de inteiros
    ```  
- Classes e Objetos:
    - Representam tipos mais complexos que podem conter várias informações.
    ```csharp
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }

    Pessoa pessoa = new Pessoa();
    pessoa.Nome = "Carlos";
    pessoa.Idade = 30;
    ```  

### Por que C# é uma Linguagem Fortemente Tipada?

- Em C#, o tipo de uma variável é definido no momento da declaração e não pode ser alterado. Isso significa que:

    ```csharp
    int numero = 10;
numero = "dez";  // ERRO: Não é possível atribuir uma string a uma variável do tipo int
    ```  

- O exemplo acima resultaria em um erro de compilação, pois você está tentando atribuir uma string ("dez") a uma variável do tipo int.

### Conversão de Tipos (Type Casting) em C#

Apesar de C# ser uma linguagem fortemente tipada, você pode converter explicitamente os tipos, se necessário:

- Conversão Implícita: Quando não há risco de perda de dados.

    ```csharp
    int numero = 10;
double valor = numero;  // Conversão implícita de int para double
    ```  
- Conversão Explícita (Casting): Quando existe o risco de perda de dados ou não são tipos compatíveis.
    
    ```csharp
    double valor = 9.8;
int numero = (int)valor;  // Converte double para int, perdendo a parte decimal
    ```  
- Conversão com Métodos: Usando métodos como Convert.ToInt32().

    ```csharp
    string textoNumero = "123";
    int numero = Convert.ToInt32(textoNumero);  // Converte string para int
    ```  