using System.Text;

namespace CSharpFundamentals.Lesson5;

public class Task11
{
    public void StringTests()
    {
        Console.Write("Enter string: ");
        string str = Console.ReadLine();
        
        Console.WriteLine("Entered string: " + str);

        Console.Write("Enter from index: ");
        int fromIndex = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter to index: ");
        int toIndex = Convert.ToInt32(Console.ReadLine());

        string substring1 = Substring(str, fromIndex, toIndex);
        Console.WriteLine(substring1);
        
        string substring2 = Substring(str, fromIndex);
        Console.WriteLine(substring2);
    }

    string Substring(string str, int fromIndex)
    {
        if (String.IsNullOrEmpty(str))
        {
            throw new Exception("String is null or empty!");
        }

        if (fromIndex > str.Length)
        {
            throw new Exception("Index is wrong!");
        }
        
        StringBuilder targetString = new StringBuilder();

        for (int i = fromIndex; i < str.Length; i++)
        {
            targetString.Append(str[i]);
        }

        return targetString.ToString();
    }

    string Substring(string str, int fromIndex, int toIndex)
    {
        if (fromIndex > str.Length || toIndex > str.Length)
        {
            throw new Exception("Index is wrong!");
        }

        StringBuilder targetString = new StringBuilder();

        for (int i = fromIndex; i <= toIndex; i++)
        {
            targetString.Append(str[i]);
        }

        return targetString.ToString();
    }
}