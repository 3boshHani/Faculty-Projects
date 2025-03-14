using System;

class Program
{
    static void Main()
    {
        int n = 3;
        int k = 2;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= k; j++)
            {
                Console.Write($"({i}, {j}) ");
            }
        }
    }
}