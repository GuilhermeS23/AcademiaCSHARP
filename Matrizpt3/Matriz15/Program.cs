using System;

class Program
{
    static void Main(string[] args)
    {
        int linhas = 4;
        int colunas = 4;

        
        int[,] matrizA = new int[linhas, colunas];
        int[,] matrizB = new int[linhas, colunas];
        int[,] matrizResultante = new int[linhas, colunas];

        
        Console.WriteLine("Digite os valores da primeira matriz (4x4):");
        LerMatriz(matrizA, linhas, colunas);

        
        Console.WriteLine("Digite os valores da segunda matriz (4x4):");
        LerMatriz(matrizB, linhas, colunas);

        
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                matrizResultante[i, j] = matrizA[i, j] + matrizB[i, j];
            }
        }

        
        Console.WriteLine("Matriz Resultante (Soma das duas matrizes):");
        ImprimirMatriz(matrizResultante, linhas, colunas);
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

   
    static void ImprimirMatriz(int[,] matriz, int linhas, int colunas)
    {
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
