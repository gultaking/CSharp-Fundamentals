namespace CSharpFundamentals.Lesson4;

public class Task13
{
    public void DeleteElementArrayTests()
    {
        try
        {
            Console.Write("Enter length of the array: ");
            int length = Convert.ToInt32(Console.ReadLine());

            if (length <= 0)
            {
                throw new Exception("The size of array elements cannot be negative or zero!");
            }

            int[] array = new int[length];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Array({0}): ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Entered array: ");
            PrintArray(array);

            Console.Write("\nEnter index: ");
            int index = Convert.ToInt32(Console.ReadLine());

            int[] targetArray = DeleteElement(array, index);

            PrintArray(targetArray);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    int[] DeleteElement(int[] array, int index)
    {
        if (index >= array.Length || index < 0)
        {
            throw new Exception("Index is invalid!");
        }

        int[] targetArray = new int[array.Length - 1];
        int j = 0;

        for (int i = 0; i < index; i++)
        {
            targetArray[j] = array[i];
            j++;
        }

        for (int i = index + 1; i < array.Length; i++)
        {
            targetArray[j] = array[i];
            j++;
        }

        return targetArray;
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