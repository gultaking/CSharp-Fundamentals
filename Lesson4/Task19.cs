namespace CSharpFundamentals.Lesson4;

public class Task19
{
    public void SumRowsAndColumnsArrayTests()
    {
        try
        {
            Console.Write("Enter rows size: ");
            int rowSize = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter columns size: ");
            int columnSize = Convert.ToInt32(Console.ReadLine());

            if (rowSize <= 0 || columnSize <= 0)
            {
                throw new Exception("The row and column size of an array cannot be zero or negative!");
            }

            if (rowSize == 1 && columnSize == 1)
            {
                throw new Exception("It is not a two-dimensional array!");
            }

            Console.WriteLine("Enter the first array: ");
            int[,] array = InputArray(rowSize, columnSize);

            Console.WriteLine("Entered array: ");
            Print(array);

            PrintSumOfRows(array);
            PrintSumOfColumns(array);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        
    }

    int[,] InputArray(int rowSize, int columnSize)
    {
        int[,] array = new int[rowSize, columnSize];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write("Array({0}, {1}): ", i, j);
                array[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        return array;
    }

    void Print(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array.GetLength(1) - 1 == j)
                {
                    Console.Write(array[i, j]);
                }
                else
                {
                    Console.Write(array[i, j] + ", ");
                }
            }

            Console.WriteLine();
        }
    }

    void PrintSumOfRows(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
            }

            Console.WriteLine("Sum of {0} row: {1}", i, sum);
        }
    }

    void PrintSumOfColumns(int[,] array)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(0); j++)
            {
                sum += array[j, i];
            }

            Console.WriteLine("Sum of {0} column: {1}", i, sum);
        }
    }
}