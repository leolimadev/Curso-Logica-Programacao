# Escopo em C#

Escopo define a região do código onde uma variável é acessível. Em C#, existem diferentes níveis de escopo, que determinam a visibilidade das variáveis e objetos dentro do programa. Os principais tipos de escopo são:

- Escopo de Classe: Variáveis definidas dentro de uma classe, mas fora de qualquer método, são acessíveis por todos os métodos dessa classe.

- Escopo de Método: Variáveis definidas dentro de um método são acessíveis apenas dentro daquele método.

- Escopo de Bloco: Variáveis definidas dentro de blocos (if, for, while, { }) só são acessíveis dentro desses blocos.


Exemplo de Escopo em C#:

```csharp
using System;

class Program
{
    // Variável de escopo de classe
    static int numeroGlobal = 10;

    static void Main()
    {
        // Variável de escopo de método
        int numeroLocal = 20;

        if (numeroLocal > 10)
        {
            // Variável de escopo de bloco
            int numeroBloco = 30;
            Console.WriteLine(numeroBloco);  // Acessível apenas dentro deste bloco
        }

        Console.WriteLine(numeroGlobal);  // Acessível em qualquer lugar da classe
        Console.WriteLine(numeroLocal);   // Acessível em qualquer lugar do método
        // Console.WriteLine(numeroBloco); // ERRO: 'numeroBloco' não é acessível fora do bloco 'if'
    }
}
```

- numeroGlobal: A variável é acessível em qualquer lugar dentro da classe Program.
- numeroLocal: A variável é acessível em qualquer lugar dentro do método Main.
- numeroBloco: A variável é acessível apenas dentro do bloco if.







```csharp
```