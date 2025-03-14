using System;

class Program 
{
    static int Reverse(int x)
    {
        int reversedNumber = 0;

        while (x > 0)
        {
            int lastDigit = x % 10;
            reversedNumber = reversedNumber * 10 + lastDigit;
            x /= 10;
        }
        return reversedNumber;
    }
    static void Main()
    {
        int x = 256;
        Console.WriteLine($"The reversed number of {x} is {Reverse(x)}");
    }
}