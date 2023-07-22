namespace CSharpFundamentals.Lesson4;

public class Task14
{
    public void SecondLargestElementTests()
    {
        try
        {
            Console.Write("Enter the size of the array elements: ");
            int length = Convert.ToInt32(Console.ReadLine());

            if (length <= 0)
            {
                throw new Exception("The size of array elements cannot be negative or zero!");
            }

            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter array ({0}) ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Entered array: ");
            Print(array);

            Console.Write("\n2nd largest element of the array: ");
            int secondLarge = FindSecondLargestElement(array);

            Console.Write(secondLarge);
        }
        
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    int FindSecondLargestElement(int[] array)
    {
        int large = 0;
        int j = 0;
        
        for (int i = 0; i < array.Length; i++)
        {
            if (large < array[i])
            {
                large = array[i];
                j = i;
            }
        }

        int secondLarge = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i == j)
            {
                i++;
                j--;
            }
            else
            {
                if (secondLarge < array[i])
                {
                    secondLarge = array[i];
                }
            }
        }

        return secondLarge;
    }

    void Print(int[] array)
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