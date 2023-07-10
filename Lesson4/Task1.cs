namespace CSharpFundamentals.Lesson4;

public class Task1
{
    public void PrintArrayElementTests()
    {
        int[] arrayElements = new int[10];

        int i;
        for (i = 1; i <= arrayElements.Length; i++)
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