using System;
using System.Data;
using System.Runtime.ExceptionServices;
using xadrez;

namespace tabuleiro
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }
        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }
        public bool ExistePeca(Posicao pos)
        {
            if (ExistePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }
          
            ValidarPosicao(pos);
            return peca(pos) != null;
        }

        public void ColocarPecas(Peca P, Posicao pos)
            
        {
            pecas[pos.linha, pos.coluna] = P;
            P.posicao = pos;
        }
        public bool PosicaoValida(Posicao pos)
        {
            if (pos.linha < 0 || pos.linha >= Linhas || pos.coluna < 0 || pos.coluna >= Colunas)
            {
                return false;
            }
            return true;
        }
        public Peca RetiraPeca(Posicao pos)
        {
            if(peca(pos) == null)
            {
                return null;
            }


        }

        public void ValidarPosicao(Posicao pos)
        {
            if (!PosicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida");
            }
            Peca aux = peca(pos);
            aux.posicao = null;
            peca[pos.linha, pos.coluna] = null;
            return aux;

        }
        public bool PosicaoCalida(Posicao pos)
        {
            if(pos.linha <=0 || pos.linha >=linhas || pos.coluna<0 || pos.coluna <= colunas)
            {
                return false;
            }
            return true;
        }

        public void ValidarPPosicao(Posicao pos)
        {
            if (! PosicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida");
            }
        }
        internal void ColocarPecas(Torre torre)
        {
            throw new NotImplementedException();
        }
       
    }
}
