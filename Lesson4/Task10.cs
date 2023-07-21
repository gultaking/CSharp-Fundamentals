namespace CSharpFundamentals.Lesson4;

public class Task10
{
    public void FindOddAndEvenElementsTests()
    {
        try
        {
            Console.Write("Enter length the array: ");
            int length = Convert.ToInt32(Console.ReadLine());

            if (length <= 0)
            {
                throw new Exception("The size of array elements cannot be negative or zero!");
            }

            int[] array = new int[length];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter Array ({0}) ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Entered array: ");
            PrintArray(array);

            Console.Write("\nEven indexed array: ");
            int[] evenArray = FindEvenIndexedElements(array);
            PrintArray(evenArray);

            Console.Write("\nOdd indexed array: ");
            int[] oddArray = FindOddIndexedElements(array);
            PrintArray(oddArray);
        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    int[] FindOddIndexedElements(int[] array)
    {
        if (array.Length == 0)
        {
            return Array.Empty<int>();
        }

        int[] oddArray = new int[array.Length / 2];

        int j = 0;

        for (int i = 1; i < array.Length; i += 2)
        {
            oddArray[j] = array[i];
            j++;
        }

        return oddArray;
    }

    int[] FindEvenIndexedElements(int[] array)
    {
        if (array.Length == 0)
        {
            return Array.Empty<int>();
        }

        int length = array.Length % 2 == 0
            ? array.Length / 2
            : (array.Length / 2) + 1;

        int[] evenArray = new int[length];

        int j = 0;

        for (int i = 0; i < array.Length; i += 2)
        {
            evenArray[j] = array[i];
            j++;
        }

        return evenArray;
    }

    void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array.Length - 1 == i)
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