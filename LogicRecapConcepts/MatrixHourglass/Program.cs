using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var n = ConsoleExtension.GetInt("Please enter an integer other than zero: ");
    if (n == 0)
    {
        continue;
    }
    else
    {
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

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));


      