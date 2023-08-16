using tabuleiro;
using Xadrez;
using xadrez_console;

try
{
    PartidaDeXadrez partida = new PartidaDeXadrez();
    while (!partida.Terminada)
    {
        Console.Clear();
        Tela.ImprimirTabuleiro(partida.tab);

        Console.WriteLine();

        Console.Write("Origem: ");
        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();

        Console.Write("Destino: ");
        Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

        partida.ExecutaMovimento(origem, destino);
    }
   
}
catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}


//PosicaoXadrez pos = new PosicaoXadrez('c', 7);
//Console.WriteLine(pos);
//Console.WriteLine(pos.ToPosicao());