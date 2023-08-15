namespace CSharpFundamentals.Lesson5;

public class Task6
{
    public void StringTests()
    {
        try
        {
            Console.Write("Enter string: ");
            string str1 = Console.ReadLine();

            Console.Write("Enter string: ");
            string str2 = Console.ReadLine();

            if (String.IsNullOrEmpty(str1) || String.IsNullOrEmpty(str2))
            {
                throw new Exception("String is null or empty!");
            }

            Print(str1, str2);

            Console.WriteLine();

            bool compare = ComparingStrings(str1, str2);
            Console.Write(compare ? "Strings are equal" : "Strings are not equal");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    void Print(string str1, string str2)
    {
        Console.Write("Entered string: ");
        Console.Write(str1);
        Console.WriteLine();
        Console.Write("Entered string: ");
        Console.Write(str2);
    }

    bool ComparingStrings(string str1, string str2)
    {
        if (str1 == str2)
        {
            return true;
        }

        return false;
    }
}