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
        // The part responsible for creating the matrix
        int[,] matrix = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = i + j;
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{matrix[i, j],-4}");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        // The part responsible for creating the lower triangular matrix

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write($"{matrix[i, j],-4}");
            }
            Console.WriteLine();
        }
    }

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));


        
 