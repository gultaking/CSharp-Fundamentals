namespace CSharpFundamentals.Lesson5;

public class Task2
{
    public void FindLengthTests()
    {
        try
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();

            if (string.IsNullOrEmpty(str))
            {
                throw new Exception("String is null!");
            }
        
            Console.Write("Print string: ");
            PrintString(str);

            int length = FindLength(str);
            Console.Write("\nLength of the string: " +  length);
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
        int length = str.Length;
        return length;
    }
}