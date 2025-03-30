using System;
class Program 
{
    static int Max(int[] nums)
    {
        int max = nums[0];
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > max)
            {
                max = nums[i];
            }
        }
        return max;
    }
    static void Main()
    {
        int[] nums = { 1, 2,3,5,4,6,7,33,10};
        Console.WriteLine($"the biggest number in the array is : {Max(nums)}");
    }
}