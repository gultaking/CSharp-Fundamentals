namespace CSharpFundamentals.Lesson6;

public class Task8
{
    public void LinqQueryInList()
    {
        try
        {
            Console.Write("Enter the size of the List: ");
            int size = Convert.ToInt32(Console.ReadLine());

            if (size <= 0)
            {
                throw new Exception("Size cannot be zero or negative!");
            }
        
            Console.WriteLine("Enter the element of the List");
            List<string> list = new List<string>();

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter element{0}: ", i);
                list.Add(Console.ReadLine());
            }

            Console.WriteLine("The elements of the List");
            list.ForEach(element => Console.WriteLine(element));
        }
        
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void LinqQueryInDictionary()
    {
        Console.Write("Enter the size of the Dictionary: ");
        int size = Convert.ToInt16(Console.ReadLine());

        if (size <= 0)
        {
            throw new Exception("Size cannot be zero or negative!");
        }

        Console.WriteLine("Enter the elements of the Dictionary");
        Dictionary<int, string> dictionary = new Dictionary<int, string>();

        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter key of the Dictionary: ");
            int key = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter value of the Dictionary:");
            string value = Console.ReadLine();

            dictionary.Add(key, value);
        }

        Console.Write("Enter the key to check: ");
        int checkKey = Convert.ToInt32(Console.ReadLine());

        var check = from element in dictionary
            where element.Key.Equals(checkKey)
            select element;

        foreach (KeyValuePair<int, string> element in check)
        {
            Console.WriteLine($"Key = {element.Key} , Value = {element.Value}");
        }
    }
}

