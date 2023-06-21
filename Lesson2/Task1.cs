namespace CSharpFundamentals.Lesson2;

public class Task1
{
    public double GetRectangleArea(double length, double width)
    {
        if (length <= 0)
        {
            throw new Exception("Length must be greater than zero!");
        }

        if (width <= 0)
        {
            throw new Exception("Width must be greater than zero!");
        }

        return length * width;
    }
    public void GetRectangleAreaTest()
    {
        try
        {
            Console.WriteLine("Test started!");

            Console.Write("Enter length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = GetRectangleArea(length, width);

            Console.WriteLine("Area: " + area);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}