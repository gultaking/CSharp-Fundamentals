namespace CSharpFundamentals.Lesson3;

public class Task8
{
    public int GetDayCountOfMonth(int month)
    {
        int dayCount;

        switch (month)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                dayCount = 31;
                break;
            case 2:
                dayCount = 28;
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                dayCount = 30;
                break;
            default:
                throw new Exception("Month cannot be less than 1 or more than 12");
        }

        return dayCount;
    }

    public void GetDayCountOfMonthTests()
    {
        try
        {
            Console.Write("Enter month number: ");
            int month = Convert.ToInt32(Console.ReadLine());

            int monthResult = GetDayCountOfMonth(month);
            Console.WriteLine("There are {0} days in the {1}st month", monthResult, month);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}