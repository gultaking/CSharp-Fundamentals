namespace CSharpFundamentals.Lesson4;

public class Task14
{
    public void FindSecondMaximumTest()
    {
        try
        {
            Console.Write("Enter the size of the array elements: ");
            int length = Convert.ToInt32(Console.ReadLine());

            if (length <= 0)
            {
                throw new Exception("The size of array elements cannot be negative or zero!");
            }

            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter array ({0}) ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Entered array: ");
            Print(array);

            Console.Write("\n2nd largest element of the array: ");
            int secondMaximum = FindSecondMaximum(array);

            Console.Write(secondMaximum);
        }
        
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    int FindSecondMaximum(int[] array)
    {
        int maximum = array[0];
        int secondMaximum = array[0];

        foreach (int item in array)
        {
            if (item > maximum)
            {
                secondMaximum = maximum;
                maximum = item;
            }
            
            else if (item > secondMaximum && item < maximum)
            {
                secondMaximum = item;
            }
        }

        return secondMaximum;
    }

    void Print(int[] array)
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