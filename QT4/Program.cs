/*-------------------------------------------------------------------
Questão 4: Sistema de Resgate em Labirinto
• Contextualização: Em um jogo de exploração, o jogador precisa resgatar aliados
perdidos em um labirinto. O sucesso do resgate depende da quantidade de energia, da
distância até o aliado e do nível de ameaça no caminho.
• Comando: Crie um programa que receba a energia do jogador, a distância até o aliado
(em metros) e o nível de ameaça (baixo, médio, alto). Crie uma função que determine
se o resgate é possível com base nas seguintes condições:
• Energia maior que 50: Resgate bem-sucedido.
• Distância menor que 20 metros: +10 de energia.
• Nível de ameaça:
o Baixo: Sem penalidade.
o Médio: -10 de energia.
o Alto: -20 de energia.
• Exiba se o resgate foi bem-sucedido ou falhou.
@Lista: 04 - Funções
@Autor: Gustavo Pereira
@Data: 02/09/2024
---------------------------------------------------------------------*/

using System;
class Program {
    static void Main(string[] args) {
        int energia, distancia, nivelAmeaca;

        do {
            Console.Clear();
            Console.Write("Digite a energia: ");
            int.TryParse(Console.ReadLine(), out energia);
        } while(energia <= 0);

        do {
            Console.Clear();
            Console.Write("Digite a distância (em m): ");
            int.TryParse(Console.ReadLine(), out distancia);
        } while(distancia <= 0);

        do {
            Console.Clear();
            Console.Write("Digite o nível de ameaça\n\n1-Baixo  2-Médio  3-Alto\n\nEscolha: ");
            int.TryParse(Console.ReadLine(), out nivelAmeaca);
        } while(nivelAmeaca < 1 || nivelAmeaca > 3);

        Resgate(energia, distancia, nivelAmeaca);

        Console.WriteLine("\nPressione ENTER para fechar o programa");
        Console.ReadKey();
    }

    static void Resgate(int energia, int distancia, int ameaca) {
        Console.Clear();

        if (distancia < 20) {
            energia += 10;
        }

        if (energia >= 50) {
            if (ameaca == 2) {
                energia -= 10;
            } else if (ameaca == 3) {
                energia -= 20;
            }
        }

        if (energia >= 50) {
            Console.WriteLine("Resgate bem-sucedido");
        } else {
            Console.WriteLine("Resgate falhou");
        }
    }
}