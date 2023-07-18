namespace CSharpFundamentals.Lesson4;

public class Task6
{
    public void FindUniqueElementTests()
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
            Console.Write("Insert the elements of the array {0}: ", i);
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        int[] result = GetUniqueElement(array);
        PrintUniqueElementArray(result);

    }

    public int[] GetUniqueElement(int[] array)
    {
        int[] targetArray = new int [array.Length];
        
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i+1; j < array.Length-1; j++)
            {
                if (array[i] == array[j])
                {
                     
                }
            }
        }

        return targetArray;
    }

    public void PrintUniqueElementArray(int[] targetArray)
    {
        for (int i = 0; i < targetArray.Length; i++)
        {
            Console.Write(targetArray[i]);
        }
    }
}