using System;
using tabuleiro;

namespace Xadrez2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8,8);
            Tela.ImprimirPeca(tab);
         
            
            Console.ReadLine();
        }
    }
}
