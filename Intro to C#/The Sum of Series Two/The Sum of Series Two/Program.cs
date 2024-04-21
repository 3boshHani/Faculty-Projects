using System;


class SumOfSeriesTwo
{




    public static void Main()
    {
        int loops = 10;
        double x = 2; // x typed
        double sum = 0;
        double sign = 1; // changes the + to - every time 
      
        // we get x that increases 2 each
        for (int i = 0; i <= loops; i++)
        {
            double term = Math.Pow(x, i) / Factorail(i);
            sum += sign * term;
            sign *= -1;
        }

        Console.WriteLine(sum);
    }
    public static int Factorail(int facNum)
    {
        // first we make a factoial method
        int fac = 1;
        for (int i = 1; i <= facNum; i++)
        {
            fac *= i;
        };
        return fac;
    }
}   