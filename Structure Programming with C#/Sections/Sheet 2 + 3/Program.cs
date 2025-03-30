using System;

class Program { 
    static void Main()
    {
        Console.WriteLine("Please Enter a number to inform you if it is odd or even and get their factorial");
        int input =  int.Parse(Console.ReadLine()!);
        Console.WriteLine($"The Number is {OddEvenNumber(input)} and their Factorial is {Factorial(input)}");
    }
    static string OddEvenNumber(int num) 
    {
        if (num % 2 == 0) {
            return "Even";
        } else {
            return "Odd";
        }
    }
        static int Factorial(int num) 
    {
        int fac = 1;
        for(int i = 1; i <= num;i++)
        {
            fac *= i;
        }
        return fac;
    }
}