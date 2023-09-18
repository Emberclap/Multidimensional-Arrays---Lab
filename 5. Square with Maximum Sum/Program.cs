namespace _5._Square_with_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                 .Split(", ")
                 .Select(int.Parse)
                 .ToArray();
            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                var col = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = col[cols];
                }
            }
            int biggestSum = 0;
            int maxSquareRow = 0;
            int maxSquareCol = 0;
            for (int rows = 0; (rows < matrix.GetLength(0)-1); rows++)
            {
                for (int cols = 0; (cols < matrix.GetLength(1)-1); cols++)
                {
                    if (matrix[rows, cols] + matrix[rows, cols+1] + matrix[rows+1, cols] + matrix[rows + 1, cols+1] > biggestSum)
                    {
                        maxSquareRow = rows;
                        maxSquareCol = cols;
                        biggestSum = matrix[rows, cols] + matrix[rows, cols + 1] + matrix[rows + 1, cols] + matrix[rows + 1, cols + 1];
                    }
                }
            }
            Console.WriteLine($"{matrix[maxSquareRow,maxSquareCol]} {matrix[maxSquareRow, maxSquareCol+1]}");
            Console.WriteLine($"{matrix[maxSquareRow+1, maxSquareCol]} {matrix[maxSquareRow+1, maxSquareCol + 1]}");
            Console.WriteLine(biggestSum);
        }
    }
}