using System;
using Corse.Xadrez_Console.Tabuleiro;

namespace Corse {
    class tela {
        public static void ImprimirTabuleiro(Tabuleiro tab) {
            for(int i=0; i<tab.Linhas; i++) {
                for(int j=0; j<tab.Colunas; j++) {
                    Console.Write(tab.peca[i,j]   + " ");
                    if(tab.peca(i,j) == null) {
                        Console.Write("-");
                    }else {
                        System.Console.Write(tab.peca(i,j) + " ");
                    }
                }

            }
        }
    }
}