namespace CSharpFundamentals.Lesson2;
using System;
class Task8
{
    public double ConvertSecondsToMinutes(double secondsToMinutes)
    {
        if (secondsToMinutes < 0)
        {
            throw new Exception("Seconds cannot be negative!");
        }

        return secondsToMinutes / 60;
    }

    public double ConvertSecondsToHours(double secondsToHours)
    {
        if (secondsToHours < 0)
        {
            throw new Exception("Seconds cannot be negative!");
        }

        return secondsToHours / 3600;
    }

    public double ConvertMinutesToSeconds(double minutesToSecond)
    {
        if (minutesToSecond < 0)
        {
            throw new Exception("Minutes cannot be negative!");
        }

        return minutesToSecond * 60;
    }

    public double ConvertMinutesToHours(double minutesToHours)
    {
        if (minutesToHours < 0)
        {
            throw new Exception("Minutes cannot be negative!");
        }

        return minutesToHours / 60;
    }

    public double ConvertHourseToSeconds(double hourseToSeconds)
    {
        if (hourseToSeconds < 0)
        {
            throw new Exception("Hourse cannot be negative!");
        }

        return hourseToSeconds * 36000;
    }

    public double ConvertHourseToMinutes(double hourseToMinutes)
    {
        if (hourseToMinutes < 0)
        {
            throw new Exception("Hourse cannot be negative");
        }

        return hourseToMinutes * 60;
    }

    public void ExchangeSecondsTests()
    {
        try
        {
            Console.Write("Enter the time in seconds below to get the value converted to minutes: ");
            double secondsToMinutes = Convert.ToDouble(Console.ReadLine());
            double minutesResult = ConvertSecondsToMinutes(secondsToMinutes);
            Console.WriteLine("Results in Minutes: " + minutesResult);

            Console.Write("Enter the time in seconds below to get the value converted to hourse: ");
            double secondsToHourse = Convert.ToDouble(Console.ReadLine());
            double secondsHoursResult = ConvertSecondsToHours(secondsToHourse);
            Console.WriteLine("Results in Hourse: " + secondsHoursResult);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    public void ExchangeMinutesTests()
    {
        try
        {
            Console.Write("Enter the time in minutes below to get the value converted to seconds: ");
            double minutesToSeconds = Convert.ToDouble(Console.ReadLine());
            double secondsResult = ConvertMinutesToSeconds(minutesToSeconds);
            Console.WriteLine("Results in Seconds: " + secondsResult);

            Console.Write("Enter the time in hourse below to get the value converted to minutes: ");
            double minutesToHourse = Convert.ToDouble(Console.ReadLine());
            double hourseResult = ConvertMinutesToHours(minutesToHourse);
            Console.WriteLine("Results in Hourse: " + hourseResult);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    public void ExchangeHourseTests()
    {
        try
        {
            Console.Write("Enter the time in hourse below to get the value converted to seconds: ");
            double hourseToSeconds = Convert.ToDouble(Console.ReadLine());
            double secondsResult = ConvertHourseToSeconds(hourseToSeconds);
            Console.WriteLine("Results in Seconds: " + secondsResult);

            Console.Write("Enter the time in hourse below to get the value converted to minutes: ");
            double hourseToMinutes = Convert.ToDouble(Console.ReadLine());
            double minutesResults = ConvertHourseToMinutes(hourseToMinutes);
            Console.WriteLine("Results in Minutes: " + minutesResults);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}