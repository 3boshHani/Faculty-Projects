using System;

class Program 
{
    static int Sum(int x) 
    {
        return (x==1) ? x : x + (Sum(x-1));
    }
    static void Main()
    {
        Console.WriteLine($"Write the number you want to sum");
        int x = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"The sum of {x}: {Sum(x)}");
    }
}