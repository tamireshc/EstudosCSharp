using tabuleiro;
using xadrez;
using xadrez_console;


Tabuleiro tab = new Tabuleiro(8, 8);
PosicaoXadrez pos = new PosicaoXadrez('a', 1);
Console.WriteLine(pos);

try
{
  PartidaDeXadrez partida = new PartidaDeXadrez();
  Tela.imprimitTabuleiro(partida.tab);
  while (!partida.terminada)
  {
    Console.Clear();
    Tela.imprimitTabuleiro(partida.tab);
    Console.WriteLine();
    Console.WriteLine("origem:");
    Posicao origem = Tela.LerPosicaoXadrez().toPosicao();
    Console.WriteLine("Destino:");
    Posicao destino = Tela.LerPosicaoXadrez().toPosicao();

    partida.executaMovimento(origem, destino);


  }
}
catch (TabuleiroException e)
{
  Console.WriteLine(e.Message);
}

