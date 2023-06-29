namespace CSharpFundamentals.Lesson3;

public class Task3
{
    bool IsLeapYear(int year)
    {
        if (year <= 0)
        {
            throw new Exception("Year cannot be zero or negative!");
        }

        if (year % 4 == 0)
        {
            return true;
        }

        return false;
    }

    public void CalculatingLeapYearTests()
    {
        try
        {
            Console.Write("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            
            bool isLeapYear = IsLeapYear(year);
            Console.WriteLine(isLeapYear ? "Leap year! " : "Not a leap year");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}