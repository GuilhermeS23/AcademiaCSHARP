int[,] matriz = new int[3, 3];

for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.WriteLine("Informe um valor " +
            "para M[" + i + "][" + j + "]:");
        matriz[i, j] = int.Parse(Console.ReadLine());
    }
}

for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.Write("[" + matriz[i, j] + "]");
    }

    Console.WriteLine();
}


Console.WriteLine();

for (int i = matriz.GetLength(0) - 1; i >= 0; i--)
{
    Console.WriteLine("[" + matriz[i, ((matriz.GetLength(0) - 1) - i)] + "]");
}