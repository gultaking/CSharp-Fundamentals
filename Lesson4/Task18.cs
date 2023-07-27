namespace CSharpFundamentals.Lesson4;

public class Task18
{
    public void SubtractionOfArrayTests()
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
            int[,] array1 = InputArray(rowSize, columnSize);

            Console.WriteLine("Enter the second array: ");
            int[,] array2 = InputArray(rowSize, columnSize);

            Console.WriteLine("Entered first array: ");
            Print(array1);

            Console.WriteLine("Entered second array: ");
            Print(array2);

            Console.WriteLine("The subtraction of the two arrays: ");
            int[,] subtractionArray = SubtractionOfArrays(array1, array2);
            Print(subtractionArray);
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

    int[,] SubtractionOfArrays(int[,] array1, int[,] array2)
    {
        if (array1.GetLength(0) != array2.GetLength(0))
        {
            throw new Exception("The row sizes of the arrays are not same!");
        }

        if (array1.GetLength(1) != array2.GetLength(1))
        {
            throw new Exception("The column sizes of the arrays are not same!");
        }

        int[,] subtractionArray = new int[array1.GetLength(0), array1.GetLength(1)];

        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                subtractionArray[i, j] = array1[i, j] - array2[i, j];
            }
        }

        return subtractionArray;
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
}