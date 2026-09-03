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
        Console.WriteLine("\nORIGINAL MATRIX:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{matrix[i, j],-4}");
            }
            Console.WriteLine();
        }
        // Show the hourglass matrix
        Console.WriteLine("\nHOURGLASS MATRIX:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                // Requirements for being within the hourglass
                bool isHourglass = (j >= i && j <= n - 1 - i) || (j <= i && j >= n - 1 - i);
                if (isHourglass)
                {
                    Console.Write($"{matrix[i, j],-4}");
                }
                else
                {
                    // Print 4 blanks spaces if it's outside the clock
                    Console.Write("    ");
                }
            }
            Console.WriteLine();
        }
    }
}