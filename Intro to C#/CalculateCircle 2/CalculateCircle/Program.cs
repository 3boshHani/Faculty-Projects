using System;

public class Sheet
{
    public static void Main(string[] args)
    {
        Console.WriteLine("To Calculate The Area");
        Console.WriteLine("Write The Circle Radius");
        double radius = double.Parse(Console.ReadLine());
        double perimeter = Math.Floor(2*Math.PI*radius);
        double area = Math.Floor(Math.PI*Math.Pow(radius,2));
        Console.WriteLine($"The circle area is {area}");
        Console.WriteLine($"The circle area is {perimeter}");
    }
}