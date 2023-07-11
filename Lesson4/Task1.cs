namespace CSharpFundamentals.Lesson4;

public class Task1
{
    public void PrintArrayElementTests()
    {
        Console.Write("Enter the size of the arrays elements: ");
        int sizeOfElements = Convert.ToInt32(Console.ReadLine());

        int[] arrayElements = new int[sizeOfElements];

        int i;
        for (i = 0; i < arrayElements.Length; i++)
        {
            Console.Write("Insert the elements of the array {0}: ", i);
            arrayElements[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Elements of an array: ");
        for (i = 0; i < arrayElements.Length; i++)
        {
            Console.Write("\n " + arrayElements[i]);
        }
    }
}