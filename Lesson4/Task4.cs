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

        char[] targetArray = new char[length];

        for (int i = 0; i < length; i++)
        {
            Console.Write("Insert the elements of the array {0}: " , i);
            array[i] = Convert.ToChar(Console.ReadLine());
        }

        CopyArrayElements(array, targetArray);
        PrintArrayElements(array, targetArray);
    }

    public void CopyArrayElements(char[] array, char[] targetArray)
    {
        for (int i = 0; i < array.Length; i++)
        {
            targetArray[i] = array[i];
        }
    }

    public void PrintArrayElements(char[] array, char[] targetArray)
    {
        Console.Write("Elements of an array: ");
        Console.Write(String.Join(",", array));
        Console.Write("\nElements of the copied array: ");
        Console.Write(String.Join(",", targetArray));
    }
}