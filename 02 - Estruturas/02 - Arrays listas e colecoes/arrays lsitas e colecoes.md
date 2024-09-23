# Retomando conceitos:

## Dicionário

Em termos simples, um dicionário é uma estrutura de dados que permite associar uma chave a um valor. Você pode imaginar isso como um catálogo ou um mapa, onde cada chave corresponde a um valor.

Exemplo prático: Pense em uma lista telefônica. Os nomes das pessoas são as chaves, e os números de telefone correspondem aos valores. Para encontrar o número de telefone de alguém, você procura pelo nome, que é a chave.

### Características principais de um dicionário:

- Chave única: Cada chave no dicionário deve ser única. Isso significa que não pode haver duas entradas com a mesma chave.
- Acesso rápido: Os dicionários oferecem acesso rápido aos valores, uma vez que você pode recuperar diretamente um valor usando a chave.
- Tamanho dinâmico: Assim como as listas, os dicionários em C# se expandem conforme você adiciona mais elementos.

## FIFO

O conceito de FIFO significa que o primeiro elemento que entra é o primeiro a sair. Ele pode ser comparado a uma fila (como a fila do banco ou supermercado), onde a primeira pessoa a entrar na fila é a primeira a ser atendida.

Exemplo prático: Imagine uma fila de pessoas para comprar ingressos de cinema. A primeira pessoa a entrar na fila é a primeira a comprar o ingresso e sair. O último a entrar, será o último a ser atendido.

## FILO

O conceito de FILO significa que o primeiro elemento que entra é o último a sair. Ele pode ser comparado a uma pilha de pratos, onde o primeiro prato colocado na pilha será o último a ser retirado.

Exemplo prático: Imagine empilhar pratos em um restaurante. O primeiro prato colocado na pilha será o último a ser retirado quando forem utilizados.

# Arrays

Um array em C# é uma estrutura de dados que contém elementos de um único tipo, armazenados de forma contínua na memória. Eles têm tamanho fixo, ou seja, você precisa definir o tamanho no momento da criação e não pode ser alterado depois.

Exemplo:
```csharp
int[] numeros = new int[5]; // Array de inteiros com 5 posições
numeros[0] = 1;             // Atribuindo valor à primeira posição
numeros[1] = 2;             // Atribuindo valor à segunda posição
```

Características principais:

- Tamanho fixo.
- Acesso aos elementos por índice (zero-based).
- Boa performance quando o tamanho é conhecido e fixo.

# Listas

As listas são uma coleção mais flexível, do tipo List<T>, que permite armazenar elementos de um mesmo tipo e redimensionar automaticamente conforme a necessidade (diferente dos arrays).

< T > em C# é um tipo genérico, explicaremos mais a frente, mas para listas entenda que T é um tipo que definiremos no momento que queremos utilizar a lista, como no exemplo abaixo:

Exemplo:
```csharp
List<int> numeros = new List<int>(); // Lista de inteiros
numeros.Add(1);  // Adicionando o número 1
numeros.Add(2);  // Adicionando o número 2
```

Características principais:

- Tamanho dinâmico.
- Métodos como Add, Remove, Insert etc., para gerenciar elementos.
- Mais flexível que arrays, porém com overhead de performance quando manipulada frequentemente.

# Coleções Genéricas

Em C#, as coleções são estruturas mais avançadas para trabalhar com conjuntos de dados. Algumas das coleções genéricas mais usadas são Dictionary, Queue, Stack, e HashSet.

Cada uma com uma função específica para resolver um problema específico.

## Dictionary<TKey, TValue>: Armazena pares chave-valor.

Exemplo:
```csharp
Dictionary<int, string> alunos = new Dictionary<int, string>();
alunos.Add(1, "João");
alunos.Add(2, "Maria");
```

### Quando usar um dicionário?

- Quando você precisa associar dados de forma lógica, como nomes e números de telefone, códigos de produto e descrições, ou identificadores de usuário e informações.
- Quando o número de itens cresce, mas o acesso rápido é necessário.

## Queue<T>: Uma fila (FIFO - First In, First Out).

Exemplo:
```csharp
Queue<string> fila = new Queue<string>();
fila.Enqueue("primeiro");
fila.Enqueue("segundo");
```

### Quando utilizar Queue

- Quando temos uma fila de tarefas que devem ser processadas na ordem em que foram recebidas.

## Stack<T>: Uma pilha (LIFO - Last In, First Out).

Exemplo:
```csharp
Stack<string> pilha = new Stack<string>();
pilha.Push("último");
pilha.Push("primeiro");
```

### Quando utilizar Stack

- Sempre que o processamento dos elementos deva seguir uma ordem FILO, como por exemplo Undo (Ctrl + z), onde você precisa pegar o último elemento adicionado para executar o processamento.
- Quando a ordem inversa importa: Se a ordem de processamento ou desfazer é importante, como nas situações de undo, histórico ou avaliação de expressões, Stack é a melhor escolha.
- Quando precisar armazenar temporariamente dados ou estados que são tratados na ordem inversa à de sua inserção.

## HashSet<T>: Armazena elementos únicos, sem duplicatas.

Exemplo:
```csharp
HashSet<int> numeros = new HashSet<int>() { 1, 2, 3, 3 };  // Resultado: 1, 2, 3
```

### Quando utilizar HashSet

- Quando precisar garantir que não haja duplicatas.
- Quando precisar de operações de conjunto (união, interseção, diferença).
- Quando precisar de buscas rápidas para verificar a presença de elementos.
- Quando a ordem dos elementos não é relevante.

## Resumo:

- Arrays:  Estruturas simples, tamanho fixo, eficiente quando o tamanho é conhecido.
- Listas: Dinâmicas, mais fáceis de trabalhar, porém com um pouco mais de custo de performance.
- Coleções Genéricas: Para casos mais específicos e avançados, como dicionários, filas e pilhas.

