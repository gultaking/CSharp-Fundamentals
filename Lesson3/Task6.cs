using System.ComponentModel.Design;

namespace CSharpFundamentals.Lesson3;

public class Task6
{
    public void FindLargestNumber(int number1, int number2, int number3)
    {
        if (number1 > number2)
        {
            if (number1 > number3)
            {
                Console.WriteLine("Number {0} is largest!", number1);
            }
            else
            {
                Console.WriteLine("Number {0} is largest",  number3);
            }
        }
        else if (number2 > number3)
        {
            Console.WriteLine("Number {0} is largest!", number2);
        }

        else
        {
            Console.WriteLine("Number {0} is largest!" , number3);
        }
    }

    public void FindLargestNumberTest()
    {
        Console.Write("Enter number one: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter number two: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter number three: ");
        int number3 = Convert.ToInt32(Console.ReadLine());
        
        FindLargestNumber(number1,number2,number3);
    }
}