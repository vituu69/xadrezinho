using Corse.Xadrez_Console.Tabuleiro;

namespace Xadrez {
    class PosXadrez {  

        public char Coluna { get; set; }

        public char Linha { get; set; }

        public PosXadrez(char coluna, char linha) {
            this.Linha = linha;
            this.Coluna = coluna;
        }


        public Posicao ToPosicao() {
            return new Posicao(8 - Linha, Coluna - 'a');
        }

        public override string ToString() {
            return "" + Coluna + Linha;
        }
        
        


    }
}