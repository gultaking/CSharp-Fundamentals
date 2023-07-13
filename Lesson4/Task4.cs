namespace CSharpFundamentals.Lesson4;

public class Task4
{
    public void CopyArrayElementsTests()
    {
        Console.Write("Enter the size of the array elements: ");
        int arrayLength = Convert.ToInt32(Console.ReadLine());

        if (arrayLength <= 0)
        {
            throw new Exception("The size of array elements cannot be negative or zero!");
        }

        char[] deafaultArray = new char[arrayLength];

        char[] copyArray = new char[arrayLength];

        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("Insert the elements of the array {0}:", i);
            deafaultArray[i] = Convert.ToChar(Console.ReadLine());
        }

        CopyArrayElements(deafaultArray, copyArray);

        Console.WriteLine("The elements copied into the second array are");
        for (int i = 0; i < arrayLength; i++)
        {
            Console.WriteLine(copyArray[i]);
        }
    }

    public void CopyArrayElements(char[] deafaultArray, char[] copyArray)
    {
        for (int i = 0; i < deafaultArray.Length; i++)
        {
            copyArray[i] = deafaultArray[i];
        }
    }
}