using System;

public class Sheet
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Write The Company Information");
        Console.WriteLine();
        Console.WriteLine("Name");
        string name = Console.ReadLine();
        Console.WriteLine("Address");
        string add = Console.ReadLine();
        Console.WriteLine("Phone Number");
        string num = Console.ReadLine();
        Console.WriteLine("Fax Number");
        string fax = Console.ReadLine();
        Console.WriteLine("Website");
        string web = Console.ReadLine();
        Console.WriteLine("Manager");
        string x = Console.ReadLine();
        Console.WriteLine("Write The Manager Information");
        Console.WriteLine();
        Console.WriteLine("Name");
        string name2 = Console.ReadLine();
        Console.WriteLine("Surname");
        string sur = Console.ReadLine();
        Console.WriteLine("Phone Number");
        string num2 = Console.ReadLine();
        Console.WriteLine("Press Enter To continue");
        Console.ReadLine();
        // The Print 
        Console.WriteLine($"Welcome To {name} Company");
        Console.WriteLine($"The address is {add}");
        Console.WriteLine($"Our Number is {num}");
        Console.WriteLine($"Our Fax Number is {fax}");
        Console.WriteLine($"Our Website is {web}");
        Console.WriteLine();
        Console.WriteLine($"The Company's Manager is {name2} {sur}");
        Console.WriteLine($"His Name is {name2}");
        Console.WriteLine($"His Surname is {sur}");
        Console.WriteLine($"His Phone Number is {num2}");
    }
}