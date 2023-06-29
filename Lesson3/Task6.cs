using System.ComponentModel.Design;

namespace CSharpFundamentals.Lesson3;

public class Task6
{ 
    double FindMax(double number1, double number2, double number3)
    {
        if (number1 > number2)
        {
            if (number1 > number3)
            {
                return number1;
            }
            
            return number3;
        }
        else if (number2 > number3)
        {
            return number2;
        }

        return number3;
    }

    public void FindMaxTests()
    {
        Console.Write("Enter first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter third number: ");
        double number3 = Convert.ToDouble(Console.ReadLine());
        
        double maxNumber = FindMax(number1,number2,number3);

        Console.WriteLine("{0} is the largest number",maxNumber);
    }
}