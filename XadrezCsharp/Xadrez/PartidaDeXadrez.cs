using System;
using System.Collections.Generic;
using System.Text;
using Tabuleiro;

namespace Xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleirocl tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool terminada { get; private set; }
        public PartidaDeXadrez()
        {
            tab = new Tabuleirocl(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            terminada = false;
            colocarPecas();
        }

        public void executarMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarqtdMovimentos();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
        }

        public void colocarPecas()
        {

            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('c', 1).toPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Branca), new PosicaoXadrez('a', 2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('c', 6).toPosicao());
        }
    }
}
