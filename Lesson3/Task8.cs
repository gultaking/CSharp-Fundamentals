namespace CSharpFundamentals.Lesson3;

public class Task8
{
    public int DaysOfMonth(int month)
    {
        int dayCount = month;

        if (month < 1 || month > 12)
        {
            throw new Exception("Month cannot be less than 1 or more than 12!");
        }

        switch (dayCount)
        {
            case 1: return 31;
            case 2: return 28;
            case 3: return 31;
            case 4: return 30;
            case 5: return 31;
            case 6: return 30;
            case 7: return 31;
            case 8: return 30;
            case 9: return 31;
            case 10: return 31;
            case 11: return 30;
            case 12: return 31;
        }

        return dayCount;
    }

    public void DaysOfMonthTests()
    {
        try
        {
            Console.Write("Enter month number: ");
            int month = Convert.ToInt32(Console.ReadLine());

            int monthResult = DaysOfMonth(month);
            Console.WriteLine("There are {0} days in the {1}st month", monthResult, month);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}