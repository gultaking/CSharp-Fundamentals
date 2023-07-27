namespace CSharpFundamentals.Lesson4;

public class Task21
{
    public void FindEnteredValueTests()
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

        int minPosElement = FindMinPositiveNotPresentElement(array);
        Console.WriteLine(minPosElement);
    }

    bool CheckExist(int[] array, int value)
    {
        foreach (int item in array)
        {
            if (item == value)
            {
                return true;
            }
        }

        return false;
    }

    int FindMaxElement(int[] array)
    {
        int max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        return max;
    }

    int FindMinPositiveNotPresentElement(int[] array)
    {
        int max = FindMaxElement(array);

        for (int i = 1; i <= max; i++)
        {
            bool isExists = CheckExist(array, i);
            if (!isExists)
            {
                return i;
            }
        }

        return max < 0 ? 1 : max + 1;
    }
}