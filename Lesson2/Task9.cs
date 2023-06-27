using Microsoft.VisualBasic;

namespace CSharpFundamentals.Lesson2;

class Task9
{
    public void CalculateAmountBankTests()
    {
        try
        {
            Console.WriteLine("Calculate the amount in the bank account with anual interest.");

            Console.Write("Enter amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the annual percentage rate: ");
            double percentage = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            double result = CalculateAmountBank(amount, percentage, year);
            Console.WriteLine("Amount in the bank at annual interest: " + result);
        }

        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    public double CalculateAmountBank(double amount, double percentage, int year)
    {
        if (amount <= 0)
        {
            throw new Exception("Amount cannot be zero or negative!");
        }
        
        if (percentage <= 0)
        {
            throw new Exception("Persentage cannot be zero or negative!");
        }

        if (year <= 0)
        {
            throw new Exception("Year cannot be zero or negative!");
        }
        
        double amountPercentage = (amount / 100) * percentage;
        return amountPercentage * year;
    }
}