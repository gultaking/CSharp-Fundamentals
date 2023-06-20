namespace CSharpFundamentals.Lesson2;
using System;
public class Task2
{
    public void CelsiusToFahrenheitConversion()
    {
        Console.Write("Enter the value of Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = celsius * 9 / 5 + 32;
        Console.WriteLine(celsius + "°C in Fahrenheit is: " + fahrenheit + "°F");
        Console.Write("Enter the value of Fahrenheit: ");
        fahrenheit = Convert.ToDouble(Console.ReadLine());
        celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine(fahrenheit + "°F in Celsius is: " + celsius + "°C");
    }
}