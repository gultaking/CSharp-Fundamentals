namespace CSharpFundamentals.Lesson5;

public class Task2
{
    public void FindStringLengthTests()
    {
        Console.Write("Input string: ");
        string str = Console.ReadLine();

        Console.Write("Printed string: ");
        PrintString(str);

        Console.Write("\nThe length of string: ");
        int lengthString = FindLength(str);
        Console.Write(lengthString);
    }

    void PrintString(string str)
    {
        Console.Write(str);
    }

    int FindLength(string str)
    {
        int length = 0;
        foreach (char item in str)
        {
            length += 1;
        }

        return length;
    }
}