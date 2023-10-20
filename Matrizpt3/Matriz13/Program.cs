using System;

class Program
{
    static void Main(string[] args)
    {
        int ordem = 5;

        
        int[,] matriz = new int[ordem, ordem];

        
        Console.WriteLine("Digite os valores da matriz (5x5):");
        LerMatriz(matriz, ordem);

        
        int somaDiagonalPrincipal = 0;
        for (int i = 0; i < ordem; i++)
        {
            somaDiagonalPrincipal += matriz[i, i];
        }

        
        int somaDiagonalSecundaria = 0;
        for (int i = 0; i < ordem; i++)
        {
            somaDiagonalSecundaria += matriz[i, ordem - i - 1];
        }

        
        if (somaDiagonalPrincipal == somaDiagonalSecundaria)
        {
            Console.WriteLine("A soma da diagonal principal é igual à soma da diagonal secundária.");
        }
        else
        {
            Console.WriteLine("A soma da diagonal principal não é igual à soma da diagonal secundária.");
        }
    }

    
    static void LerMatriz(int[,] matriz, int ordem)
    {
        for (int i = 0; i < ordem; i++)
        {
            for (int j = 0; j < ordem; j++)
            {
                Console.Write($"Digite o valor da posição ({i + 1},{j + 1}): ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }
}
