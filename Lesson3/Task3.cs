namespace CSharpFundamentals.Lesson3;

public class Task3
{
    public void CalculatingLeapYear(int year)
    {
        if (year % 400 == 0) {
            Console.Write(year + " is a leap year.");
        } else if (year % 100 == 0) {
            Console.Write(year + " is not a leap year.");
        } else if (year % 4 == 0) {
            Console.Write(year + " is a leap year.");
        } else {
            Console.Write(year + " is not a leap year.");
        }
    }

    public void CalculatingLeapYearTests()
    {
        Console.Write("Enter year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        CalculatingLeapYear(year);
    }
}