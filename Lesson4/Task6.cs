namespace CSharpFundamentals.Lesson4;

public class Task6
{
    public void FindUniqueElementTests()
    {
        Console.Write("Enter length of the array: ");
        int length = Convert.ToInt32(Console.ReadLine());

        if (length <= 0)
        {
            throw new Exception("The size of array elements cannot be zero or negative!");
        }

        int[] array = new int[length];

        for (int i = 0; i < length; i++)
        {
            Console.Write("Array({0}): ", i);
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        Console.Write("Entered array: ");
        PrintArray(array);
        
        Console.WriteLine();

        int[] uniqueArray = GetUniqueArray(array);
        Console.Write("Unique array: ");
        PrintArray(uniqueArray);
    }

    private int[] GetUniqueArray(int[] array)
    {
        int[] targetArray = Array.Empty<int>();

        for (int i = 0; i < array.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < array.Length - 1; j++)
            {
                if (array[i] == array[j] && i != j)
                {
                    count++;
                }
            }

            if (count == 0)
            {
                int[] tempArr = new int[targetArray.Length + 1];
                for (int k = 0; k < targetArray.Length; k++)
                {
                    tempArr[k] = targetArray[k];
                }

                tempArr[targetArray.Length] = array[i];
                targetArray = tempArr;
            }
        }

        return targetArray;
    }

    private void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (i == array.Length - 1)
            {
                Console.Write(array[i]);
            }
            else
            {
                Console.Write("{0}, ", array[i]);
            }
        }
    }
}