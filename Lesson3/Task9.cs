namespace CSharpFundamentals.Lesson3;

public class Task9
{
    public int Signum(int number)
    {
        if (number > 0)
        {
            return 1;
        }

        if (number < 0)
        {
            return -1;
        }

        return 0;
    }

    public void SignumTests()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int checkNumber = Signum(number);

        if (checkNumber == 1)
        {
            Console.WriteLine("Number is positive");
        }

        else if (checkNumber == -1)
        {
            Console.WriteLine("Number is negative!");
        }
        else
        {
            Console.WriteLine("Number is zero!");
        }
    }
}