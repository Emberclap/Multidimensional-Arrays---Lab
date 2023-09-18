namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowSize = int.Parse(Console.ReadLine());

            int[][] matrix = new int[rowSize][];
            
            for (int rows = 0; rows < rowSize; rows++)
            {
                matrix[rows] = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            }
            string[] commands = Console.ReadLine()
                .Split()
                .ToArray();
            while (commands[0] != "END")
            {
                int rowIndex = int.Parse(commands[1]);
                int colIndex = int.Parse(commands[2]);
                int value = int.Parse(commands[3]);
                if (rowIndex < 0 || rowIndex >= matrix.Length || colIndex < 0 || matrix[rowIndex].Length <= colIndex)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if (commands[0] == "Add")
                    {
                        matrix[rowIndex][colIndex] += value;
                    }
                    else
                    {
                        matrix[rowIndex][colIndex] -= value;
                    }
                }

                commands = Console.ReadLine()
                 .Split()
                 .ToArray();
            }
            foreach (int[] row in matrix)
            {
                for (int col = 0; col < row.Length; col++)
                {
                    Console.Write(row[col]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}