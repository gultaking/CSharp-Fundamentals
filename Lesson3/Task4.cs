using System.Reflection.Metadata.Ecma335;

namespace CSharpFundamentals.Lesson3;

public class Task4
{
    public void WeekDays(int weekDay)
    {
        if (weekDay <= 0)
        {
            throw new Exception("The day of the week cannot be zero or negative!");
        }

        switch (weekDay)
        {
            case 1:
                Console.WriteLine("It is Monday");
                break;
            case 2:
                Console.WriteLine("It is Tuesday");
                break;
            case 3:
                Console.WriteLine("It is Wednesday");
                break;
            case 4:
                Console.WriteLine("It is Thursday");
                break;
            case 5:
                Console.WriteLine("It is Friday");
                break;
            case 6:
                Console.WriteLine("It is Saturday");
                break;
            case 7:
                Console.WriteLine("It is Sunday");
                break;

            default:
                Console.WriteLine("It is wrong input!");
                break;
        }
    }

    public void WeekDaysTests()
    {
        try
        {
            Console.Write("Enter the day of the week: ");
            int weekDay = Convert.ToInt32(Console.ReadLine());

            WeekDays(weekDay);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}