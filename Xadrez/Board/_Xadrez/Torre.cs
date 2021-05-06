using Board;

namespace _Xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor) { }

        public override string ToString()
        {
            return "T";
        }

        private bool PodeMover(Posicao posicao)
        {
            Peca peca = Tab.Peca(posicao);
            return peca == null || peca.Cor != Cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] movPossiveis = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            //acima
            for(int i = 1; i <= 7; i++)
            {
                pos.DefinirValores(Posicao.Linha - i, Posicao.Coluna);
                if (Tab.PosicaoValida(pos) && PodeMover(pos))
                {
                    movPossiveis[pos.Linha, pos.Coluna] = true;
                }
            }


            //direita
            for(int i = 1; i <= 7;i++)
            {
                pos.DefinirValores(Posicao.Linha, Posicao.Coluna + i);
                if (Tab.PosicaoValida(pos) && PodeMover(pos))
                {
                    movPossiveis[pos.Linha, pos.Coluna] = true;
                }
            }

            //abaixo
            for(int i = 1; i <=7; i++)
            {
                pos.DefinirValores(Posicao.Linha + i, Posicao.Coluna);
                if (Tab.PosicaoValida(pos) && PodeMover(pos))
                {
                    movPossiveis[pos.Linha, pos.Coluna] = true;
                }
            }
            //esquerda
            for(int i = 1; i <=7; i++)
            {
                pos.DefinirValores(Posicao.Linha, Posicao.Coluna - i);
                if (Tab.PosicaoValida(pos) && PodeMover(pos))
                {
                    movPossiveis[pos.Linha, pos.Coluna] = true;
                }
            }

            return movPossiveis;
        }
    }
}