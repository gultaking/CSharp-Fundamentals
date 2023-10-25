namespace CSharpFundamentals.Lesson6;

public class Task5
{
    public void IterationForeachOverDictionary()
    {
        try
        {
            Console.Write("Enter the size of the Dictionary: ");
            int size = Convert.ToInt16(Console.ReadLine());

            if (size <= 0)
            {
                throw new Exception("Size cannot be zero or negative!");
            }

            Console.WriteLine("Enter the elements of the Dictionary");
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter key of the Dictionary: ");
                string key = Console.ReadLine();

                Console.Write("Enter value of the Dictionary:");
                string value = Console.ReadLine();

                dictionary.Add(key, value);
            }

            Console.WriteLine("Element of the Dictionary");
            foreach (KeyValuePair<string, string> element in dictionary)
            {
                Console.WriteLine($"Key: {element.Key}, Value: {element.Value}");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void IterationForeachOverList()
    {
        try
        {
            Console.Write("Enter the size of the List: ");
            int size = Convert.ToInt32(Console.ReadLine());

            if (size <= 0)
            {
                throw new Exception("Size cannot be zero or negative!");
            }

            Console.WriteLine("Enter the elements of the List");
            List<int> list = new List<int>();

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter element: ");
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine("Elements of the List");
            foreach (int element in list)
            {
                Console.WriteLine(element);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}