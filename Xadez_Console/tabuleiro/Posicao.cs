using System;

namespace Corse.Xadrez_Console.Tabuleiro { // caso der erro, trocar o namespace: tabuleiro
    class Posicao {
        public int Coluna { get; set; }
        public int Linha { get; set; }

        //construtor com argumentos...
        public Posicao(int linha, int coluna) {
            this.Linha = linha;
            this.Coluna = coluna;
        }

        public override string ToString()
        {
            return Linha + ", " + Coluna;
        }









    }

}