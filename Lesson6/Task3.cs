namespace CSharpFundamentals.Lesson6;

public class Task3
{
    public void FindElementByIndexInList()
    {
        Console.Write("Enter the size of the List: ");
        int elementSize = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter elements of the List");
        List<string> studentNames = new List<string>();

        for (int i = 0; i < elementSize; i++)
        {
            Console.Write("Enter element {0}: ", i);
            studentNames.Add(Console.ReadLine());
        }

        Console.Write("Enter index: ");
        int index = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < elementSize; i++)
        {
            if (index == i)
            {
                Console.WriteLine(studentNames[i]);
            }
        }

        string elementAt = studentNames.ElementAt(index);
        Console.WriteLine(elementAt);
    }

    public void FindElementByIndexInDictionary()
    {
        Console.Write("Enter the size of the Dictionary: ");
        int elementSize = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter element of the Dictionary");
        Dictionary<int, string> dictionary = new Dictionary<int, string>();

        for (int i = 0; i < elementSize; i++)
        {
            Console.Write("Enter key: ");
            int key = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter value: ");
            string value = Console.ReadLine();
            dictionary.Add(key, value);
        }

        Console.Write("Enter index: ");
        int index = Convert.ToInt32(Console.ReadLine());

        KeyValuePair<int, string> element = dictionary.ElementAt(index);
        Console.WriteLine("Key: {0}, Value: {1}", element.Key, element.Value);
    }

    public void FindFirstOrDefaultValueInList()
    {
        Console.Write("Enter the size of the List: ");
        int size = Convert.ToInt32(Console.ReadLine());

        List<int> list = new List<int>();
        Console.WriteLine("Enter elements of the List");

        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter element {0}: ", i);
            list.Add(Convert.ToInt32(Console.ReadLine()));
        }

        int result = list.FirstOrDefault();
        Console.WriteLine("First or default value of the List: " + result);
    }

    public void TryGetValueInDictionary()
    {
        Console.Write("Enter the size of the Dictionary: ");
        int elementSize = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter element of the Dictionary");
        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        for (int i = 0; i < elementSize; i++)
        {
            Console.Write("Enter key: ");
            string key = Console.ReadLine();

            Console.Write("Enter value: ");
            string value = Console.ReadLine();

            dictionary.Add(key, value);
        }

        Console.Write("Enter value: ");
        string keyWord = Console.ReadLine();
        
        string result = "";

        bool checkValue = dictionary.TryGetValue(keyWord, out result);
        Console.Write(checkValue);
    }
}