namespace CSharpFundamentals.Lesson4;

public class Task7
{
    public void CreateAscendingOrderArrayTests()
    {
        Console.Write("Enter length the first array elements: ");
        int arrayLength = Convert.ToInt32(Console.ReadLine());

        if (arrayLength <= 0)
        {
            throw new Exception("The size of array elements cannot be negative or zero!");
        }

        int[] array = new int[arrayLength];
        
        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("Insert the elements of the array {0}: ", i);
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Enter length the second array elements: ");
        int mergedArrayLength = Convert.ToInt32(Console.ReadLine());

        if (mergedArrayLength <= 0)
        {
            throw new Exception("The size of array elements cannot be negative or zero!");
        }
        
        int[] mergedArray = new int[mergedArrayLength];

        for (int i = 0; i < mergedArrayLength; i++)
        {
            Console.Write("Insert the elements of the array {0}: ", i);
            mergedArray[i] = Convert.ToInt32(Console.ReadLine());
        }

        int concatArrayLength = arrayLength + mergedArrayLength;
        int[] concatArray = new int[concatArrayLength];

        ConcatAndAscendingArray(array, mergedArray, concatArray);

    }

    public void ConcatAndAscendingArray(int[] array, int[] mergeArray, int[] concatArray)
    {
        concatArray = new int [array.Length + mergeArray.Length];

        int i, j;
        
        for ( i = 0; i < array.Length; i++)
        {
            concatArray[i] = array[i];
        }

        for ( j = 0; j < mergeArray.Length; j++)
        {
            concatArray[i] = mergeArray[j];
            i++;
        }

       
        CreateAscendingOrderArray(concatArray);
    }

    public void CreateAscendingOrderArray(int[] orderArray)
    {
        int temp;
        for (int i = 0; i < orderArray.Length; i++)
        {
            for (int j = 0; j < orderArray.Length-1; j++)
            {
                if (orderArray[j] > orderArray[j+1])
                {
                    temp = orderArray[j];
                    orderArray[j] = orderArray[j+1];
                    orderArray[j+1] = temp;
                }
            }
        }

        Console.Write("An array arranged in ascending order: ");
        for (int i = 0; i < orderArray.Length; i++)
        {
            if (i == orderArray.Length-1)
            {
                Console.Write(orderArray[i]);
            }
            else
            {
                Console.Write(orderArray[i] + ", ");
            }
        }
    }
}