# Simulação de Operações Bancárias

Problema:

Você precisa criar um sistema simples para um banco que gerencia contas de clientes. O sistema deve permitir que os clientes façam depósitos, saques e visualizem o saldo de suas contas. Além disso, o sistema deve suportar transferências entre contas. Cada cliente pode ter várias contas.

Requisitos:
Precisamos de classes que representem pelo menos estas 3 entidades:

- Cliente: Contém informações do cliente, como nome, CPF, e uma lista de contas associadas.
- ContaBancaria: Representa uma conta bancária.
- Banco: Responsável por gerenciar os clientes e as contas. O banco deve permitir a criação de clientes e contas.

Operações:

- Cadastro: Banco deve permitir adicionar um novo cliente.
- Depósito: Um cliente pode depositar um valor positivo em uma conta.
- Saque: Um cliente pode sacar um valor, mas não pode sacar mais do que o saldo disponível.
- Transferência: Um cliente pode transferir dinheiro de uma conta para outra, mas também não pode transferir mais do que o saldo disponível.
- Visualização de Saldo: O cliente pode consultar o saldo de uma conta.

Regras de Negócio:

- Cada conta bancária deve ter um saldo mínimo de R$ 0,00.
- Não é permitido transferir ou sacar valores maiores que o saldo disponível.
- Cada conta é identificada por um número único.

A aplicação deve conseguir:

- Criar um fluxo para cadastrar um cliente, abrir contas bancárias e realizar operações.
- Validar os casos em que o saldo é insuficiente para saque ou transferência.


Exemplo de Fluxo de teste:

1. Criar um cliente "Paulo" com CPF "123.456.789-00".
2. Abrir uma conta bancária para Paulo com saldo inicial de R$ 1000,00.
3. Fazer um depósito de R$ 200,00 na conta de Paulo.
4. Fazer um saque de R$ 500,00.
5. Criar outra conta para Paulo e transferir R$ 300,00 da primeira conta para a segunda.
6. Consultar o saldo das duas contas de Paulo.