using Ex02_Cofre;

// 1. Criando o cofre
CofreDigital meuCofre = new CofreDigital("Sr. Smith", "senha123");

Console.WriteLine("--- Estado Inicial ---");
Console.WriteLine(meuCofre.ToString());

// 2. Testando senha errada para ver o contador de erros
Console.WriteLine("\n--- Teste 1: Senha Errada ---");
Console.WriteLine(meuCofre.Abrir("errada"));
Console.WriteLine(meuCofre.ToString());

// 3. Testando senha correta
Console.WriteLine("\n--- Teste 2: Senha Correta ---");
Console.WriteLine(meuCofre.Abrir("senha123"));
Console.WriteLine(meuCofre.ToString());

// 4. Fechando para testar o bloqueio
meuCofre.Fechar();
Console.WriteLine("\n--- Teste 3: Errando 3 vezes para bloquear ---");
meuCofre.Abrir("erro1");
meuCofre.Abrir("erro2");
string resultadoFinal = meuCofre.Abrir("erro3");

Console.WriteLine($"Resultado da 3ª tentativa: {resultadoFinal}");
Console.WriteLine(meuCofre.ToString());