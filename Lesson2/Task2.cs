namespace CSharpFundamentals.Lesson2;

using System;

public class Task2
{
    public double ConvertCelsiusToFahrenheit(double celsiusAmount)
    {
        return (5 * celsiusAmount / 9) + 32;
    }

    public double ConvertFahrenheitToCelsius(double fahrenheitAmount)
    {
        return 5 * (fahrenheitAmount - 32) / 9;
    }

    public void CelsiusToFahrenheitTests()
    {
        Console.Write("Enter the value of Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = ConvertCelsiusToFahrenheit(celsius);
        Console.WriteLine(celsius + "°C in Fahrenheit is: " + fahrenheit + "°F");
    }

    public void FahrenheitToCelsiusTests()
    {
        Console.Write("Enter the value of Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        double celsius = ConvertFahrenheitToCelsius(fahrenheit);
        Console.WriteLine(fahrenheit + "°F in Celsius is: " + celsius + "°C");
    }
}