namespace CSharpFundamentals.Lesson2;

class Task7
{
    public double ConvertMilesToKilometers(double miles)
    {
        if (miles <= 0)
        {
            throw new Exception("Miles cannot be zero or negative!");
        }

        return miles * 1.609344;
    }

    public double ConvertKilometersToMiles(double kilometers)
    {
        if (kilometers <= 0)
        {
            throw new Exception("Kilometers cannot be zero or negative!");
        }

        return kilometers * 0.62137;
    }

    public void MilesToKilometersTests()
    {
        try
        {
            Console.Write("Enter miles: ");
            double miles = Convert.ToDouble(Console.ReadLine());
            double kilometersResult = ConvertMilesToKilometers(miles);
            Console.WriteLine("Miles to kilometers converter: " + kilometersResult);

            Console.Write("Enter kilometers: ");
            double kilometers = Convert.ToDouble(Console.ReadLine());
            double milesResult = ConvertKilometersToMiles(kilometers);
            Console.WriteLine("Kilometers to miles converter: " + milesResult);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}