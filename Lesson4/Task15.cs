namespace CSharpFundamentals.Lesson4;

public class Task15
{
    public void FindSecondMinimumTests()
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
            Console.Write("Insert the elements of the array  {0} : ", i);
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        Console.Write("Entered array: ");
        Print(array);
        
        Console.Write("\n2nd minimum element of the array: ");
        int secondMinimum = FindSecondMinimum(array);
        Console.Write(secondMinimum);
    }

    int FindSecondMinimum(int[] array)
    {
        int minimum = array[0];
        int secondMinimum = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minimum)
            {
                secondMinimum = minimum;
                minimum = array[i];
            }
            else if (array[i] < secondMinimum && array[i] > minimum)
            {
                secondMinimum = array[i];
            }
        }

        return secondMinimum;
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