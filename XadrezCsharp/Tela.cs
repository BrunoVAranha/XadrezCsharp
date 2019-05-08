﻿using System;
using System.Collections.Generic;
using System.Text;
using Tabuleiro;
using Xadrez;

namespace XadrezCsharp
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleirocl tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write((8 - i) + " ");
                for (int j = 0; j < tab.colunas; j++) { 
                    imprimirPeca(tab.peca(i,j));
                    }
                Console.WriteLine();
            }          
            Console.WriteLine("  a b c d e f g h");
        }
        public static void imprimirTabuleiro(Tabuleirocl tab, bool[,] posicoesPossiveis)
        {
            ConsoleColor cororiginal = Console.BackgroundColor;
            ConsoleColor cornova = ConsoleColor.DarkGray;
            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write((8 - i) + " ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (posicoesPossiveis[i, j])
                    {
                        Console.BackgroundColor = cornova;
                    }
                    else
                    {
                        Console.BackgroundColor = cororiginal;
                    }
                    imprimirPeca(tab.peca(i, j));
                    Console.BackgroundColor = cororiginal;
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = cororiginal;
        }
        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }

        public static void imprimirPeca(Peca peca)
            {
            if (peca == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (peca.cor == Cor.Branca)
                {
                    Console.Write(peca + " ");
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(peca + " ");
                    Console.ForegroundColor = aux;
                }
            }
            }
        }
    }
