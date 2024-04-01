using System;

public class Sheet
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Put the numbers a,b and c");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        if (a >= b)
        {
            if (b > c)
            {
                Console.WriteLine("A>B>C");
            }
            else if (a > c)
            {
                Console.WriteLine("A>C>B");
            }
            else
            {
                Console.WriteLine("C>A>B");
            }
        }
        else
        {
            if (a > c)
            {
                Console.WriteLine("B>A>C");
            }
            else if (b > c)
            {
                Console.WriteLine("B>C>A");
            }
            else
            {
                Console.WriteLine("C>B>A");
            }
        }
    }
}