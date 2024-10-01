# If Ternário

O operador ternário em C# é uma maneira simplificada de escrever expressões condicionais, usando menos linhas de código que o tradicional if-else. Ele é útil quando você precisa atribuir um valor ou tomar uma decisão com base em uma única condição. O formato do operador ternário é:

Exemplo:
```csharp
condição ? resultado_se_verdadeiro : resultado_se_falso;
```

## Sintaxe do Operador Ternário

O operador ternário possui três partes:

- Condição: A expressão que será avaliada como true ou false.
- Resultado se Verdadeiro: O valor ou ação retornada se a condição for verdadeira (true).
- Resultado se Falso: O valor ou ação retornada se a condição for falsa (false).


Exemplo Simples

Suponha que você deseja verificar se uma pessoa é maior de idade (18 anos ou mais). Tradicionalmente, isso seria feito com um if-else:

```csharp
int idade = 20;
string resultado;

if (idade >= 18)
{
    resultado = "Maior de idade";
}
else
{
    resultado = "Menor de idade";
}
```

Com o operador ternário, você consegue escrever o mesmo código de forma mais compacta:

```csharp
int idade = 20;
string resultado = (idade >= 18) ? "Maior de idade" : "Menor de idade";
```

Como Funciona

- A expressão (idade >= 18) é a condição.
- Se a condição for verdadeira, a parte antes dos : será usada: "Maior de idade".
- Se for falsa, a parte após os : será usada: "Menor de idade".

### Quando Usar

- Simplicidade: Quando a decisão que você precisa tomar é simples e cabe em uma linha, o operador ternário pode tornar o código mais limpo e legível.
- Atribuição de Valores: É ideal para atribuir valores baseados em condições, como definir uma variável com base em uma condição específica.

### Quando Evitar

- Complexidade: Se a condição ou as ações a serem tomadas são muito complicadas, o operador ternário pode tornar o código difícil de entender. Nesse caso, usar if-else seria mais claro.
