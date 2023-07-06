namespace CSharpFundamentals.Lesson3;

public class Task10
{
    public enum TypeTriangle
    {
        Equilateral,
        Isosceles,
        Scalene
    }

    public string GetTypeTriangle(int side1, int side2, int side3)
    {
        string typeTriangleA = TypeTriangle.Equilateral.ToString();
        string typeTriangleB = TypeTriangle.Isosceles.ToString();
        string typeTriangleC = TypeTriangle.Scalene.ToString();

        if (side1 <= 0 || side2 <= 0 || side3 <= 0)
        {
            throw new Exception("The sides of a triangle cannot be negative!");
        }

        if (side1 == side2 && side1 == side3 && side2 == side3)
        {
            return typeTriangleA;
        }
        else if (side1 == side2 || side2 == side3 || side1 == side3)
        {
            return typeTriangleB;
        }

        return typeTriangleC;
    }

    public void GetTypeTriangleTests()
    {
        try
        {
            Console.Write("Enter side a triangle: ");
            int sideA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter side b triangle: ");
            int sideB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter side c triangle: ");
            int sideC = Convert.ToInt32(Console.ReadLine());

            object result = GetTypeTriangle(sideA, sideB, sideC);

            Console.WriteLine("This triangle is an {0} triangle ",  result);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}