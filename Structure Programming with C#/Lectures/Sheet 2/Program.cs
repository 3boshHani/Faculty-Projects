using System;

class MonthPeriod
{
    static void Main()
    {
        string[] months = {
            "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        };

        Console.WriteLine("Welcome! Let's calculate the period between two months.");
        
        Console.Write("Enter the number for the first month (1-12): ");
        int firstMonth = int.Parse(Console.ReadLine()!);

        Console.Write("Enter the number for the second month (1-12): ");
        int secondMonth = int.Parse(Console.ReadLine()!);
// عبدالرحمن هاني محمود علي = فيزياء و حاسب = اقل من 68
        while (firstMonth < 1 || firstMonth > 12 || secondMonth < 1 || secondMonth > 12)
        {
            Console.WriteLine("Please enter valid numbers between 1 and 12.");
            Console.Write("First month: ");
            firstMonth = int.Parse(Console.ReadLine()!);
            Console.Write("Second month: ");
            secondMonth = int.Parse(Console.ReadLine()!);
        }
        int totalMonths = (secondMonth - firstMonth + 12) % 12 + 1;
    
        Console.WriteLine($"Period: From {months[firstMonth - 1]} to {months[secondMonth - 1]}.");
        Console.WriteLine($"Total months in this period: {totalMonths}");
    }
    public static void Sum(int a) {
        // method logic
    }

Sum();

}

