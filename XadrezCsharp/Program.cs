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

                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(0, 0));
                tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(0, 1));
                tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(1, 1));
                tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(1, 1));


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
