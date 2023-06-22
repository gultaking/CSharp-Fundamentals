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
            double milesResult = ConvertMilesToKilometers(miles);
            Console.WriteLine("Miles to kilometers converter: " + milesResult);

            Console.Write("Enter kilometers: ");
            double kilometers = Convert.ToDouble(Console.ReadLine());
            double kilometersResult = ConvertKilometersToMiles(kilometers);
            Console.WriteLine("Kilometers to miles converter: " + kilometersResult);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}