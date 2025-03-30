using System;

class TheRoots
{
    static void Main()
    {
        Console.WriteLine("Write the a,b,c to do the sum (Ax^2 + Bx + C = 0):");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        // El Momaiaz Law // it's law to find if the sum has solution or more
        double momaiaz = Math.Pow(b, 2) - 4 * a * c;

        if (momaiaz > 0)
        {
            // If momaiaz is +, then the roots are real and different
            double root1 = (-b + Math.Sqrt(momaiaz)) / (2 * a);
            double root2 = (-b - Math.Sqrt(momaiaz)) / (2 * a);

            Console.WriteLine($"Root 1 = {root1}");
            Console.WriteLine($"Root 2 = {root2}");
        }
        else if (momaiaz == 0)
        {
            // If momaiaz is 0, then the roots are real and equals
            double root = -b / (2 * a);
            Console.WriteLine($"Roots are real and equal. Root = {root}");
        }
        else
        {
            // If momaiaz is - , then the roots are complex and different
            double real = -b / (2 * a);
            double complex = Math.Sqrt(-momaiaz) / (2 * a);
            Console.WriteLine($"Root 1 = {real} + {complex} ");
            Console.WriteLine($"Root 2 = {real} - {complex} ");
        }
    }
}
