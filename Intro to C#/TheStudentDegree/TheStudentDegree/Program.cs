using System;

public class Sheet
{
    public static void Main(string[] args)
    {12
        Console.WriteLine("Write The Student Degree in 100 percent");
        int degree = int.Parse(Console.ReadLine());
        // The conditon 
        if (degree < 60)
        {
            Console.WriteLine($"You got {degree} %");
            Console.WriteLine("You Failed");
        } else if ( 60 <= degree && degree <= 70 )
        {
            Console.WriteLine($"You got {degree} %");
            Console.WriteLine("You Succeed");
        } else if (70 <= degree && degree <= 80)
        {
            Console.WriteLine($"You got {degree} %");
            Console.WriteLine("You Succeed With Good Degree");
        } else if (80 <= degree && degree <= 90)
        {
            Console.WriteLine($"You got {degree} %");
            Console.WriteLine("You Succeed With Very Good Degree");
        } else 
        {
            Console.WriteLine($"You got {degree} %");
            Console.WriteLine("You Succeed With Excellent Degree");
        }
    }
}