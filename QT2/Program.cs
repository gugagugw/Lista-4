/*-------------------------------------------------------------------
Questão 2: Sistema de Pontuação de Missões
• Contextualização: Em um jogo de aventuras, o jogador ganha pontos ao completar
missões. A pontuação é calculada com base na dificuldade da missão, na quantidade
de inimigos derrotados e no tempo gasto para completar.
• Comando: Crie um programa que receba a dificuldade da missão (Fácil, Média, Difícil),
o número de inimigos derrotados e o tempo gasto (em minutos). Crie uma função para
calcular a pontuação da missão usando os seguintes critérios:
• Fácil: 5 pontos por inimigo, sem penalidade de tempo.
• Média: 10 pontos por inimigo, -2 pontos por minuto acima de 10 minutos.
• Difícil: 15 pontos por inimigo, -5 pontos por minuto acima de 15 minutos.
• Exiba a pontuação final do jogador.
@Lista: 04 - Funções
@Autor: Gustavo Pereira
@Data: 02/09/2024
---------------------------------------------------------------------*/

using System;
class Program {
    static void Main(string[] args) {
        int difMissao, inimigoMorto, tempoGasto;

        do {
            Console.Clear();
            Console.Write("Digite a dificuldade da missão\n\n1-Fácil  2-Média  3-Difícil\n\nEscolha: ");
            int.TryParse(Console.ReadLine(), out difMissao);
        } while(difMissao < 1 || difMissao > 3);

        do {
            Console.Clear();
            Console.Write("Digite o número de inimigos derrotados: ");
            int.TryParse(Console.ReadLine(), out inimigoMorto);
        } while(inimigoMorto <= 0);

        do {
            Console.Clear();
            Console.Write("Digite o tempo da missão (em minutos): ");
            int.TryParse(Console.ReadLine(), out tempoGasto);
        } while(tempoGasto <= 0);

        Pontos(difMissao, inimigoMorto, tempoGasto);

        Console.WriteLine("\nPressione ENTER para fechar o programa");
        Console.ReadKey();
    }

    static void Pontos(int dificuldade, int inimigos, int tempo) {
        int pontos = 0;

        Console.Clear();

        if(dificuldade == 1) {
            pontos = pontos + (5 * inimigos);
        } else if(dificuldade == 2) {
            if (tempo > 10) {
                tempo = tempo - 10;
            } else {
                tempo = 0;
            }
            pontos = (pontos + (inimigos * 10)) - (tempo * 2);
        } else {
            if (tempo > 15) {
                tempo = tempo - 15;
            } else {
                tempo = 0;
            }
            pontos = (pontos + (inimigos * 15)) - (tempo * 5);
        }

        Console.WriteLine($"A pontuação final foi de: {pontos}");
    }
}