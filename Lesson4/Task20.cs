namespace CSharpFundamentals.Lesson4;

public class Task20
{
    public void SumOfMinimumsTests()
    {
        try
        {
            Console.Write("Enter size of the array: ");
            int length = Convert.ToInt32(Console.ReadLine());

            if (length <= 0)
            {
                throw new Exception("The length of the array cannot be zero or negative!");
            }

            int[] array = new int[length];

            Console.WriteLine("Enter array");
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter element({0}): ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Entered array: ");
            PrintArray(array);

            int result = GetSumOfMinimums(array);
            Console.Write("\nSum of the first and second negative minimums: " + result);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    int GetSumOfMinimums(int[] array)
    {
        int firstNegativeMinimum = array[0];
        int secondNegativeMinimum = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                if (array[i] < firstNegativeMinimum)
                {
                    secondNegativeMinimum = firstNegativeMinimum;
                    firstNegativeMinimum = array[i];
                }
                else if (array[i] < secondNegativeMinimum)
                {
                    secondNegativeMinimum = array[i];
                }
            }
        }

        if (firstNegativeMinimum < 0 && secondNegativeMinimum < 0)
        {
            return firstNegativeMinimum + secondNegativeMinimum;
        }

        if (firstNegativeMinimum < 0 && secondNegativeMinimum > 0)
        {
            return firstNegativeMinimum;
        }

        return 0;
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