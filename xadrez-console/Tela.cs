using System;
using tabuleiro;

namespace tabuleiro
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for(int i=0; i < tab.Linhas; i++)
            {
                for(int j=0;j<tab.Colunas; j++)
                {
                    if (tab.Pecas(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.WriteLine(tab.Pecas(i,j) + " ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}

