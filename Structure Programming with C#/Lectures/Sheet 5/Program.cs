using System ;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main()
    {
        int [,] arr = {{1,2,3}, {4,5,6},{7,8,9}};

        // to read the matrix

        Console.WriteLine("The Matrix is :");
        for (int i = 0;i<3; i++)
        {
            for (int j = 0;j < 3; j++)
            {
                Console.Write($"{arr[i,j]} ");
            }
            Console.WriteLine(" ");
        }
        // the methods
        Console.WriteLine($"The Smallest Number In The Matrix Is : {SmallestNum(arr)}"); 
        Console.WriteLine($"The Largest Number In The Matrix Is : {LargestNum(arr)}");
        Console.WriteLine($"The Sum Of The Squares In The Matrix Is : {MatrixSum(arr)}");

        // عبدالرحمن هاني  محمود علي = فيزياء و حاسب = اقل م 68
    }
    public static int SmallestNum(int[,] mat) 
    {
        int min = mat[0,0];
        for(int i = 0; i < 3;i++)
        {
            for (int j = 0;j < 3;j++)
            {
                if(mat[i,j] < min ) 
                {
                    min = mat[i,j];
                }
            }
        }
        return min;
    }
    public static int LargestNum(int[,] mat) 
    {
        int max = mat[0,0];
        for(int i = 0; i < 3;i++)
        {
            for (int j = 0;j < 3;j++)
            {
                if(mat[i,j] > max ) 
                {
                    max = mat[i,j];
                }
            }
        }
        return max;
    }
    public static int MatrixSum(int[,] mat) 
    {
        int sum = 0;
        int n =mat.GetLength(0);
        for(int i = 0; i < n;i++)
        {
            sum += mat[i,i] * mat[i,i];
        }
        return sum;
    }
}