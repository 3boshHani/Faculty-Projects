using System;

public class Sheet
{
    public static void Main(string[] args)
    {
        Console.WriteLine("To Calculate The Weight on Moon");
        Console.WriteLine("Write The your weight");
        double weight = double.Parse(Console.ReadLine()!);
        double calc = weight*.17;
        Console.WriteLine($"Your weight on moon is {calc} Kg");
    }
}