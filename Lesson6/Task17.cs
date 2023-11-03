namespace CSharpFundamentals.Lesson6;

public class Task17
{
    public void TryGetValueInDictionary()
    {
        try
        {
            Console.Write("Enter the size of the Dictionary: ");
            int elementSize = Convert.ToInt32(Console.ReadLine());

            if (elementSize <= 0)
            {
                throw new Exception("Size cannot be zero or negative!");
            }

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

            Console.Write("Enter key: ");
            string keyWord = Console.ReadLine();

            string result = " ";

            if (dictionary.TryGetValue(keyWord, out result))
            {
                Console.WriteLine($"For key = {keyWord},value = {result}");
            }
            else
            {
                Console.WriteLine($"Key = {keyWord} is not found!");
            }
        }
        
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void AddInDictionary()
    {
        try
        {
            Console.Write("Enter the size of the Dictionary: ");
            int elementSize = Convert.ToInt32(Console.ReadLine());

            if (elementSize <= 0)
            {
                throw new Exception("Size cannot be zero or negative!");
            }

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

            foreach (KeyValuePair<int, string> element in dictionary)
            {
                Console.WriteLine($"Key = {element.Key}, Value = {element.Value}");
            }
        }
        
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void RemoveInDictionary()
    {
        Console.Write("Enter the size of the Dictionary: ");
        int elementSize = Convert.ToInt32(Console.ReadLine());

        if (elementSize <= 0)
        {
            throw new Exception("Size cannot be zero or negative!");
        }

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

        Console.Write("Enter the element to delete: ");
        int element = Convert.ToInt32(Console.ReadLine());
        
        if (dictionary.Remove(element))
        {
            Console.WriteLine($"Element is removed: {element}");
        }
        
        else
        {
            Console.WriteLine($"Element not found in List: {element}");
        }
    }
}