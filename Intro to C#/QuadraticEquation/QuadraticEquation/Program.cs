using System;

class Factorial
{
    static void Main()
    {
        Console.WriteLine("Write N Then Write K");
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int facN = 1;
        for (int i = 1; i <= n; i++)
        {
            facN *= i;
        };
        int facK = 1;
        for (int i = 1; i <= k; i++)
        {
            facK *= i;
        }
        Console.WriteLine($"The Result for  N! / K! is :{facN/facK}");
    }
}
