using System;

class Program
{
    public static void Main()
    {
        Console.Write("Please Enter n : ");
        int n = int.Parse(Console.ReadLine()!);

        // Print the first triangle pattern
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
        // Print the second triangle pattern (in reverse)
        for (int i = n - 1; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }       // عبدالرحمن هاني محمود علي = فيزياء و حاسب = اقل من 68
}
