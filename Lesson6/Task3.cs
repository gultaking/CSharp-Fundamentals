namespace CSharpFundamentals.Lesson6;

public class Task3
{
    public void FindElementByIndexInList()
    {
        try
        {
            Console.Write("Enter the size of the List: ");
            int elementSize = Convert.ToInt32(Console.ReadLine());

            if (elementSize <= 0)
            {
                throw new Exception("Size cannot be zero or negative!");
            }

            Console.WriteLine("Enter elements of the List");
            List<string> studentNames = new List<string>();

            for (int i = 0; i < elementSize; i++)
            {
                Console.Write("Enter element {0}: ", i);
                studentNames.Add(Console.ReadLine());
            }

            Console.Write("Enter index: ");
            int index = Convert.ToInt32(Console.ReadLine());

            if (index < 0 || index > studentNames.Count)
            {
                throw new Exception("Index cannot be less than zero or greater than Count");
            }

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
        
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void FindElementByIndexInDictionary()
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

            Console.Write("Enter index: ");
            int index = Convert.ToInt32(Console.ReadLine());

            if (index < 0 || index > dictionary.Count)
            {
                throw new Exception("Index cannot be less than zero or greater than Count");
            }

            KeyValuePair<int, string> element = dictionary.ElementAt(index);
            Console.WriteLine("Key: {0}, Value: {1}", element.Key, element.Value);
        }
        
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void FindFirstOrDefaultValueInList()
    {
        try
        {
            Console.Write("Enter the size of the List: ");
            int size = Convert.ToInt32(Console.ReadLine());

            if (size <= 0)
            {
                throw new Exception("Size cannot be zero or negative!");
            }

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
        
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

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
                Console.Write($"For key = {keyWord},value = {result}");
            }
            else
            {
                Console.Write($"Key = {keyWord} is not found!");
            }
        }
        
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}