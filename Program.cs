using Entities.Tabuleiro;

namespace ChessProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.ImprimeTabuleiro(tab);
        }
    }
}
