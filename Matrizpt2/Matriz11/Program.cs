using System;

class Program
{
    static void Main(string[] args)
    {
        int linhas = 3;
        int colunas = 3;

        
        double[,] matrizA = new double[linhas, colunas];
        double[,] matrizResultante = new double[linhas, colunas];

        
        Console.WriteLine("Digite os valores da matriz A (3x3):");
        LerMatriz(matrizA, linhas, colunas);

        
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                int somaIndices = i + j + 2; 
                matrizResultante[i, j] = matrizA[i, j] / somaIndices;
            }
        }

        
        Console.WriteLine("Matriz resultante da divisão:");
        ImprimirMatriz(matrizResultante, linhas, colunas);
    }

    
    static void LerMatriz(double[,] matriz, int linhas, int colunas)
    {
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write($"Digite o valor da posição ({i + 1},{j + 1}): ");
                matriz[i, j] = double.Parse(Console.ReadLine());
            }
        }
    }

    
    static void ImprimirMatriz(double[,] matriz, int linhas, int colunas)
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
