using Entities.Tabuleiro;
using Xadrez;
using Entities.Tabuleiro.Enums;

namespace ChessProject
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());
            Console.ReadLine();
        }
    }
}
