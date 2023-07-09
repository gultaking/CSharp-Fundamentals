namespace CSharpFundamentals.Lesson3;

public class Task10
{
    public enum TriangleType
    {
        Equilateral,
        Isosceles,
        Scalene
    }

    public TriangleType GetTriangleType(double side1, double side2, double side3)
    {
        if (side1 <= 0 || side2 <= 0 || side3 <= 0)
        {
            throw new Exception("The sides of a triangle cannot be zero or negative!");
        }

        if ((side1 + side2 > side3 || side1 + side3 > side2 || side2 + side3 > side1 ||
             Math.Abs(side1 - side2) < side3 || Math.Abs(side1 - side3) < side2 ||
             Math.Abs(side2 - side3) < side1) && (side1 + side2 < side3 || side1 + side3 < side2 || side2 + side3 < 0 ||
                                                  Math.Abs(side1 - side2) > side3 || Math.Abs(side1 - side3) > side2 ||  Math.Abs(side2 - side3) > side1))
        {
            throw new Exception("This is not Triangle!");
        }

        if (side1 == side2 && side1 == side3 && side2 == side3)
        {
            return TriangleType.Equilateral;
        }

        if (side1 == side2 || side2 == side3 || side1 == side3)
        {
            return TriangleType.Isosceles;
        }

        return TriangleType.Scalene;
    }

    public void GetTriangleTypeTests()
    {
        try
        {
            Console.Write("Enter side a triangle: ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter side b triangle: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter side c triangle: ");
            double side3 = Convert.ToDouble(Console.ReadLine());

            object result = GetTriangleType(side1, side2, side3);
            Console.WriteLine("This triangle is an {0} triangle ", result);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}