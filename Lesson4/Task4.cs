using Microsoft.VisualBasic;

namespace CSharpFundamentals.Lesson4;

public class Task4
{
    public void CopyArrayElementsTests()
    {
        Console.Write("Enter the size of the array elements: ");
        int length = Convert.ToInt32(Console.ReadLine());

        if (length <= 0)
        {
            throw new Exception("The size of array elements cannot be negative or zero!");
        }

        char[] array = new char[length];

        //char[] targetArray = new char[length];

        for (int i = 0; i < length; i++)
        {
            Console.Write("Insert the elements of the array {0}: ", i);
            array[i] = Convert.ToChar(Console.ReadLine());
        }
        char[] targetArray = GetCopy(array);
        PrintArrayElements(array);
        PrintArrayElements(targetArray);
    }

    public char[] GetCopy(char[] array)
    {
        char[] targetArray = new char[array.Length];
        
        for (int i = 0; i < array.Length; i++)
        {
            targetArray[i] = array[i];
        }

        return targetArray;
    }

    public void PrintArrayElements(char[] array)
    {
        Console.Write("\nElements of an array: ");

        for (int i = 0; i < array.Length; i++)
        {
            if (i == array.Length-1)
            {
                Console.Write(array[i]);
            }
            else
            {
                Console.Write(array[i] + " , ");
            }
        }
    }
}