using Ex04_RPG;

// 1. Criando o personagem
Personagem heroi = new Personagem("Smith", "Guerreiro");

Console.WriteLine("--- Início da Jornada ---");
Console.WriteLine(heroi.ToString());

// 2. Simulando combate
Console.WriteLine("\n--- O herói sofreu 40 de dano! ---");
heroi.ReceberDano(40);
Console.WriteLine(heroi.ToString());

// 3. Ganhando experiência
Console.WriteLine("\n--- Vitória! Ganhou 150 XP ---");
heroi.GanharXP(150);
Console.WriteLine(heroi.ToString());

// 4. Testando Cura
Console.WriteLine("\n--- Usando Poção de Cura (+20) ---");
heroi.Curar(20);
Console.WriteLine(heroi.ToString());

// 5. Testando Derrota
Console.WriteLine("\n--- Dano Fatal! ---");
heroi.ReceberDano(100);
Console.WriteLine(heroi.ToString());