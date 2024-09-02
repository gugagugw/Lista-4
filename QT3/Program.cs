/*-------------------------------------------------------------------
Questão 3: Cálculo de Dano Crítico
• Contextualização: Em combates, o jogador pode realizar ataques críticos que causam
danos adicionais. O dano causado depende do ataque base, do multiplicador crítico e
da arma utilizada.
• Comando: Crie um programa que receba o valor do ataque base, o multiplicador crítico
(1.5x, 2x, 3x) e o tipo de arma (Espada, Arco, Cajado). Crie uma função que calcule o
dano crítico da seguinte forma:
• Espada: +10 pontos ao dano total.
• Arco: +5 pontos ao dano total.
• Cajado: +15 pontos ao dano total.
• Exiba o dano total causado pelo ataque crítico.
@Lista: 04 - Funções
@Autor: Gustavo Pereira
@Data: 02/09/2024
---------------------------------------------------------------------*/

using System;
class Program {
    static void Main(string[] args) {
        int atk, arma;
        double mult;

        do {
            Console.Clear();
            Console.Write("Digite o ataque base: ");
            int.TryParse(Console.ReadLine(), out atk);
        } while(atk <= 0);

        do {
            Console.Clear();
            Console.Write("Digite o multiplicador crítico da arma: ");
            double.TryParse(Console.ReadLine(), out mult);
        } while(mult <= 0);

        do {
            Console.Clear();
            Console.Write("Digite a arma usada\n\n1-Espada  2-Arco  3-Cajado\n\nEscolha: ");
            int.TryParse(Console.ReadLine(), out arma);
        } while(arma < 1 || arma > 3);

        Dano(atk, mult, arma);

        Console.WriteLine("\nPressione ENTER para fechar o programa");
        Console.ReadKey();
    }

    static void Dano(int atk, double mult, int arma) {
        double dano = 0;

        Console.Clear();

        dano = atk * mult;
        
        if (arma == 1) {
            dano += 10;
        } else if (arma == 2) {
            dano += 5;
        } else {
            dano += 15;
        }

        Console.Write($"O dano total foi de: {dano}");
    }
}