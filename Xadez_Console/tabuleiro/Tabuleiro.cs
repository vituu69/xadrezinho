using System;

namespace Corse.Xadrez_Console.Tabuleiro{

    class Tabuleiro {

        public int Linhas { get; set; }
        public int Colunas { get; set; }
        public Peca[,] pecas;

        public Tabuleiro() {}

        public Tabuleiro(int linhas, int colunas) {
            this.Colunas = colunas;
            this.Linhas = linhas;
            pecas = new Peca[Colunas, Linhas];
        }

        
        public Peca peca(int linha, int coluna) {
            return pecas[linha, coluna];
        }

        public void ColocarPeca(Peca p, Posicao pos){
            pecas[pos.Linha, pos.Coluna] = p;
            p.posicao = pos;
        }
    }
}

