namespace tabuleiro;
public abstract class Peca
{
  public Posicao? Posicao { get; set; }
  public Cor Cor { get; protected set; }
  public int QtdMovimentos { get; protected set; }
  public Tabuleiro tab { get; protected set; }

  public Peca(Tabuleiro _tab, Cor cor)
  {
    Posicao = null;
    tab = _tab;
    Cor = cor;
    QtdMovimentos = 0;
  }

  public void incrementarQtdMovimento()
  {
    QtdMovimentos++;
  }

  public abstract bool[,] movimentosPossiveis();

}