namespace CSharpFundamentals.Lesson5;

public class Task12
{
    public void StringTests()
    {
        Console.Write("Enter string: ");
        string str = Console.ReadLine();

        Console.WriteLine("Entered string: " + str);

        Console.Write("Enter keyword: ");
        string keyword = Console.ReadLine();

        bool contains = Contains(str, keyword);
        Console.Write(contains);
    }

    bool Contains(string str, string keyword, bool isIgnoreCase = false)
    {
        if (String.IsNullOrEmpty(str))
        {
            throw new Exception("String is null or empty!");
        }

        if (String.IsNullOrEmpty(keyword))
        {
            throw new Exception("Searching keyword is null or empty!");
        }

        if (keyword.Length > str.Length)
        {
            throw new Exception("The length of he word cannot be greater than the length of the string!");
        }

        if (isIgnoreCase)
        {
            str = str.ToLower();
            keyword = str.ToLower();
        }

        for (int i = 0; i < str.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < keyword.Length; j++)
            {
                if (i + j < str.Length && str[i + j] == keyword[j])
                {
                    count++;
                }

                if (count < j + 1)
                {
                    break;
                }
            }

            if (count == keyword.Length)
            {
                return true;
            }
        }

        return false;
    }
}