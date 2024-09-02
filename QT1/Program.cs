/*-------------------------------------------------------------------
Questão 1: Sistema de Cura de Personagem
* Contextualização: Em um jogo de RPG, o jogador pode usar poções de cura para
recuperar a vida do seu personagem durante a batalha. A quantidade de vida
recuperada depende do tipo de poção, do nível do personagem e da quantidade de
poções usadas.
* Comando: Crie um programa que receba o tipo de poção (Pequena, Média, Grande), o
nível do personagem e a quantidade de poções usadas. Crie uma função que calcule a
quantidade de vida recuperada com base nos seguintes critérios:
* Poção Pequena: 10 pontos de vida por poção.
* Poção Média: 20 pontos de vida por poção.
* Poção Grande: 30 pontos de vida por poção.
* Adicione 5 pontos adicionais para cada nível do personagem acima de 5.
* Exiba o total de vida recuperada.
@Lista: 04 - Funções
@Autor: Gustavo Pereira
@Data: 02/09/2024
---------------------------------------------------------------------*/

using System;
class Program {
    static void Main(string[] args) {
        int tamPocao, nivel, qntPocao;

        do {
            Console.Clear();
            Console.Write("Digite o tamanho da poção\n\n1-Pequena  2-Média  3-Grande\n\nEscolha: ");
            int.TryParse(Console.ReadLine(), out tamPocao);
        } while(tamPocao < 1 || tamPocao > 3);

        do {
            Console.Clear();
            Console.Write("Digite o nível do personagem: ");
            int.TryParse(Console.ReadLine(), out nivel);
        } while(nivel <= 0);

        Console.Clear();
        Console.Write("Digite a quantidade de poções usadas: ");
        int.TryParse(Console.ReadLine(), out qntPocao);

        CalculoVida(tamPocao, nivel, qntPocao);

        Console.WriteLine("\nPressione ENTER para fechar o programa");
        Console.ReadKey();
    }

    static void CalculoVida(int tamanho, int nivelPersonagem, int alcolatra) {
        int vidaRecuperada = 0;

        Console.Clear();

        if(tamanho == 1) {
            vidaRecuperada = vidaRecuperada + (10 * alcolatra);
        } else if (tamanho == 2) {
            vidaRecuperada = vidaRecuperada + (20 * alcolatra);
        } else {
            vidaRecuperada = vidaRecuperada + (30 * alcolatra);
        }

        if(nivelPersonagem > 5) {
            vidaRecuperada = vidaRecuperada + ((nivelPersonagem - 5) * 5);
        }

        Console.WriteLine($"A vida recuperada foi de: {vidaRecuperada}");
    }
}