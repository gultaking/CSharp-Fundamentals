namespace CSharpFundamentals.Lesson4;

public class Task9
{
    public void FindMinMaxArrayTests()
    {
        Console.Write("Enter length array: ");
        int length = Convert.ToInt32(Console.ReadLine());

        double[] array = new double[length];

        for (int i = 0; i < length; i++)
        {
            Console.Write("Enter array {0}: ", i);
            array[i] = Convert.ToDouble(Console.ReadLine());
        }

        PrintMaxAndMinArray(array);
    }

    double FindMinArray(double[] array)
    {
        double minimum = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minimum)
            {
                minimum = array[i];
            }
        }

        return minimum;
    }

    double FindMaxArray(double[] array)
    {
        double maximum = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maximum)
            {
                maximum = array[i];
            }
        }

        return maximum;
    }

    void PrintMaxAndMinArray(double[] array)
    {
        double printMin = FindMinArray(array);
        Console.Write("The minimum element of the array: " + printMin);

        double printMax = FindMaxArray(array);
        Console.Write("\nThe maximum element of the array: " + printMax);
    }
}