namespace CSharpFundamentals.Lesson4;

public class Task20
{
    public void SumOfMinimumsTests()
    {
        try
        {
            Console.Write("Enter size of the arrayin: ");
            int length = Convert.ToInt32(Console.ReadLine());

            if (length <= 0)
            {
                throw new Exception("The length of the array cannot be zero or negative!");
            }

            int[] array = new int[length];

            Console.WriteLine("Enter array");
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter element({0}) ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Entered array: ");
            PrintArray(array);

            int result = GetSumOfMinimums(array);
            Console.Write("\nSum minimum and second minimum negativ array: " + result);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    int GetSumOfMinimums(int[] array)
    {
        int sumNegativ = 0;

        int minNegativ = array[0];
        
        int secondMinNegative = array[0];
        
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < minNegativ)
            {
                secondMinNegative = minNegativ;
                minNegativ = array[i];
            }
            
            if (array[i] < secondMinNegative && array[i] > minNegativ)
            {
                secondMinNegative = array[i];
            }
        }

        if (minNegativ < 0 && secondMinNegative < 0)
        {
            sumNegativ = minNegativ + secondMinNegative;
        }

        return sumNegativ;
    }

    void PrintArray(int[] array)
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