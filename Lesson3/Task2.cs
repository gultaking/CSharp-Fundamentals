namespace CSharpFundamentals.Lesson3;

public class Task2
{
    bool IsAdultPerson(int age)
    {
        if (age < 0)
        {
            throw new Exception("Age must be positive or zero!");
        }

        if (age > 18)
        {
            return true;
        }

        return false;
    }

    public void PrintAgeTests()
    {
        try
        {
            Console.WriteLine("PrintAgeTests started!");

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            bool isAdult = IsAdultPerson(age);
            Console.WriteLine(isAdult ? "You are an adult!" : "You are a minor");

            Console.WriteLine("PrintAgeTests ended!");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}