namespace CSharpFundamentals.Lesson2;

public class Task3
{
    public void FindAverageGradeTest()
    {
        Console.Write("Enter the first score: ");
        double score1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the second score: ");
        double score2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the third score: ");
        double score3 = Convert.ToDouble(Console.ReadLine());
        double result = FindAverageGrade(score1, score2, score3);
        Console.Write("The average price is: " + result);
    }

    public double FindAverageGrade(double score1, double score2, double score3)
    {
        return (score1 + score2 + score3) / 3;
    }
}