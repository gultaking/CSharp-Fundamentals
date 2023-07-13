namespace CSharpFundamentals.Lesson4;

public class Task2
{
    public void ReverseArrayElementsTests()
    {
        Console.Write("Enter the size of the arrays elements: ");
        int sizeOfElements = Convert.ToInt32(Console.ReadLine());

        if (sizeOfElements <= 0)
        {
            throw new Exception("The size of array elements cannot be negative or zero!");
        }
        int[] reverseArray = new int[sizeOfElements];

        for (int i = 0; i < reverseArray.Length; i++)
        {
            Console.Write("Insert the elements of the array {0}: ", i);
            reverseArray[i] = Convert.ToInt32(Console.ReadLine());
        }

        ReverseArray(reverseArray, 0, reverseArray.Length - 1);

        Console.WriteLine("Elements of the reverse array");
        for (int i = 0; i < reverseArray.Length; i++)
        {
            Console.WriteLine(reverseArray[i]);
        }
    }

    void ReverseArray(int[] arr, int startIndex, int endIndex)
    {
        while (startIndex < endIndex)
        {
            int temp = arr[startIndex];
            arr[startIndex] = arr[endIndex];
            arr[endIndex] = temp;
            startIndex++;
            endIndex--;
        }
    }
}