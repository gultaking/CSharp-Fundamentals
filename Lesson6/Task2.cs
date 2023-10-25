namespace CSharpFundamentals.Lesson6;

public class Task2
{
    public void Add()
    {
        Console.Write("Enter the size of the list: ");
        int elementSize = Convert.ToInt32(Console.ReadLine());

        List<string> names = new List<string>();

        Console.WriteLine("Enter the elements of the List");
        for (int i = 0; i < elementSize; i++)
        {
            Console.Write("Enter person's name:");
            names.Add(Console.ReadLine());
        }

        Console.WriteLine("Elements of the list:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }

    public void AddRange()
    {
        Console.Write("Enter the length of the array: ");
        int length = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the elements of the array:");
        int[] array = new int[length];

        for (int i = 0; i < length; i++)
        {
            Console.Write("Array {0}: ", i);
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        List<int> list = new List<int>();
        list.AddRange(array);

        Console.WriteLine("Elements of the list:");
        foreach (int element in list)
        {
            Console.WriteLine(element);
        }
    }

    public void Push()
    {
        Console.Write("Enter the size of the Stack: ");
        int elementSize = Convert.ToInt32(Console.ReadLine());

        Stack<int> numbers = new Stack<int>();

        for (int i = 0; i < elementSize; i++)
        {
            Console.Write("Enter element {0}: ", i);
            numbers.Push(Convert.ToInt32(Console.ReadLine()));
        }

        Console.WriteLine("Elements of the Stack:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }

    public void Enqueue()
    {
        Console.Write("Enter the size of the Queue: ");
        int elementSize = Convert.ToInt32(Console.ReadLine());

        Queue<int> numbers = new Queue<int>();

        Console.WriteLine("Enter the elements of the Queue");
        for (int i = 0; i < elementSize; i++)
        {
            Console.Write("Enter element {0}: ", i);
            numbers.Enqueue(Convert.ToInt32(Console.ReadLine()));
        }

        Console.WriteLine("Elements of the Queue");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}