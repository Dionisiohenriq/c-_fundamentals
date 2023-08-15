using tabuleiro;
using Xadrez;
using xadrez_console;

Posicao p = new Posicao(3, 4);

Tabuleiro tab = new Tabuleiro(8, 8);

tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

Tela.ImprimirTabuleiro(tab);