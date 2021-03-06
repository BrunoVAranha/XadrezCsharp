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

        public static void imprimirPartida(PartidaDeXadrez partida)
        {
            imprimirTabuleiro(partida.tab);
            Console.WriteLine();
            Console.WriteLine("Turno: " + partida.turno);
            if (!partida.terminada)
            {
                Console.WriteLine("Aguardando jogada: " + partida.jogadorAtual);
                Console.WriteLine();
                imprimirPecasCapturadas(partida);
                if (partida.xeque)
                {
                    Console.WriteLine("VOCÊ ESTÁ EM XEQUE!");
                }
            }
            else
            {
                Console.WriteLine("XEQUE MATE!");
                Console.WriteLine("Vencedor: " + partida.jogadorAtual);
            }
            }
        
        public static void imprimirPecasCapturadas(PartidaDeXadrez partida)
        {
            Console.WriteLine("Peças capturadas: ");
            Console.Write("Brancas: ");
            imprimirConjunto(partida.pecasCapturadas(Cor.Branca));
            Console.WriteLine();
            Console.Write("Pretas: ");
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            imprimirConjunto(partida.pecasCapturadas(Cor.Preta));
            Console.ForegroundColor = aux;
            Console.WriteLine();
        }

        public static void imprimirConjunto(HashSet<Peca> conjunto)
        {
           
            Console.Write("[");
            foreach(Peca x in conjunto)
            {
                Console.Write(x + " ");
            }
            Console.Write("]");
        }

        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();

            if (s == "sair")
            {
                Console.WriteLine("Pressione Enter para sair.");
                Console.ReadLine();
                Environment.Exit(1);
            }
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
