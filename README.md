# Atividade 01 - Programação Orientada a Objetos

Este repositório contém a resolução da primeira atividade prática da disciplina de Programação Orientada a Objetos (POO). O foco principal é o uso de **Encapsulamento**, **Construtores** e **Lógica de Negócio** dentro de classes.

## Regras Gerais de Implementação

Em todos os exercícios, foram seguidas as seguintes diretrizes:
* **Encapsulamento Estrito**: Todos os atributos foram definidos como `private`.
* **Nomenclatura**: Uso do padrão C# (`_campoPrivado`) para atributos internos.
* **Validação**: Métodos que impedem estados inválidos (ex: saldo menor que o limite ou cura em personagens derrotados).
* **Interatividade**: Cada projeto possui um `Program.cs` que demonstra o funcionamento e as restrições da classe.

---

## Detalhes das Atividades

### 1. Lâmpada Inteligente (`Ex01_Lampada`)
Modelagem de um objeto com controle de estado e intensidade.
* **Regra de Negócio**: O brilho da lâmpada só pode ser ajustado se ela estiver ligada.
* **Métodos**: Alternar estado e ajustar intensidade (0 a 100%).

### 2. Cofre Digital (`Ex02_Cofre`)
Simulação de um sistema de segurança com controle de tentativas.
* **Regra de Negócio**: O cofre permite tentativas de abertura, mas é **bloqueado permanentemente** após 3 erros de senha consecutivos.
* **Segurança**: O atributo de senha é protegido e inacessível fora da classe.

### 3. Conta Corrente Universitária (`Ex03_Conta`)
Sistema financeiro básico com gerenciamento de limite.
* **Regra de Negócio**: Permite que o saldo fique negativo, desde que o débito não ultrapasse o limite de **R$ 500,00**.
* **Status**: A conta monitora automaticamente se o status atual é "Positivo" ou "Negativo".

### 4. Personagem de RPG (`Ex04_RPG`)
Gerenciamento de atributos de vida e evolução de personagem.
* **Regra de Negócio**: Um personagem com 0 de vida é considerado "Derrotado". Personagens nesse estado não podem receber cura.
* **Limites**: A vida é normalizada entre 0 e 100 pontos.

---

## Tecnologias Utilizadas

- Linguagem: C#
- Framework: .NET 10.0
- IDE: Visual Studio Code

## Como Executar

Cada pasta é um projeto de Console independente. Para rodar qualquer um dos testes:

1. Entre na pasta do exercício desejado:
   ```bash
   cd Ex0X_NomeDaAtividade
