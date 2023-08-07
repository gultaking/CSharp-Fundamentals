namespace CSharpFundamentals.Lesson5;

public class Task3
{
    public void FindStringLengthTests()
    {
        try
        {
            Console.Write("Input string: ");
            string str = Console.ReadLine();

            if (string.IsNullOrEmpty(str))
            {
                throw new Exception("String is null!");
            }

            Console.Write("Printed string: ");
            PrintString(str);

            Console.Write("\nThe length of string: ");
            int lengthString = FindLength(str);
            Console.Write(lengthString);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
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