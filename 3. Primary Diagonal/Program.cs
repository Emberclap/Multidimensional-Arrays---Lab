namespace _3._Primary_Diagonal
{
    internal class Program
    {
        static void Main()
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());

            int[,] matrix = new int[sizeOfMatrix, sizeOfMatrix];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                var col = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = col[cols];
                }
            }
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i,i];
            }
            // second diagonal
            //Console.WriteLine(sum);
            //int sum2 = 0;
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    sum2 += matrix[i,matrix.GetLength(1)-i-1];
            //}
            //Console.WriteLine(sum2);
        }       
    }
}