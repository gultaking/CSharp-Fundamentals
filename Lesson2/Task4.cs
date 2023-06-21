namespace CSharpFundamentals.Lesson2;

class Task4
{
    public double ConvertManatToDollar(double manat)
    {
        if (manat <= 0)
        {
            throw new Exception("Currency must be greater than zero!");
        }

        return manat / 1.7;
    }

    public double ConvertDollarToManat(double dollar)
    {
        if (dollar <= 0)
        {
            throw new Exception("Currency must be greater than zero!");
        }

        return dollar * 1.7;
    }

    public double ConvertManatToRuble(double manat)
    {
        if (manat <= 0)
        {
            throw new Exception("Currency must be greater than zero!");
        }

        return manat / 0.0202;
    }

    public double ConvertRubleToManat(double ruble)
    {
        if (ruble <= 0)
        {
            throw new Exception("Currency must be greater than zero!");
        }

        return ruble * 0.0202;
    }

    public double ConvertManatToEuro(double manat)
    {
        if (manat <= 0)
        {
            throw new Exception("Currency must be greater than zero!");
        }

        return manat / 1.8558;
    }

    public double ConvertEuroToManat(double euro)
    {
        if (euro <= 0)
        {
            throw new Exception("Currency must be greater than zero!");
        }

        return euro * 1.8558;
    }

    public void ExchangeManatDollarTests()
    {
        try
        {
            Console.WriteLine("Manat/Dollar exchange started!");

            Console.Write("Enter Manat: ");
            double manat = Convert.ToDouble(Console.ReadLine());
            double dollarResult = ConvertManatToDollar(manat);
            Console.WriteLine(manat + " Manat(s) equals  " + dollarResult + "  Dollar(s)");

            Console.Write("Enter Dollar: ");
            double dollar = Convert.ToDouble(Console.ReadLine());
            double manatResult = ConvertDollarToManat(dollar);
            Console.WriteLine(dollar + " Dollar(s) equals  " + manatResult + " Manat(s)");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    public void ExchangeManatRubleTests()
    {
        try
        {
            Console.WriteLine("Manat/Ruble exchange started!");

            Console.Write("Enter Manat: ");
            double manat = Convert.ToDouble(Console.ReadLine());
            double manatResult = ConvertManatToRuble(manat);
            Console.WriteLine(manat + " Manat(s) equals  " + manatResult + "  Ruble(s)");

            Console.Write("Enter Ruble: ");
            double ruble = Convert.ToDouble(Console.ReadLine());
            double rubleResult = ConvertRubleToManat(ruble);
            Console.WriteLine(ruble + " Ruble(s) equals  " + rubleResult + " Manat(s)");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    public void ExchangeManatEuroTest()
    {
        try
        {
            Console.WriteLine("Manat/Euro exchange started!");

            Console.Write("Enter Manat: ");
            double manat = Convert.ToDouble(Console.ReadLine());
            double manatResult = ConvertManatToEuro(manat);
            Console.WriteLine(manat + " Manat(s) equals  " + manatResult + "  Euro(s)");

            Console.Write("Enter Euro: ");
            double euro = Convert.ToDouble(Console.ReadLine());
            double euroResult = ConvertEuroToManat(euro);
            Console.WriteLine(euro + " Euro(s) equals  " + euroResult + " Manat(s)");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}