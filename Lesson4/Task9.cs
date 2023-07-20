namespace CSharpFundamentals.Lesson4;

public class Task9
{
    public void FindMinMaxElementTests()
    {
        Console.Write("Enter length the array: ");
        int length = Convert.ToInt32(Console.ReadLine());

        if (length <= 0)
        {
            throw new Exception("The size of array elements cannot be negative or zero!");
        }
        
        double[] array = new double[length];

        for (int i = 0; i < length; i++)
        {
            Console.Write("Enter array ({0}): ", i);
            array[i] = Convert.ToDouble(Console.ReadLine());
        }

        double printMin = FindMinElement(array);
        Console.Write("The minimum element of the array: " + printMin);

        double printMax = FindMaxElement(array);
        Console.Write("\nThe maximum element of the array: " + printMax);
    }

    double FindMinElement(double[] array)
    {
        double minimum = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < minimum)
            {
                minimum = array[i];
            }
        }

        return minimum;
    }

    double FindMaxElement(double[] array)
    {
        double maximum = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maximum)
            {
                maximum = array[i];
            }
        }

        return maximum;
    }
}