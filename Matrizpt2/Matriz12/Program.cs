using System;

class Program
{
    static void Main(string[] args)
    {
        int linhas = 4;
        int colunas = 3;

        
        int[,] matriz = new int[linhas, colunas];

        
        Console.WriteLine("Digite os valores da matriz (4x3):");
        LerMatriz(matriz, linhas, colunas);

        
        Console.WriteLine("Valores com soma dos índices (i+j) par:");
        MostrarValoresComSomaPar(matriz, linhas, colunas);
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

    
    static void MostrarValoresComSomaPar(int[,] matriz, int linhas, int colunas)
    {
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if ((i + j) % 2 == 0)
                {
                    Console.Write(matriz[i, j] + " ");
                }
            }
        }
        Console.WriteLine();
    }
}
