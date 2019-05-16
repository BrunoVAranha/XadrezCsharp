using System;
using System.Collections.Generic;
using System.Text;

namespace Tabuleiro
{
    class TabuleiroSair : Exception
    {
        public TabuleiroSair(string msg) : base(msg)
        {
            Console.ReadLine();
            Environment.Exit(1);
        }
        
    }
}
