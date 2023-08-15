namespace CSharpFundamentals.Lesson5;

public class Task4
{
    public void ReverseStringTests()
    {
        Console.Write("Enter string: ");
        string str = Console.ReadLine();

        Console.Write("Entered string: ");
        Print(str);

        Console.WriteLine();
        
        string reversString = ReverseString(str);
        Console.Write("Rversed string: " + reversString);
    }

    void Print(string str)
    {
        Console.Write(str);
    }

    string ReverseString(string str)
    {
        string reverseString = string.Empty;

        for (int i = str.Length - 1; i >= 0; i--)
        {
            reverseString += str[i];
        }

        return reverseString;
    }
}