﻿

namespace tabuleiro
{
     class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; set; }
        public int  QuantidadeMovimentos { get; protected set; }
        public  Tabuleiro Tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tab)
        {
            Posicao = posicao;
            Cor = cor;
            Tab = tab;
            QuantidadeMovimentos = 0;
        }
    }
}
