using Corse.Xadrez_Console.Tabuleiro;

namespace Xadrez {
    class Rei : Peca {

        // objeto rei
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor) {}

        public override string ToString() {
            return "R";
        }

    }

}