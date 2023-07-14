namespace CSharpFundamentals.Lesson4;

public class Task3
{
    public void GetSumOfArray(double[] array)
    {
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        Console.Write("\n Sum array elements: " + sum);
    }

    public void GetSumOfArrayTests()
    {
        Console.Write("Enter size of the array elements: ");
        int length = Convert.ToInt32(Console.ReadLine());

        if (length <= 0)
        {
            throw new Exception("The size of array elements cannot be negative or zero!");
        }

        double[] array = new double[length];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Insert the elements of the array {0}: ", i);
            array[i] = Convert.ToDouble(Console.ReadLine());
        }

        GetSumOfArray(array);
    }
}