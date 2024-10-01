# O que são classes?

Classes são definições que representam o objeto que queremos utilizar, padronizando características e ações possíveis de serem executadas.

Por exemplo, uma classe conta corrente pode conter uma característica chamada saldo, que guarda a informação de quanto de dinheiro aquela pessoa tem na sua conta. A classe conta corrente pode adicionar um depósito, ou seja, uma ação possível da classe conta corrente é acrescentar um valor ao saldo da conta da pessoa.

Exemplo:
```csharp

public class ContaCorrente{
    // Saldo é uma característica
    public decimal saldo;

    // Depositar é uma ação
    public void Depositar(decimal valor){
        // Adiciona o valor informado a conta corrente
    }
}
```

# O que é uma instância?

Uma vez que temos uma classe definida e queremos utilizar aquela classe como um objeto, precisamos instanciar aquela classe para que o objeto passe a existir em memória.

# O que é uma Objeto?

Um objeto é uma instância exclusiva de uma classe em memória.

Vamos utilizar o exemplo de conta corrente, porém vamos adicionar uma característica nova, chamada nome. Logo a classe conta corrente terá nome da pessoa que é a proprietária da conta, o saldo que aquela pessoa tem e a opção de adicionar mais dinheiro ao saldo.

```csharp

public class ContaCorrente{
    // Saldo é uma característica
    public decimal saldo;
    // representa a pessoa que é proprietária desta conta
    public string nome;

    // Depositar é uma ação
    public void Depositar(decimal valor){
        saldo += valor;
    }
}

class Programa
{
    static void Main()
    {
        // Neste exemplo, conta corrente é a classe
        // no momento que utilizamos o comando "new" criamos uma instância da classe conta corrente para joão
        var contaDoJoao = new ContaCorrente();
        contaDoJoao.saldo = 5000.00;
        contaDoJoao.nome = "João";

        // agora sobre exclusividade
        var contaDaMaria = new ContaCorrente();
        contaDaMaria.saldo = 8000.00;
        contaDaMaria.nome = "Maria";

        // contaDoJoao é um objeto em memória que foi instanciado da classe conta corrente, este objeto é exclusivo do joão.
        // assim como a contaDaMaria também é uma instância da classe conta corrente, mas exclusiva da maria
    }
}
```


Mais para frente explicaremos o uso com orientação o objetos, porém é importante neste momento que seja fixado como conceito o que são características e o que são ações nas classes, como uma classe é definida em código c#.