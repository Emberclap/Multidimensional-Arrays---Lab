namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());

            string[,] matrix = new string[sizeOfMatrix, sizeOfMatrix];
            bool notOccur = true;
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                string col = Console.ReadLine();
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = col[cols].ToString();
                }
            }
            string symbol = Console.ReadLine();
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    if (matrix[rows, cols] == symbol)
                    {
                        Console.WriteLine($"({rows}, {cols})");
                        return;
                    }
                    
                }
            }
            if ( notOccur )
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}