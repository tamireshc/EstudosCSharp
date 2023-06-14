using tabuleiro;
namespace xadrez;
public class Torre : Peca
{
  public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
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
    while (tab.posicaovalida(pos) && podeMover(pos))
    {
      mat[pos.Linha, pos.Coluna] = true;
      if (tab.peca(pos) != null && tab.peca(pos).Cor != Cor)
      {
        break;
      }
      pos.Linha = pos.Linha - 1;
    }
    //abaixo
    pos.definirValores(Posicao.Linha + 1, Posicao.Coluna);
    while (tab.posicaovalida(pos) && podeMover(pos))
    {
      mat[pos.Linha, pos.Coluna] = true;
      if (tab.peca(pos) != null && tab.peca(pos).Cor != Cor)
      {
        break;
      }
      pos.Linha = pos.Linha + 1;
    }
    //direita
    pos.definirValores(Posicao.Linha, Posicao.Coluna + 1);
    while (tab.posicaovalida(pos) && podeMover(pos))
    {
      mat[pos.Linha, pos.Coluna] = true;
      if (tab.peca(pos) != null && tab.peca(pos).Cor != Cor)
      {
        break;
      }
      pos.Linha = pos.Linha + 1;
    }
    //esqeurda
    pos.definirValores(Posicao.Linha, Posicao.Coluna + 1);
    while (tab.posicaovalida(pos) && podeMover(pos))
    {
      mat[pos.Linha, pos.Coluna] = true;
      if (tab.peca(pos) != null && tab.peca(pos).Cor != Cor)
      {
        break;
      }
      pos.Linha = pos.Linha - 1;
    }
    return mat;
  }

  public override string ToString()
  {
    return "T";
  }
}