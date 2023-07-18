namespace CSharpFundamentals.Lesson4;

public class Task5
{
    public void FindDublicateElementsTests()
    {
        Console.Write("Enter length the array elements: ");
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

        Console.Write("Enter elements: ");
        int dublicateValue = Convert.ToInt32(Console.ReadLine());

        int result = FindDublicate(array);
        Console.Write("{0} is repeated {1}", dublicateValue, result);
    }

    public int FindDublicate(int[] array)
    {
        int count = 1;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length - 1; j++)
            {
                if (array[i] == array[j])
                {
                    count++;
                }
            }
        }

        return count;
    }
}