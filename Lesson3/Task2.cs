namespace CSharpFundamentals.Lesson3;

public class Task2
{
    public void PrintAge(int age)
    {
        if (age > 18)
        {
            Console.WriteLine("You are an adult!");
        }
        else
        {
            Console.WriteLine("You are a minor");
        }
    }

    public void PrintAgeTests()
    {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        PrintAge(age);
    }
}