using System;
using Corse.Xadrez_Console.Tabuleiro;

namespace Corse {
    class tela {
        public static void ImprimirTabuleiro(Tabuleiro tab) {
            for(int i=0; i<tab.Linhas; i++) {
                System.Console.Write(8 - i + " ");
                for(int j=0; j<tab.Colunas; j++) {
                    Console.Write(tab.peca(i,j)   + " ");
                    if(tab.peca(i,j) == null) {
                        Console.Write("-");
                    }else {
                        imprimirPeca(tab.peca(i, j));
                    }
                    System.Console.WriteLine();
                }
                System.Console.WriteLine(" a  b c d e f g h");
            }

        }

        private static void imprimirPeca(string v)
        {
            throw new NotImplementedException();
        }

        public static void imprimirPeca(Peca peca) {
            if(peca.cor == Cor.white) {
                System.Console.Write(peca);
            }else {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }

    }
}