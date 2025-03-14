using System;

class Program 
{
    public static void Main()
    {
        Console.WriteLine("Enter Your First Name");
        string fName = Console.ReadLine()!;
        Console.WriteLine("Enter Your Last Name");
        string lName = Console.ReadLine()!;
        Console.WriteLine($"Your Name is {fName} {lName}");
        Console.WriteLine($"Your Inverted Name is {lName} {fName}");
        string fullName = fName +" "+ lName;
        for (int i = fullName.Length - 1; i >= 0; i--) {

            Console.Write(fullName[i]);
            
        }
    }
}