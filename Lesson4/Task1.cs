namespace CSharpFundamentals.Lesson4;

public class Task1
{
    public void PrintArrayElementsTests()
    {
        Console.Write("Enter the size of the arrays elements: ");
        int sizeOfElements = Convert.ToInt32(Console.ReadLine());

        if (sizeOfElements < 0)
        {
            throw new Exception("The size of array elements cannot be negative!");
        }

        double[] arrayElements = new double [sizeOfElements];

        int i;
        for (i = 0; i < arrayElements.Length; i++)
        {
            Console.Write("Insert the elements of the array {0}: ", i);
            arrayElements[i] = Convert.ToDouble(Console.ReadLine());
        }

        PrintArrayElements(arrayElements);
    }
    public void PrintArrayElements(double[] arrayElements)
    {
        Console.Write("Elements of an array: ");
        
        for (int i = 0; i < arrayElements.Length; i++)
        {
            Console.Write("\n " + arrayElements[i]);
        }
    }
}