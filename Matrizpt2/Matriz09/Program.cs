using System;

class Program
{
    static void Main(string[] args)
    {
        
        int[,] matriz = new int[3, 3];

        
        Console.WriteLine("Digite os valores da matriz 3x3:");
        LerMatriz(matriz, 3, 3);

        
        Console.Write("Digite um número para pesquisar na matriz: ");
        int numeroPesquisado = int.Parse(Console.ReadLine());

        
        bool numeroExiste = PesquisarNumero(matriz, 3, 3, numeroPesquisado);

        
        if (numeroExiste)
        {
            Console.WriteLine("O número existe na matriz.");
        }
        else
        {
            Console.WriteLine("Número inexistente na matriz.");
        }
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

   
    static bool PesquisarNumero(int[,] matriz, int linhas, int colunas, int numero)
    {
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (matriz[i, j] == numero)
                {
                    return true; 
                }
            }
        }
        return false; 
    }
}
