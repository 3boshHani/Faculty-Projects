using System;

public class Sheet
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Write The 2 Numbers");
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        //The next step
        Console.WriteLine();
        Console.WriteLine("Type the operation you want to do");
        Console.WriteLine("[ + ]      [ - ]       [ / ]      [ * ]");
        string operate = Console.ReadLine();
        if(operate == "+")
        {
            Console.WriteLine($"The Result is : {x + y}");
        } else if ( operate == "-")
        {
            Console.WriteLine($"The Result is : {x - y}");
        } else if (operate == "*")
        {
            Console.WriteLine($"The Result is : {x * y}");
        } else
            Console.WriteLine($"The Result is : {x / y}");
    }
}