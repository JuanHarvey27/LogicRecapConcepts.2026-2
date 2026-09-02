using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the order of the matrix:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = new int[n, n];

        // The part responsible for creating the matrix on the go

        for (int i=0;i<n;i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine($"{i+j,-4}");
            }
            Console.WriteLine();
        }
    }
}