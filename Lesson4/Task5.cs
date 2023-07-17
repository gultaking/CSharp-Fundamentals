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

        int result = FindDublicate(array, dublicateValue);
        Console.Write(result);
    }

    public int FindDublicate(int[] array, int dublicateValue)
    {
        int[] targetArray = new int[array.Length];

        int count = 1;
        
        for (int i = 0; i < array.Length; i++)
        {
            
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    count++;
                    targetArray[j] = 0;
                }
            }

            if (targetArray[i] != 0)
            {
                targetArray[i] = count;
            }
        }

        return count;
    }
}