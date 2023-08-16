namespace CSharpFundamentals.Lesson5;

public class Task4
{
    public void ReverseStringTests()
    {
        try
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();

            Console.Write("Entered string: " + str);

            Console.WriteLine();

            string reverseString = ReverseString(str);
            Console.Write("Reversed string: " + reverseString);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    string ReverseString(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            throw new Exception("String is null or empty!");
        }

        string reverseString = string.Empty;

        for (int i = str.Length - 1; i >= 0; i--)
        {
            reverseString += str[i];
        }

        return reverseString;
    }
}