/*-------------------------------------------------------------------
Questão 5: Escolha de Habilidade Especial
• Contextualização: No jogo, o jogador pode usar habilidades especiais durante a
batalha. A escolha da habilidade depende da quantidade de mana disponível, do tipo de
inimigo e da distância do alvo.
• Comando: Crie um programa que receba a quantidade de mana, o tipo de inimigo
(Normal, Forte, Boss) e a distância do alvo (em metros). Crie uma função que sugira
qual habilidade usar com base nos seguintes critérios:
• Mana maior que 50: Use Habilidade Poderosa.
• Inimigo Forte ou Boss: +10 mana necessária.
• Distância menor que 10 metros: Reduz a mana necessária em 5.
• Exiba a habilidade sugerida.
@Lista: 04 - Funções
@Autor: Gustavo Pereira
@Data: 02/09/2024
---------------------------------------------------------------------*/

using System;
class Program {
    static void Main(string[] args) {
        int mana, tipo, distancia;

         do {
            Console.Clear();
            Console.Write("Digite a quantidade de mana: ");
            int.TryParse(Console.ReadLine(), out mana);
        } while(mana <= 0);

        do {
            Console.Clear();
            Console.Write("Digite o tipo de inimigo \n\n1-Normal  2-Forte  3-Boss\n\nEscolha: ");
            int.TryParse(Console.ReadLine(), out tipo);
        } while(tipo < 1 || tipo > 3);

        do {
            Console.Clear();
            Console.Write("Digite a distância (em m): ");
            int.TryParse(Console.ReadLine(), out distancia);
        } while(distancia <= 0);

        Gpt(mana, tipo, distancia);

        Console.WriteLine("\nPressione ENTER para fechar o programa");
        Console.ReadKey();
    }

    static void Gpt(int mana, int tipo, int distancia) {        
        Console.Clear();

        if (tipo > 1) {
            mana = mana - 10;
        }

        if (distancia < 10) {
            mana = mana + 5;
        }

        if (mana >= 50) {
            Console.WriteLine("Use a habilidade poderosa");
        } else {
            Console.WriteLine("Use a habilidade básica");
        }
    }
}