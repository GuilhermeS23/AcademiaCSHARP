using System;

class Program
{
    static void Main(string[] args)
    {
        int ordem = 5;

        
        int[,] matriz = new int[ordem, ordem];

       
        Console.WriteLine("Digite os valores da matriz (5x5):");
        LerMatriz(matriz, ordem);

        
        bool diagonaisIguais = VerificarDiagonaisIguais(matriz, ordem);

        if (diagonaisIguais)
        {
            Console.WriteLine("Os elementos da diagonal principal são iguais aos da diagonal secundária.");
        }
        else
        {
            Console.WriteLine("Os elementos da diagonal principal não são iguais aos da diagonal secundária.");
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

    
    static bool VerificarDiagonaisIguais(int[,] matriz, int ordem)
    {
        for (int i = 0; i < ordem; i++)
        {
            if (matriz[i, i] != matriz[i, ordem - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}
