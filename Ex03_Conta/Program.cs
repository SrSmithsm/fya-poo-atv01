using Ex03_Conta;
using System.Globalization;

// Configura o console para exibir R$ corretamente
Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

// 1. Criando a conta
ContaUniversitaria minhaConta = new ContaUniversitaria(101, "Seu Nome");

Console.WriteLine("--- Estado Inicial ---");
Console.WriteLine(minhaConta.ToString());

// 2. Testando Depósito
Console.WriteLine("\n--- Depositando R$ 200,00 ---");
minhaConta.Depositar(200);
Console.WriteLine(minhaConta.ToString());

// 3. Testando Saque que usa o limite (Cheque Especial)
Console.WriteLine("\n--- Sacando R$ 500,00 (Usando parte do limite) ---");
if (minhaConta.Sacar(500))
{
    Console.WriteLine("Saque realizado!");
}
Console.WriteLine(minhaConta.ToString());
Console.WriteLine($"Status atual: {minhaConta.StatusConta}");

// 4. Testando Saque acima do Saldo Total (Deve falhar)
Console.WriteLine("\n--- Tentando sacar R$ 1.000,00 (Além do limite disponível) ---");
if (!minhaConta.Sacar(1000))
{
    Console.WriteLine("Saque negado: Saldo insuficiente!");
}