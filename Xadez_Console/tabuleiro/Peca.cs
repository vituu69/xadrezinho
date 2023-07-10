

namespace Corse.Xadrez_Console.Tabuleiro {
    class Peca {

        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }

        // Qtm == qunatidade de movimento
        public int Qtm { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        //public Peca() {}
        public Peca(Cor cor, Tabuleiro tab) {
            this.posicao = null;
            this.cor = cor;
            this.Qtm = 0;
            this.Tab = tab;
        }

        public Peca(Tabuleiro tab, Cor cor)
        {
            Tab = tab;
            this.cor = cor;
        }
    }
}