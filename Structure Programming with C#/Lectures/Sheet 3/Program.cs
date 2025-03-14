using System;

class Program 
{
    public static void Main() 
    {
        Console.WriteLine("Please input n and r to get the result of C and P");
        int n = int.Parse(Console.ReadLine()!);
        int r = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"C equals = {Fac(n)/Fac(r)*Fac(n-r)}");
        Console.WriteLine($"P equals = {Fac(n)/Fac(n-r)}");
    }

    public static decimal Fac(int x)
    {
        if (x == 0) {
            return 1;
        } else {
            return x * Fac(x-1);
        }
    }
}