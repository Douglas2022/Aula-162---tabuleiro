using System;
using tabuleiro;
using xadrez;
using Xadrez2.xadrez;

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
                tab.ColocarPecas(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.ColocarPecas(new Rei(tab, Cor.Preta), new Posicao(0, 2));

                tab.ColocarPecas(new Torre(tab, Cor.Brnca), new Posicao(3, 5));


                Tela.ImprimirPeca(tab);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}

