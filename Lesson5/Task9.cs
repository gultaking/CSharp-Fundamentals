using System.Runtime.Serialization.Formatters;

namespace CSharpFundamentals.Lesson5;

public class Task9
{
    public void StringTests()
    {
        Console.Write("Enter string: ");
        string str = Console.ReadLine();

        Console.Write("Entered string: " + str);

        Console.WriteLine();

        int count = FindMaxNumberCharacters(str);
        Console.Write("Max number of characters: " + count);
    }

    int FindMaxNumberCharacters(string str)
    {
        str = str.ToLower();
        if (String.IsNullOrEmpty(str))
        {
            throw new Exception("String is null!");
        }

        int max = 0;

        for (int i = 0; i < str.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < str.Length; j++)
            {
                if (str[i] == str[j])
                {
                    count++;
                }
            }

            if (count > max)
            {
                max = count;
            }
        }

        return max;
    }
}