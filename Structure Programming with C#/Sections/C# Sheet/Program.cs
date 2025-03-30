using System;

public class Program {
    public static void Main()
    {
        // the array
        int[]  arr = {1,2,3,4,5,6,7,8,9,10,11};
        int evenCount = 0 ;
        int oddCount = 0 ;
        for (int i = 0; i < arr.Length; i++)
        {       
            if (arr[i] % 2 == 0) {
                evenCount++;
            } else {
                oddCount++;
            }
        }
        Console.WriteLine($"The Even Numbers = {evenCount}");
        Console.WriteLine($"The Odd Numbers = {oddCount}");
    }
}