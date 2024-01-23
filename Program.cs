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
           PosicaoXadrez pos = new PosicaoXadrez('c',7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.ToPosicao());

            Console.ReadLine();
        }
    }
}

