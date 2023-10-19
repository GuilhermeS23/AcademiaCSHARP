using System;

class Program
{
    static void Main()
    {
        int maior = int.MinValue;

        for (int i = 0; i < 10; i++) 
        {

            Console.Write($"digite o {i + 1}º Número: ");
            int numero = int.Parse( Console.ReadLine() );

            if(numero > maior)
            {
                maior = numero;
            }

        }

        Console.WriteLine($"O maior número é {maior:F2} ");

    }

}