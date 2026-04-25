using Ex01_Lampada;

// Criando a lâmpada (Marca e Tecnologia)
Lampada minhaLampada = new Lampada("Philips", "LED");

Console.WriteLine("--- Estado Inicial ---");
Console.WriteLine(minhaLampada.ToString());

// Testando: Tentar mudar o brilho com ela desligada (não deve funcionar)
minhaLampada.AjustarBrilho(50);
Console.WriteLine("\n--- Tentando mudar brilho com ela desligada ---");
Console.WriteLine(minhaLampada.ToString());

// Ligando e ajustando o brilho
minhaLampada.Alternar();
minhaLampada.AjustarBrilho(75);
Console.WriteLine("\n--- Ligada e com brilho em 75% ---");
Console.WriteLine(minhaLampada.ToString());
