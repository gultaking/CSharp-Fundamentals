namespace CSharpFundamentals.Lesson3;

public class Task5
{
    public void Grade(char grade)
    {
        switch (grade)
        {
            case 'A':
                Console.WriteLine("Excellent!");
                break;
            case 'B':
                Console.WriteLine("Good job!");
                break;
            case 'C':
                Console.WriteLine("Average!");
                break;
            case 'D':
                Console.WriteLine("Needs improvement!");
                break;
            case 'F':
                Console.WriteLine("Fail!");
                break;
            default:
                Console.WriteLine("It is wrong input!");
                break;
        }
    }

    public void GradeTests()
    {
        Console.Write("Enter grade: ");
        char grade = Convert.ToChar(Console.ReadLine());
        
        Grade(grade);
    }
}