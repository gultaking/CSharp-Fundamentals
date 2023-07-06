namespace CSharpFundamentals.Lesson3;

public class Task10
{
    public enum TypeTriangle
    {
        Equilateral,
        Isosceles,
        Scalene
    }

    public object GetTypeTriangle(int sideA, int sideB, int sideC)
    {
        TypeTriangle typeTriangleA = TypeTriangle.Equilateral;
        TypeTriangle typeTriangleB = TypeTriangle.Isosceles;
        TypeTriangle typeTriangleC = TypeTriangle.Scalene;

        if (sideA == sideB && sideA == sideC && sideB == sideC)
        {
            return typeTriangleA;
        }
        else if (sideA == sideB || sideB == sideC)
        {
            return typeTriangleB;
        }

        return typeTriangleC;
    }

    public void GetTypeTriangleTests()
    {
        Console.Write("Enter side a triangle: ");
        int sideA = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter side b triangle: ");
        int sideB = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter side c triangle: ");
        int sideC = Convert.ToInt32(Console.ReadLine());

        object result = GetTypeTriangle(sideA, sideB, sideC);

        Console.WriteLine(result);
    }
}