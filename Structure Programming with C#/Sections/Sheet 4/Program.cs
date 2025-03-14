using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter n");
        int n = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Enter k");
        int k = int.Parse(Console.ReadLine()!);

        int[] pair = new int[k];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                pair[0] = i + 1;
                pair[1] = j + 1;

                Console.Write($"({pair[0]},{pair[1]}) ");
            }
        }
    }
}