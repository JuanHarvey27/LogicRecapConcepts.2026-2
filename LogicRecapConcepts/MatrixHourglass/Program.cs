using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the order of the matrix:");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0 || n % 2 == 0)
        {
            Console.WriteLine("Please enter a valid positive odd integer:");
        }

        // This is the part responsible for creating the matrix using the formula: Matrix[i, j] = 2*i + j
        int[,] matrix = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = (2 * i) + j;
            }
        }

        // Show the complete original matrix
    }
}
