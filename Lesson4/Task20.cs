namespace CSharpFundamentals.Lesson4;

public class Task20
{
    public void SumNegativeNumbersArrayTests()
    {
        try
        {
            Console.Write("Enter size of the arrayin: ");
            int length = Convert.ToInt32(Console.ReadLine());

            if (length <= 0)
            {
                throw new Exception("The length of the array cannot be zero or negative!");
            }

            int[] array = new int[length];

            Console.WriteLine("Enter array");
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter element({0}) ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Entered array: ");
            PrintArray(array);

            int result = SumNegativNumbersArray(array);
            Console.Write("\nSum minimum and second minimum negativ array: " + result);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    int SumNegativNumbersArray(int[] array)
    {
        int sum = 0;

        int min = array[0];
        
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }

        int secondMin = array[0];
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < secondMin && array[i] > min)
            {
                secondMin = array[i];
            }
        }

        if (min < 0 && secondMin < 0)
        {
            sum = min + secondMin;
        }

        return sum;
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