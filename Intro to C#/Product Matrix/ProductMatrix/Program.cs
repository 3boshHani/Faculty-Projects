using System;

class ProductMatrix
{
    public static void Main() {

        // row in matrix one should equal coloum in matrix two to multiply //

        int[,] s = {{2,4},{6,8}};
        int[,] p = {{1,3},{5,7}};
        int[,] result = new int[2,2];
        // Matrix One
        for (int i = 0;i<2;i++)
        {
            for (int j = 0;j<2;j++)
            {
                Console.Write(s[i, j] + " ");
            } 
            Console.WriteLine();   
        } 
        Console.WriteLine(" *");
        // Matrix Two
        for (int i = 0;i<2;i++)
        {
            for (int j = 0;j<2;j++)
            {
                Console.Write(p[i, j] + " ");
            } 
            Console.WriteLine();   
        } 
        Console.WriteLine(" =");
        // the multiply
        for (int i = 0;i<2;i++)
        {
            for (int j = 0;j<2;j++)
            {
                result[i,j] = s[i,j] * p[i,j];
            }   
        } 
        // show result
        for (int i = 0;i<2;i++)
        {
            for (int j = 0;j<2;j++)
            {
                Console.Write(result[i, j] + " ");
            } 
            Console.WriteLine();   
        } 
    }
}