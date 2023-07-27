namespace CSharpFundamentals.Lesson4;

public class Task7
{
    public void AscendingOrderArrayTests()
    {
        Console.Write("Enter length: ");
        int length = Convert.ToInt32(Console.ReadLine());

        if (length <= 0)
        {
            throw new Exception("The size of array elements cannot be negative or zero!");
        }

        Console.WriteLine("\nInsert the elements of the first array");
        int[] array1 = new int[length];

        for (int i = 0; i < length; i++)
        {
            Console.Write("Array1({0}): ", i);
            array1[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nInsert the elements of the second array");

        int[] array2 = new int[length];

        for (int i = 0; i < length; i++)
        {
            Console.Write("Array2({0}): ", i);
            array2[i] = Convert.ToInt32(Console.ReadLine());
        }


        int[] concatArray = ConcatArray(array1, array2);

        Console.Write("Concat array: ");
        PrintArray(concatArray);

        SortArrayAscending(concatArray);

        Console.Write("\nSorted array: ");
        PrintArray(concatArray);
    }

    int[] ConcatArray(int[] array1, int[] array2)
    {
        int[] concatArray = new int [array1.Length + array2.Length];

        // int i, j;
        //
        // for (i = 0; i < array1.Length; i++)
        // {
        //     array3[i] = array1[i];
        // }
        //
        // for (j = 0; j < array2.Length; j++)
        // {
        //     array3[i] = array2[j];
        //     i++;
        // }

        for (int i = 0; i < array1.Length; i++)
        {
            concatArray[i] = array1[i];
            concatArray[concatArray.Length - 1 - i] = array2[array2.Length - 1 - i];
        }

        return concatArray;
    }

    void SortArrayAscending(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                }
            }
        }
    }

    void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (i == array.Length - 1)
            {
                Console.Write(array[i]);
            }
            else
            {
                Console.Write(array[i] + ", ");
            }
        }
    }
}