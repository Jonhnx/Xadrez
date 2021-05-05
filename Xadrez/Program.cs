using System;
using _Xadrez;
using Board;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez posXadrez = new PosicaoXadrez(1, 'a');
            Console.WriteLine(posXadrez);
            Console.WriteLine(posXadrez.ToPosicao());

            Console.ReadKey();
        }
    }
}
