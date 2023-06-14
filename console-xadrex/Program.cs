﻿using tabuleiro;
using xadrez;
using xadrez_console;


Tabuleiro tab = new Tabuleiro(8, 8);


tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

Tela.imprimitTabuleiro(tab);