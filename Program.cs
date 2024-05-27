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
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 4));

                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 1));

                Tela.ImprimeTabuleiro(tab);

                
            } catch (TabuleiroException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
