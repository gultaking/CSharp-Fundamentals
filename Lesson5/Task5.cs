namespace CSharpFundamentals.Lesson5;

public class Task5
{
    public void StringTests()
    {
        Console.Write("Enter string: ");
        string str = Console.ReadLine();

        Console.Write("Entered string: ");
        Print(str);

        Console.WriteLine();

        int count = CountOfWordsString(str);
        Console.Write("Count of the words in string: " + count);
    }

    void Print(string str)
    {
        Console.Write(str);
    }

    int CountOfWordsString(string str)
    {
        int count = 1;

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