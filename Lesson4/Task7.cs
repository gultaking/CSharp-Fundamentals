namespace CSharpFundamentals.Lesson4;

public class Task7
{
    public void AscendingOrderArrayTests()
    {
        Console.Write("Enter length the first array elements: ");
        int length = Convert.ToInt32(Console.ReadLine());

        if (length <= 0)
        {
            throw new Exception("The size of array elements cannot be negative or zero!");
        }

        Console.WriteLine("\nInsert the elements of the first array");
        int[] array1 = new int[length];

        for (int i = 0; i < length; i++)
        {
            Console.Write("Insert the element of the array {0}: ", i);
            array1[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nInsert the elements of the second array");

        int[] array2 = new int[length];

        for (int i = 0; i < length; i++)
        {
            Console.Write("Insert the element of the array {0}: ", i);
            array2[i] = Convert.ToInt32(Console.ReadLine());
        }


        int[] concatArray = ConcatArray(array1, array2);
        SortArrayAscending(concatArray);
        PrintSortingArray(concatArray);
    }

    public int[] ConcatArray(int[] array1, int[] array2)
    {
        int[] array3 = new int [array1.Length + array2.Length];

        int i, j;

        for (i = 0; i < array1.Length; i++)
        {
            array3[i] = array1[i];
        }

        for (j = 0; j < array2.Length; j++)
        {
            array3[i] = array2[j];
            i++;
        }

        return array3;
    }

    public void SortArrayAscending(int[] array)
    {
        int temp;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    public void PrintSortingArray(int[] array)
    {
        Console.Write("\nAn array arranged in ascending order: ");
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