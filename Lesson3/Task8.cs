namespace CSharpFundamentals.Lesson3;

public class Task8
{
    public int FindMonthDate(int month)
    {
        if (month < 1 || month > 12)
        {
            throw new Exception("Month cannot be less than 1 or more than 12!");
        }

        switch (month)
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

        return month;
    }

    public void FindMonthDateTests()
    {
        try
        {
            Console.Write("Enter month number: ");
            int date = Convert.ToInt32(Console.ReadLine());

            int result = FindMonthDate(date);
            Console.WriteLine(result + " day in month {0}", date);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}