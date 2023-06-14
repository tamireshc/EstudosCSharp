using tabuleiro;

namespace xadrez;

public class Rei : Peca
{
  public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
  {
  }

  private bool podeMover(Posicao pos)
  {
    Peca p = tab.peca(pos);
    return p == null || p.Cor != Cor;
  }
  public override bool[,] movimentosPossiveis()
  {
    bool[,] mat = new bool[tab.Linhas, tab.Colunas];
    Posicao pos = new Posicao(0, 0);

    //acima
    pos.definirValores(Posicao.Linha - 1, Posicao.Coluna);
    if (tab.posicaovalida(pos) && podeMover(pos))
    {
      mat[pos.Linha, pos.Coluna] = true;
    }

    //ne
    pos.definirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
    if (tab.posicaovalida(pos) && podeMover(pos))
    {
      mat[pos.Linha, pos.Coluna] = true;
    }

    //direita
    pos.definirValores(Posicao.Linha, Posicao.Coluna + 1);
    if (tab.posicaovalida(pos) && podeMover(pos))
    {
      mat[pos.Linha, pos.Coluna] = true;
    }

    //se
    pos.definirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
    if (tab.posicaovalida(pos) && podeMover(pos))
    {
      mat[pos.Linha, pos.Coluna] = true;
    }

    //abaixo
    pos.definirValores(Posicao.Linha + 1, Posicao.Coluna);
    if (tab.posicaovalida(pos) && podeMover(pos))
    {
      mat[pos.Linha, pos.Coluna] = true;
    }
    //so
    pos.definirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
    if (tab.posicaovalida(pos) && podeMover(pos))
    {
      mat[pos.Linha, pos.Coluna] = true;
    }

    //Esquerda
    pos.definirValores(Posicao.Linha, Posicao.Coluna - 1);
    if (tab.posicaovalida(pos) && podeMover(pos))
    {
      mat[pos.Linha, pos.Coluna] = true;
    }

    //No
    pos.definirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
    if (tab.posicaovalida(pos) && podeMover(pos))
    {
      mat[pos.Linha, pos.Coluna] = true;
    }
    return mat;
  }

  public override string ToString()
  {
    return "R";
  }
}