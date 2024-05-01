using System;

class ReadSumMatrix
{
    public static void Main()
    {

        int[,] a = new int[2, 2];
        int[,] b = new int[2, 2];
        int[,] sum = new int[2, 2];
        int[,] diff = new int[2, 2];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                a[i,j] = int.Parse(Console.ReadLine()!);
            }
        }
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                b[i,j] = int.Parse(Console.ReadLine()!);
            }
        }
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                sum[i,j] = a[i,j] + b[i,j];
            }
        }
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                diff[i,j] = a[i,j] - b[i,j];
            }
        }
        // to show the matrices
        Console.WriteLine("Sum Of The Two Matrices:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(sum[i,j]+" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Differance Of The Two Matrices:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(diff[i,j]+" ");
            }
            Console.WriteLine();
        }
    }
}