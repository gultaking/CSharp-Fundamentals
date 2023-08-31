using System.Text;

namespace CSharpFundamentals.Lesson5;

public class Task10
{
    public void StringTests()
    {
        Console.Write("Enter string: ");
        string str = Console.ReadLine();
        
        Console.WriteLine("Entered string: " + str);
        string sortedStr = SortAscending(str);
        Console.WriteLine("Sorted string: " + sortedStr);
    }

    string SortAscending(string str)
    {
        if (String.IsNullOrEmpty(str))
        {
            throw new Exception("String is null or empty!");
        }
        
        StringBuilder text = new StringBuilder(str);
        for (int i = 0; i < text.Length; i++)
        {
            for (int j = 0; j < text.Length - 1; j++)
            {
                if (text[j] > text[j + 1])
                {
                    char temp = text[j];
                    text[j] = text[j + 1];
                    text[j + 1] = temp;
                }
            }
        }

        return text.ToString();
    }
}