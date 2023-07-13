namespace CSharpFundamentals.Lesson4;

public class Task3
{
    public void SumAllArrayElements(double[] sumArrayElements)
    {
        double count = 0;
        for (int i = 0; i < sumArrayElements.Length; i++)
        {
            count += sumArrayElements[i];
        }

        Console.Write("\n Sum array elements: " + count);
    }

    public void SumAllArrayElemntsTests()
    {
        Console.Write("Enter size of the array elements: ");
        int arrayLength = Convert.ToInt32(Console.ReadLine());

        if (arrayLength <= 0)
        {
            throw new Exception("The size of array elements cannot be negative or zero!");
        }

        double[] sumArrayElements = new double[arrayLength];

        for (int i = 0; i < sumArrayElements.Length; i++)
        {
            Console.Write("Insert the elements of the array {0}: ", i);
            sumArrayElements[i] = Convert.ToDouble(Console.ReadLine());
        }

        SumAllArrayElements(sumArrayElements);
    }
}