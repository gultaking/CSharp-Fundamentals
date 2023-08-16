namespace CSharpFundamentals.Lesson5;

public class Task5
{
    public void StringTests()
    {
        try
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();

            Console.Write("Entered string: " + str);

            Console.WriteLine();

            int count = CountOfWordsString(str);
            Console.Write("Count of the words in the string: " + count);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    int CountOfWordsString(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            throw new Exception("String is null or empty!");
        }

        int count = 1;

        str = str.Trim();

        for (int i = 0; i < str.Length - 1; i++)
        {
            if (str[i] == ' ' || str[i] == '\n' || str[i] == '\t')
            {
                count++;
            }
        }

        return count;
    }
}