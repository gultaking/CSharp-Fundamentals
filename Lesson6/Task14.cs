namespace CSharpFundamentals.Lesson6;

using System.Collections;

public class Task14
{
    public void ToList()
    {
        IEnumerable<int> enumerable = Enumerable.Range(1, 10);

        Console.WriteLine("Convert IEnumerable to List");
        List<int> list = enumerable.ToList();

        foreach (int item in list)
        {
            Console.WriteLine(item);
        }
    }

    public void ToArray()
    {
        Console.Write("Enter the size of the List: ");
        int size = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the elements of the List");
        List<int> list = new List<int>();

        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter element {0}: ", i);
            list.Add(Convert.ToInt32(Console.ReadLine()));
        }

        Console.WriteLine("Convert List to Array");
        int[] array = list.ToArray();

        foreach (int item in array)
        {
            Console.WriteLine(item);
        }
    }

    public void ToDictionary()
    {
        List<Student> list = new List<Student>()
        {
            new Student { Id = 1, Name = "Rima" },
            new Student(){Id = 2, Name = "Raul"}
        };

        Console.WriteLine("Convert List to Dictionary");
        Dictionary<int, string> dictionary = list.ToDictionary(item => item.Id, item => item.Name);

        foreach (KeyValuePair<int, string> item in dictionary)
        {
            Console.WriteLine(item.Key + item.Value);
        }
    }
}

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}