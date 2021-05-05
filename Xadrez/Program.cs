using System;
using _Xadrez;
using Board;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(7, 0));
                tab.ColocarPeca(new Bispo(tab, Cor.Preta), new Posicao(7, 1));
                tab.ColocarPeca(new Cavalo(tab, Cor.Preta), new Posicao(7, 2));
                tab.ColocarPeca(new Rainha(tab, Cor.Preta), new Posicao(7, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(7, 4));
                tab.ColocarPeca(new Cavalo(tab, Cor.Preta), new Posicao(7, 5));
                tab.ColocarPeca(new Bispo(tab, Cor.Preta), new Posicao(7, 6));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(7, 7));
                for(int i = 0; i < 8; i++)
                {
                    tab.ColocarPeca(new Peao(tab, Cor.Preta), new Posicao(6, i));
                }


                tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(0, 7));
                tab.ColocarPeca(new Bispo(tab, Cor.Branca), new Posicao(0, 6));
                tab.ColocarPeca(new Cavalo(tab, Cor.Branca), new Posicao(0, 5));
                tab.ColocarPeca(new Rainha(tab, Cor.Branca), new Posicao(0, 4));
                tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(0, 3));
                tab.ColocarPeca(new Cavalo(tab, Cor.Branca), new Posicao(0, 2));
                tab.ColocarPeca(new Bispo(tab, Cor.Branca), new Posicao(0, 1));
                tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(0, 0));
                for (int i = 0; i < 8; i++)
                {
                    tab.ColocarPeca(new Peao(tab, Cor.Branca), new Posicao(1, i));
                }


                Tela.ImprimirTabuleiro(tab);

            }
            catch(BoardException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
