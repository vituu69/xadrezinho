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

        
        public Peca peca(int i, Posicao pos) {
            return pecas[pos.Linha, pos.Coluna];
        }

        
        public void ColocarPeca(Peca p, Posicao pos){
            if(existePeca(pos)) {
                throw new TbEcepiton("ja existe uma peca nessa posicao");
            }
            pecas[pos.Linha, pos.Coluna] = p;
            p.posicao = pos;
        }

        public bool existePeca(Posicao pos) {
            validarPosicao(pos);
            return peca(pos) != null;
        }

        private object peca(Posicao pos)
        {
            throw new NotImplementedException();
        }

        public bool posicaoValida(Posicao pos) {
            if(pos.Linha < 0 || pos.Linha >= Linhas || pos.Coluna<0 || pos.Coluna >= Colunas) {
            }
            return false;
        }
        public void validarPosicao(Posicao pos) {
            if(!posicaoValida(pos)) {
                throw new TbEcepiton("possicao invalida");
            }
        }

        internal string peca(int i, int j)
        {
            throw new NotImplementedException();
        }
    }
}

