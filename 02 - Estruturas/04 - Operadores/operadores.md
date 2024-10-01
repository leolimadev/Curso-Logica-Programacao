# Sobre

Expressões são construídas a partir de operandos e operadores. Os operadores de uma expressão indicam quais operações aplicar aos operandos.

**Existem três tipos de operadores**:

- Operadores unários. Os operadores unários pegam um operando e usam notação prefixada (como  –x) ou notação pós-fixada (como  x++).
- Operadores binários. Os operadores binários recebem dois operandos e todos usam notação infixa (como x + y).
- Operador ternário. ?:Existe apenas um operador ternário, , que recebe três operandos e usa notação infixa ( c ? x : y).

## Precedência e associatividade do operador

Quando uma expressão contém vários operadores, a precedência dos operadores controla a ordem na qual os operadores individuais são avaliados.

> Por exemplo, a expressão x + y * zé avaliada como x + (y * z)porque o * operador tem precedência maior que o operador binário + . fim da nota

## Alguns dos operadores mais utilizados:

| Categoria | Operadores |
|--|--|
| Primário | x++ x-- new typeof |
| Unário | + - ! ~ ++x --x |
| Multiplicativo | * / % |
| Aditivo | + - |
| Testes relacionais e de tipo | < > <= >= is as |
| Igualdade | == != |
| E lógico | & |
| XOR lógico | ^ |
| OU lógico | \| |
| Condicional E | && |
| Condicional OU | \|\|  |

## Associação de operador

Quando os operadores têm a mesma precedência, a associação dos operadores determina a ordem na qual as operações são executadas:

- Os operadores associativos esquerdos são avaliados na ordem da esquerda para a direita. Com exceção dos operadores de atribuição e do operador de avaliação de nulo, todos os operadores binários são associativos esquerdos. Por exemplo, a + b - c é avaliado como (a + b) - c.

- Os operadores associativos direitos são avaliados na ordem da direita para a esquerda. Os operadores de atribuição, o operador de avaliação de nulo, lambdas e o operador condicional?: são associativos direitos. Por exemplo, x = y = z é avaliado como x = (y = z).

## Avaliação do operando

Sem considerar a relação com a precedência e a associação de operadores, os operandos em uma expressão são avaliados da esquerda para a direita. Os exemplos a seguir demonstram a ordem em que os operadores e os operandos são avaliados:

| Expressão | Ordem de avaliação |
|--|--|
| a + b | a, b, + |
| a + b * c | a, b, c, *, + |
| a / b + c * d | a, b, /, c, d, *, + |
| a / (b + c) * d | a, b, c, +, /, d, * |


Parte deste material foi trazido das seguintes fontes:

https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/

https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/operator-overloading

https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/language-specification/expressions#1243-operator-overloading

https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/boolean-logical-operators