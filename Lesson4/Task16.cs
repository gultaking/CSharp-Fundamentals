namespace CSharpFundamentals.Lesson4;

public class Task16
{
    public void PrintMatrixTests()
    {
        try
        {
            Console.Write("Enter row size: ");
            int rowSize = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter column size: ");
            int columnSize = Convert.ToInt32(Console.ReadLine());

            if (rowSize <= 0 || columnSize <= 0)
            {
                throw new Exception("The row and column size of an array cannot be zero or negative!");
            }

            if (rowSize == 1 && columnSize == 1)
            {
                throw new Exception("It is not a two-dimensional array!");
            }
            int[,] array = new int[rowSize, columnSize];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("Array({0}, {1}): ", i, j);
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Entered matrix: ");
            PrintMatrix(array);
        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    void PrintMatrix(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}