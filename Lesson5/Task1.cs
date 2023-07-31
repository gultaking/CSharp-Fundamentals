namespace CSharpFundamentals.Lesson5;

public class Task1
{
    public void InputStringTests()
    {
        Console.Write("Input string: ");
        string str = Console.ReadLine();
        
        Console.Write("Print string: ");
        PrintString(str);
    }

    void PrintString(string str)
    {
        Console.Write(str);
    }
}