using System;
using System.Collections.Generic;
using System.Text;
using Tabuleiro;

namespace Xadrez
{
    class Cavalo : Peca
    {
        public Cavalo(Tabuleirocl tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "C";
        }

        public bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];
            Posicao pos = new Posicao(0, 0);
            //NO
            pos.definirValores(posicao.linha - 2, posicao.coluna -1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //NE
            pos.definirValores(posicao.linha - 2, posicao.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //SO
            pos.definirValores(posicao.linha + 2, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //SE
            pos.definirValores(posicao.linha + 2, posicao.coluna +1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            return mat;
        }
    }
}
