using System;

class Program
{
    static void Main(string[] args)
    {
        int linhas = 4;
        int colunas = 4;

        
        double[,] matrizA = new double[linhas, colunas];
        double[,] matrizB = new double[linhas, colunas];

        
        Console.WriteLine("Digite os valores da matriz A:");
        LerMatriz(matrizA, linhas, colunas);

        Console.WriteLine("Digite os valores da matriz B:");
        LerMatriz(matrizB, linhas, colunas);

        
        double mediaA = CalcularMedia(matrizA, linhas, colunas);
        double mediaB = CalcularMedia(matrizB, linhas, colunas);

        
        int abaixoDaMedia = ContarElementosAbaixoDaMedia(matrizA, mediaA, linhas, colunas) + ContarElementosAbaixoDaMedia(matrizB, mediaB, linhas, colunas);
        int acimaDaMedia = ContarElementosAcimaDaMedia(matrizA, mediaA, linhas, colunas) + ContarElementosAcimaDaMedia(matrizB, mediaB, linhas, colunas);
        int naMedia = ContarElementosNaMedia(matrizA, mediaA, linhas, colunas) + ContarElementosNaMedia(matrizB, mediaB, linhas, colunas);

        
        Console.WriteLine($"Média da matriz A: {mediaA}");
        Console.WriteLine($"Média da matriz B: {mediaB}");
        Console.WriteLine($"Elementos abaixo da média: {abaixoDaMedia}");
        Console.WriteLine($"Elementos acima da média: {acimaDaMedia}");
        Console.WriteLine($"Elementos na média: {naMedia}");
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

    
    static double CalcularMedia(double[,] matriz, int linhas, int colunas)
    {
        double soma = 0;
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                soma += matriz[i, j];
            }
        }
        return soma / (linhas * colunas);
    }

    
    static int ContarElementosAbaixoDaMedia(double[,] matriz, double media, int linhas, int colunas)
    {
        int count = 0;
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (matriz[i, j] < media)
                {
                    count++;
                }
            }
        }
        return count;
    }

    
    static int ContarElementosAcimaDaMedia(double[,] matriz, double media, int linhas, int colunas)
    {
        int count = 0;
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (matriz[i, j] > media)
                {
                    count++;
                }
            }
        }
        return count;
    }

    
    static int ContarElementosNaMedia(double[,] matriz, double media, int linhas, int colunas)
    {
        int count = 0;
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (matriz[i, j] == media)
                {
                    count++;
                }
            }
        }
        return count;
    }
}
