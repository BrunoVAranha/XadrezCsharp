using System;
using Tabuleiro;

namespace XadrezCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleirocl tab = new Tabuleirocl(8, 8);

            Tela.imprimirTabuleiro(tab);
            Console.ReadLine();
        }
    }
}
