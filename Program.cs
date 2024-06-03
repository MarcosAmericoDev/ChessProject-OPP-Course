using Entities.Tabuleiro;
using Xadrez;
using Entities.Tabuleiro.Enums;

namespace ChessProject
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();
                Tela.ImprimeTabuleiro(partida.tab);

                
            } catch (TabuleiroException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
