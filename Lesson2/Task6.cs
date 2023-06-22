namespace CSharpFundamentals.Lesson2;

class Task6
{
    public double CalculateBodyMassIndex(double kilograms, double heigth)
    {
        if (kilograms <= 0 || heigth <= 0)
        {
            throw new Exception("Kilograms and heigth cannot be zero or negative!");
        }

        return kilograms / Math.Pow(heigth, 2);
    }

    public void CalculateBodyMassIndexTests()
    {
        try
        {
            Console.Write("Enter kilograms: ");
            double kilograms = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter heigth: ");
            double heigth = Convert.ToDouble(Console.ReadLine());

            double indexResult = CalculateBodyMassIndex(kilograms, heigth);
            Console.WriteLine("Body Mass Index for kilograms and heigth: " + indexResult);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}