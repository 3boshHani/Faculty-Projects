
using System;

public class Sheet
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Put the First number to continue");
        string FirstNum = Console.ReadLine();
        Console.WriteLine("Put the Second number to continue");
        string SecNum = Console.ReadLine();
        // make the input numbers again 
        int First = int.Parse(FirstNum);
        int Sec = int.Parse(SecNum);
        Console.WriteLine($"The + Opreation is {First + Sec}");
        Console.WriteLine($"The - Opreation is {First - Sec}");
        Console.WriteLine($"The * Opreation is {First * Sec}");
        Console.WriteLine($"The / Opreation is {First / Sec}");
    }
}
