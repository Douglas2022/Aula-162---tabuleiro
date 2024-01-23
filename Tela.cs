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
                for (int j = 0; j < tab.colunas; j++)
                {
                   // Console.Write(tab.peca(i, j) + " ");
                    if (tab.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.peca(i, j) + " ");
                    }
                  
                }
                Console.WriteLine();
            }
        }
    }
}
