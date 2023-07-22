namespace CSharpFundamentals.Lesson4;

public class Task11
{
    public void SortArrayElementsTests()
    {
        try
        {
            Console.Write("Enter the size of the arrays elements: ");
            int length = Convert.ToInt32(Console.ReadLine());

            if (length <= 0)
            {
                throw new Exception("The size of array elements cannot be negative!");
            }

            double[] array = new double[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter array ({0})", i);
                array[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Print array: ");
            PrintArray(array);

            SortArrayElements(array);

            Console.Write("\nPrint sort array: ");
            PrintArray(array);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        
    }

    void SortArrayElements(double[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[i])
                {
                    double temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
    }

    void PrintArray(double[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array.Length - 1 == i)
            {
                Console.Write(array[i]);
            }
            else
            {
                Console.Write(array[i] + ", ");
            }
        }
    }
}