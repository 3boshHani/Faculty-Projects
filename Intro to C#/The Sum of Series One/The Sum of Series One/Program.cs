using System;

class SumSeriesOne
{
    public static void Main()
    {
        // the sum dosn't cross 50000 //
        int sum = 0;
        int n = 1;
        while(sum < 50000)
        {
            sum += (int)Math.Pow(n,n);
            // the n increases by 2 each time 
            n += 2;
            n++;
        }
        Console.WriteLine(sum);
    }

}