namespace CSharpFundamentals.Lesson4;

public class Task22
{
    public void FindEqualsTests()
    {
        try
        {
            Console.Write("Enter length the array's elements: ");
            int length = Convert.ToInt32(Console.ReadLine());

            if (length <= 0)
            {
                throw new Exception("The size of array elements cannot be zero or negative!");
            }

            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter array ({0}) ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter value: ");
            int value = Convert.ToInt32(Console.ReadLine());

            PrintAllEqualsElements(array, value);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    void PrintAllEqualsElements(int[] array, int value)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] + array[j] == value)
                {
                    Console.WriteLine("array({0}) + array({1}) = {2}", i, j, value);
                }
            }
        }
    }
}