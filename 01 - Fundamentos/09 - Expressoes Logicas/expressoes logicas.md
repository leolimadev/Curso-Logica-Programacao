# O que são Expressões Lógicas 

Expressões lógicas são utilizadas em programação para tomar decisões com base em condições. Essas expressões retornam valores booleanos (true ou false) e são usadas principalmente em estruturas condicionais, como if, else, while, e for. Em C#, as expressões lógicas são construídas usando operadores lógicos para combinar ou inverter condições.

## Como Funcionam as Expressões Lógicas

Em C#, expressões lógicas são criadas usando operadores lógicos, que permitem combinar várias condições para tomar decisões mais complexas. Os principais operadores lógicos em C# são:

- && (E lógico)
- || (OU lógico)
- ! (NÃO lógico)

### Operador && (E Lógico)

O operador && retorna true apenas se todas as condições forem verdadeiras. Se qualquer uma das condições for falsa, ele retorna false.

Sintaxe:

```csharp
if (condicao1 && condicao2)
{
    // Executa este bloco se ambas as condições forem verdadeiras
}
```

Exemplo:

```csharp
int idade = 20;
bool temHabilitacao = true;

if (idade >= 18 && temHabilitacao)
{
    Console.WriteLine("Você pode dirigir.");
}
else
{
    Console.WriteLine("Você não pode dirigir.");
}
```

- No exemplo acima, o programa verifica se a pessoa tem 18 anos ou mais e se tem habilitação. Apenas se ambas as condições forem verdadeiras, o bloco de código dentro do if será executado.

### Operador || (OU Lógico)

O operador || retorna true se pelo menos uma das condições for verdadeira. Ele só retorna false se todas as condições forem falsas.

Sintaxe:

```csharp
if (condicao1 || condicao2)
{
    // Executa este bloco se pelo menos uma das condições for verdadeira
}
```

Exemplo:

```csharp
bool estaChovendo = true;
bool temGuardaChuva = false;

if (estaChovendo || temGuardaChuva)
{
    Console.WriteLine("Leve um guarda-chuva ou procure abrigo.");
}
else
{
    Console.WriteLine("Não precisa se preocupar com chuva.");
}
```

- Neste exemplo, o bloco de código é executado se estaChovendo for verdadeiro ou se temGuardaChuva for verdadeiro.

### Operador ! (NÃO Lógico)

O operador ! é usado para inverter o valor de uma expressão. Se a expressão for true, ele a torna false, e vice-versa.

Sintaxe:

```csharp
if (!condicao)
{
    // Executa este bloco se a condição for falsa
}
```

Exemplo:

```csharp
bool temCarteiraDeMotorista = false;

if (!temCarteiraDeMotorista)
{
    Console.WriteLine("Você não pode dirigir sem carteira de motorista.");
}
```

- Aqui, o operador ! inverte a condição. O bloco de código será executado se temCarteiraDeMotorista for false.

## Combinação de Operadores Lógicos

Operadores lógicos podem ser combinados para formar expressões mais complexas, utilizando parênteses para definir a ordem de avaliação das condições.

Exemplo:

```csharp
int idade = 25;
bool temHabilitacao = true;
bool estaSobrandoTempo = false;

if ((idade >= 18 && temHabilitacao) || estaSobrandoTempo)
{
    Console.WriteLine("Você pode dirigir ou tem tempo sobrando para aprender.");
}
else
{
    Console.WriteLine("Você não pode dirigir ou não tem tempo.");
}
```

- Neste exemplo, o bloco de código dentro do if é executado se a pessoa for maior de 18 e tiver habilitação ou se ela tiver tempo sobrando.

Resumindo

- && (E lógico): Todas as condições precisam ser verdadeiras para a expressão ser true.
- || (OU lógico): Pelo menos uma condição precisa ser verdadeira para a expressão ser true.

- ! (NÃO lógico): Inverte o valor da condição.

