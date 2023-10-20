using System;

class Program
{
    static void Main(string[] args)
    {
        int linhas = 10;
        int colunas = 10;

        
        int[,] matriz = new int[linhas, colunas];

        
        Console.WriteLine("Digite os valores da matriz (10x10):");
        LerMatriz(matriz, linhas, colunas);

        
        int linhaDoMaximo = 0;
        int colunaDoMaximo = 0;
        int maximo = matriz[0, 0];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (matriz[i, j] > maximo)
                {
                    maximo = matriz[i, j];
                    linhaDoMaximo = i;
                    colunaDoMaximo = j;
                }
            }
        }

        int minimax = EncontrarMinimax(matriz, linhaDoMaximo);

        
        Console.WriteLine($"O maior elemento da matriz está na linha {linhaDoMaximo + 1}, coluna {colunaDoMaximo + 1} e é {maximo}");
        Console.WriteLine($"O elemento minimax na linha {linhaDoMaximo + 1} é {minimax}");
    }

    
    static void LerMatriz(int[,] matriz, int linhas, int colunas)
    {
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write($"Digite o valor da posição ({i + 1},{j + 1}): ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    
    static int EncontrarMinimax(int[,] matriz, int linhaDoMaximo)
    {
        int colunas = matriz.GetLength(1);
        int minimax = matriz[linhaDoMaximo, 0];

        for (int j = 0; j < colunas; j++)
        {
            if (matriz[linhaDoMaximo, j] < minimax)
            {
                minimax = matriz[linhaDoMaximo, j];
            }
        }

        return minimax;
    }
}
