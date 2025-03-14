using System ;

class Program 
{
    static void Main() 
    {
        Console.WriteLine("Write a number to get their factorial");
        int number = int.Parse(Console.ReadLine()!);
        Console.WriteLine(Factorial(number));
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