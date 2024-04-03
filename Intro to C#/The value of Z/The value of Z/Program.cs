using System;

class ValueOfZ
{
    static void Main()
    {
        // the wanted Z
        int z = 0;
        // the j and i to use in loops 
        int j = 0;
        int i = 0;

        while (i < 6)
        {
            j = 0;
            while (j <= 4)
            {
                z += i * j;
                j++;
            }
            i++;
        } ;
        Console.WriteLine($"Z equals : {z}");
    }
}
