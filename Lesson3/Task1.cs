namespace CSharpFundamentals.Lesson3;

public class Task1
{
    public void EvenOrOddTests()
    {
        Console.WriteLine("EvenOrOddTests started!");
        
        Console.Write("Enter the number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        bool isEvenNumber = IsEvenNumber(number);
        Console.WriteLine(isEvenNumber ? "Number is even!" : "Number is odd!");
        
        Console.WriteLine("EvenOrOddTests ended!");
    }

    public bool IsEvenNumber(long number)
    {
        if (number % 2 == 0)
        {
            return true;
        }

        return false;
    }
}