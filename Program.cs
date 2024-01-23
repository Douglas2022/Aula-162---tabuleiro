using System;
using tabuleiro;
using xadrez;

namespace Xadrez2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPecas(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPecas(new Torre(tab, Cor.Preta), new Posicao(1, 4));
                tab.ColocarPecas(new Rei(tab, Cor.Preta), new Posicao(0, 2));

                Tela.ImprimirPeca(tab);
                Console.ReadLine();
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
           
            Console.ReadLine();
        }
    }
}
