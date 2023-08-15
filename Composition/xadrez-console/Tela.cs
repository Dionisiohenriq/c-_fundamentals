using tabuleiro;

namespace xadrez_console
{
    public class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linha; i++) 
            { 
                for(int j = 0; j < tab.Coluna; j++)
                {
                    if(tab.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }

                        Console.Write(tab.peca(i, j) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
