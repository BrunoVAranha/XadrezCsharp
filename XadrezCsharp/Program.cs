using System;
using Tabuleiro;
using Xadrez;

namespace XadrezCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleirocl tab = new Tabuleirocl(8, 8);

                PosicaoXadrez pos = new PosicaoXadrez('a', 1);


                Console.WriteLine(pos.toPosicao());
                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            } 
            Console.ReadLine();
        }
    }
}
