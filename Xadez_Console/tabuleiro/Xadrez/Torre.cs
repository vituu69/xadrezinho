using Corse.Xadrez_Console.Tabuleiro;

namespace Xadrez {
    class Torre : Peca {

        // objeto rei
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor) {}

        public override string ToString() {
            return "T";
        }

    }

}