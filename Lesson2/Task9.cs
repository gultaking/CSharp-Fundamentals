namespace CSharpFundamentals.Lesson2;

class Task9
{
    public void CalculateAmountBank()
    {
        Console.WriteLine("Calculate the amount in the bank account with anual interest.");

        Console.Write("Enter amount: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the annual percentage rate: ");
        double percentage = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter year: ");
        double year = Convert.ToDouble(Console.ReadLine());

        double amountPercentage = amount / 100 * percentage;
        double result = amountPercentage * year;

        Console.WriteLine("Amount in the bank at annual interest: " + result);
    }
}