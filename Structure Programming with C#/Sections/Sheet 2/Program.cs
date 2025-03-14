using System;

class Program { 
    static void Main()
    {
        Console.WriteLine("Please Enter a number to inform you if it is odd or even");
        int input =  int.Parse(Console.ReadLine()!);
        OddEvenNumber(input);
    }
    static void OddEvenNumber(int num) 
    {
        if (num % 2 == 0) {
            Console.WriteLine("Even");
        } else {
            Console.WriteLine("Odd");
        }

    }
}