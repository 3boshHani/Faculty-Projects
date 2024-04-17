

 class Sheet
{
     static void Main()
    {
        Console.WriteLine("Write The 2 Numbers");
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        // The next Step is to compare them to each other 
        if (first > second)
        {
            Console.WriteLine("First Number is greater than Second Number");
        } else if (first < second)
        {
            Console.WriteLine("The First Number is Less than the Second Number");
        } else
        {
            Console.WriteLine("Second Number and First Number are equals");
        }
    }
}