namespace CSharpFundamentals.Lesson4;

public class Task5
{
    public void FindElementsIsRepeatedTests()
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

        Console.Write("Enter elemetn: ");
        int dublicatedValue = Convert.ToInt32(Console.ReadLine());


        int repeatedResult = FindElementIsRepeated(array, dublicatedValue);
        Console.Write("{0} is repeated {1} times", dublicatedValue, repeatedResult);
    }

    public int FindElementIsRepeated(int[] array, int dublicatedValue)

    {
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (dublicatedValue == array[i])
            {
                count++;
            }
        }

        return count;
    }
}