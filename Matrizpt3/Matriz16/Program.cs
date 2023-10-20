using System;

class Program
{
    static void Main(string[] args)
    {
        int linhasOriginal = 3;
        int colunasOriginal = 4;

        
        int[,] matrizOriginal = new int[linhasOriginal, colunasOriginal];
        int[,] matrizTransposta = new int[colunasOriginal, linhasOriginal];

        
        Console.WriteLine("Digite os valores da matriz original (3x4):");
        LerMatriz(matrizOriginal, linhasOriginal, colunasOriginal);

        
        TransporMatriz(matrizOriginal, matrizTransposta);

        
        Console.WriteLine("Matriz Transposta (4x3):");
        ImprimirMatriz(matrizTransposta, colunasOriginal, linhasOriginal);
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

    
    static void TransporMatriz(int[,] matrizOriginal, int[,] matrizTransposta)
    {
        int linhasOriginal = matrizOriginal.GetLength(0);
        int colunasOriginal = matrizOriginal.GetLength(1);

        for (int i = 0; i < linhasOriginal; i++)
        {
            for (int j = 0; j < colunasOriginal; j++)
            {
                matrizTransposta[j, i] = matrizOriginal[i, j];
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
