using System;
using System.Collections.Generic;
using System.Text;

namespace Tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set ; }
        public Cor cor { get; protected set; }
        public int qtdMovimentos { get; protected set ;}
        public Tabuleirocl tab;

        public Peca(Tabuleirocl tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qtdMovimentos = 0;
        }

        public void incrementarqtdMovimentos()
        {
            qtdMovimentos++;
        }
    }
}
