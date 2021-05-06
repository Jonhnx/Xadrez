using Board;

namespace _Xadrez
{
    class Cavalo : Peca
    {
        public Cavalo(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor) { }

        public override string ToString()
        {
            return "C";
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

            //pra cima e pra direita
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                pos.DefinirValores(pos.Linha - 1, pos.Coluna);
                if (Tab.PosicaoValida(pos) && PodeMover(pos))
                {
                    pos.DefinirValores(pos.Linha, pos.Coluna + 1);
                    if (Tab.PosicaoValida(pos) && PodeMover(pos))
                    {
                        movPossiveis[pos.Linha, pos.Coluna] = true;
                    }
                }
            }

            //pra cima e pra esquerda
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                pos.DefinirValores(pos.Linha - 1, pos.Coluna);
                if (Tab.PosicaoValida(pos) && PodeMover(pos))
                {
                    pos.DefinirValores(pos.Linha, pos.Coluna - 1);
                    if (Tab.PosicaoValida(pos) && PodeMover(pos))
                    {
                        movPossiveis[pos.Linha, pos.Coluna] = true;
                    }
                }
            }

            //direita e pra cima
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                pos.DefinirValores(pos.Linha, pos.Coluna + 1);
                if (Tab.PosicaoValida(pos) && PodeMover(pos))
                {
                    pos.DefinirValores(pos.Linha - 1, pos.Coluna);
                    if (Tab.PosicaoValida(pos) && PodeMover(pos))
                    {
                        movPossiveis[pos.Linha, pos.Coluna] = true;
                    }
                }
            }

            //direita e pra baixo
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                pos.DefinirValores(pos.Linha, pos.Coluna + 1);
                if (Tab.PosicaoValida(pos) && PodeMover(pos))
                {
                    pos.DefinirValores(pos.Linha + 1, pos.Coluna);
                    if (Tab.PosicaoValida(pos) && PodeMover(pos))
                    {
                        movPossiveis[pos.Linha, pos.Coluna] = true;
                    }
                }
            }

            //pra baixo e pra direita
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                pos.DefinirValores(pos.Linha + 1, pos.Coluna);
                if (Tab.PosicaoValida(pos) && PodeMover(pos))
                {
                    pos.DefinirValores(pos.Linha, pos.Coluna + 1);
                    if (Tab.PosicaoValida(pos) && PodeMover(pos))
                    {
                        movPossiveis[pos.Linha, pos.Coluna] = true;
                    }
                }
            }

            //pra baixo e pra esquerda
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                pos.DefinirValores(pos.Linha + 1, pos.Coluna);
                if (Tab.PosicaoValida(pos) && PodeMover(pos))
                {
                    pos.DefinirValores(pos.Linha, pos.Coluna -1);
                    if (Tab.PosicaoValida(pos) && PodeMover(pos))
                    {
                        movPossiveis[pos.Linha, pos.Coluna] = true;
                    }
                }
            }

            //esquerda e pra cima
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                pos.DefinirValores(pos.Linha, pos.Coluna - 1);
                if (Tab.PosicaoValida(pos) && PodeMover(pos))
                {
                    pos.DefinirValores(pos.Linha - 1, pos.Coluna);
                    if (Tab.PosicaoValida(pos) && PodeMover(pos))
                    {
                        movPossiveis[pos.Linha, pos.Coluna] = true;
                    }
                }
            }

            //esquerda e pra cima
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                pos.DefinirValores(pos.Linha, pos.Coluna - 1);
                if (Tab.PosicaoValida(pos) && PodeMover(pos))
                {
                    pos.DefinirValores(pos.Linha + 1, pos.Coluna);
                    if (Tab.PosicaoValida(pos) && PodeMover(pos))
                    {
                        movPossiveis[pos.Linha, pos.Coluna] = true;
                    }
                }
            }

            return movPossiveis;
        }

    }
}