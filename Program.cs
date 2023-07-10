using System;
using Corse.Xadrez_Console.Tabuleiro;
using Xadrez;


namespace Corse {
    class Program {
        static void Main(string[] args) {

            try {
                Tabuleiro tab = new Tabuleiro(8, 8);
                tab.ColocarPeca(new Torre(tab, Cor.black), new Posicao(0,0));

                tela.ImprimirTabuleiro(tab);
            }
            catch(TbEcepiton e) {
                System.Console.WriteLine(e.Message);
            }
            

            


        }
    }
}