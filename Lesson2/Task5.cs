namespace CSharpFundamentals.Lesson2;

class Task5
{
    public void ReplaceValueVariableTests()
    {
        Console.WriteLine("Replacing the value of variables");
        Console.Write("Enter vaule1: ");
        int value1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter value2: ");
        int value2 = Convert.ToInt32(Console.ReadLine());
        value1 = value1 + value2;
        value2 = value1 - value2;
        value1 = value1 - value2;
        Console.WriteLine("value1 =  , " + value1 + " value2 =  " + value2);
    }
}