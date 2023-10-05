namespace CSharpFundamentals.Lesson6;

public class Task2
{
    public void Add()
    {
        List<string> names = new List<string>();
        Console.WriteLine("Enter the elements of the List");
        names.Add(Console.ReadLine());
        names.Add(Console.ReadLine());
        names.Add(Console.ReadLine());
        names.Add(Console.ReadLine());
        
        foreach (string items in names)
        {
            Console.WriteLine(items);
        }
    }

    public void AddRange()
    {
        int[] array = new int[5] { 1, 2, 3, 4, 5 };

        List<int> list = new List<int>();
        
        list.AddRange(array);
    }
    public void Push()
    {
        Stack<int> number = new Stack<int>();
        number.Push(Convert.ToInt32(Console.ReadLine()));
        number.Push(Convert.ToInt32(Console.ReadLine()));
        number.Push(Convert.ToInt32(Console.ReadLine()));
        number.Push(Convert.ToInt32(Console.ReadLine()));

        foreach (var items in number)
        {
            Console.WriteLine(items);
        }
    }

    public void Enqueue()
    {
        Queue<int> number = new Queue<int>();
        number.Enqueue(Convert.ToInt32(Console.ReadLine()));
        number.Enqueue(Convert.ToInt32(Console.ReadLine()));
        number.Enqueue(Convert.ToInt32(Console.ReadLine()));
        number.Enqueue(Convert.ToInt32(Console.ReadLine()));

        foreach (int items in number)
        {
            Console.WriteLine(items);
        }
    }
}