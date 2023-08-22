using tabuleiro;
using Xadrez;
using xadrez_console;

try
{
    PartidaDeXadrez partida = new PartidaDeXadrez();
    while (!partida.Terminada)
    {
        try
        {
            Console.Clear();
            Tela.ImprimirPartida(partida);

            Console.Write("Origem: ");
            Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
            partida.ValidarPosicaoDeOrigem(origem);


            bool[,] posicoesPossiveis = partida.tab.Peca(origem).MovimentosPossiveis();

            Console.Clear();
            Tela.ImprimirTabuleiro(partida.tab, posicoesPossiveis);

            Console.WriteLine();
            Console.Write("Destino: ");
            Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
            partida.ValidarPosicaoDeDestino(origem, destino);

            partida.RealizaJogada(origem, destino);
        }
        catch(TabuleiroException e)
        {
            Console.WriteLine(e.Message);
            Console.ReadLine();
        }
        
    }

}
catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}


//PosicaoXadrez pos = new PosicaoXadrez('c', 7);
//Console.WriteLine(pos);
//Console.WriteLine(pos.ToPosicao());