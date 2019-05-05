using System;
using Tabuleiro;
using Xadrez;

namespace XadrezCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleirocl tab = new Tabuleirocl(8, 8);

            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0,1 ));


            Tela.imprimirTabuleiro(tab);
            Console.ReadLine();
        }
    }
}
