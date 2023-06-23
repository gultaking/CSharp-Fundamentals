namespace CSharpFundamentals.Lesson2;

class Task8
{
    public double ConvertSecondsToMinutes(double secondsToMinutes)
    {
        return secondsToMinutes / 60;
    }

    public double ConvertSecondsToHours(double secondsToHours)
    {
        return secondsToHours / 3600;
    }
    
    public double ConvertMinutesToSeconds(double minutesToSecond)
    {
        return minutesToSecond * 60;
    }
    
    public double ConvertMinutesToHours(double minutesToHours)
    {
        return minutesToHours / 60;
    }

    public double ConvertHourseToSeconds(double hourseToSeconds)
    {
        return hourseToSeconds * 36000;
    }

    public double ConvertHourseToMinutes(double hourseToMinutes)
    {
        return hourseToMinutes * 60;
    }

    public void ExchangeSecondsTests()
    {
        Console.Write("Enter seconds: ");
        double secondsMinutes = Convert.ToDouble(Console.ReadLine());
        double secondsMinutesResult = ConvertSecondsToMinutes(secondsMinutes);
        Console.WriteLine(secondsMinutesResult);
        
        Console.Write("Enter seconds: ");
        double secondsHourse = Convert.ToDouble(Console.ReadLine());
        double secondsHoursResult = ConvertSecondsToHours(secondsHourse);
        Console.WriteLine(secondsHoursResult);

    }
}
