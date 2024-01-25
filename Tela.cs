using System;
using tabuleiro;

namespace Xadrez2
{
    class Tela
    {
        public static void ImprimirPeca(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    // Console.Write(tab.peca(i, j) + " ");
                    if (tab.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        //  Console.Write(tab.peca(i, j) + " ");
                        ImprimirPeca(tab.peca(i, j));
                        Console.Write(" ");

                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h ");
        }
        public static void ImprimirPeca(Peca peca)
        {
            if (peca.cor == Cor.Brnca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;

            }
        }

    }
}
