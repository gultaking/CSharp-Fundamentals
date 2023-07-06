namespace CSharpFundamentals.Lesson3;

public class Task10
{
    public enum TriangleType
    {
        Equilateral,
        Isosceles,
        Scalene
    }

    public TriangleType GetTriangleType(int side1, int side2, int side3)
    {
        if (side1 <= 0 || side2 <= 0 || side3 <= 0)
        {
            throw new Exception("The sides of a triangle cannot be negative!");
        }

        if (side1 == side2 && side1 == side3 && side2 == side3)
        {
            return TriangleType.Equilateral;
        }
        else if (side1 == side2 || side2 == side3 || side1 == side3)
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
            int side1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter side b triangle: ");
            int side2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter side c triangle: ");
            int side3 = Convert.ToInt32(Console.ReadLine());

            object result = GetTriangleType(side1, side2, side3);

            Console.WriteLine("This triangle is an {0} triangle ", result);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}