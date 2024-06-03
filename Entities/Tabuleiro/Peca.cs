using Entities.Tabuleiro.Enums;

namespace Entities.Tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QuantDeMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            Posicao = null;
            Cor = cor;
            Tab = tab;
            QuantDeMovimentos = 0;
        }

        public void incrementarQteMovimento()
        {
            QuantDeMovimentos++;
        }
    }
}
