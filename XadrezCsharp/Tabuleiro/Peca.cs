﻿using System;
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

        public Peca(Posicao posicao, Tabuleirocl tab, Cor cor)
        {
            this.posicao = posicao;
            this.tab = tab;
            this.cor = cor;
            this.qtdMovimentos = 0;
        }
    }
}