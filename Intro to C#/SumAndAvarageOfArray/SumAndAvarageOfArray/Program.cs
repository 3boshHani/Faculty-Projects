using System;

class Array
{
    public static void Main()
    {
        int arrSize = 50;
        // to read the numbers from user
        int[] arr = new int[arrSize];
        Console.WriteLine("Enter 50 Number");
        // Loop to read 50 numbers from the user
        for (int i = 0; i < arrSize; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        int maximum = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            // to get the sum of numbers
            sum += arr[i];

            // to get the max number
            if (arr[i] > maximum)
            {
                maximum = arr[i];
            }
            
        }
        // to get the average number
        int average = sum / arrSize;

        // to Show the results
        Console.WriteLine($@"
        The Sum is : {sum}
        The Average is : {average}
        The Maximum is: {maximum}");

    }

}
