using System;

class Proogram 
{
    static int NumberOfDuplicates(int n ,int[] nums)
    {
        int count = 0;
        for (int i = 0;i < nums.Length; i++)
        {
            if (nums[i] == n)
            {
                count++;
            }
        }
        return count;
    }
    public static void Main()
    {
        // the number that duplicates
        int n = 2;
        // the array that we find the dupcliates in it
        int[] arr = { 1,2,3,4,5,6,7,8,3,3,2,1,4,2};

        Console.WriteLine($"The number {n} can be found {NumberOfDuplicates(n,arr)} times");
    }
}