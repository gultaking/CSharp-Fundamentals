namespace CSharpFundamentals.Lesson3;

public class Task1
{
    public void PrintEvenOrOdd()
    {
        Console.Write("Enter the number to check odd or even: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Number is even");
        }
        else
        {
            Console.WriteLine("Number is Odd");
        }
    }
}