using System.Collections;
namespace CSharpFundamentals.Lesson6;

public class Task7
{
    public void SortList()
    {
        try
        {
            Console.Write("Enter the size of the List: ");
            int size = Convert.ToInt32(Console.ReadLine());

            if (size <= 0)
            {
                throw new Exception("The size cannot be zero or negative!");
            }

            Console.WriteLine("Enter the element of the List");
            List<int> list = new List<int>();

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter element {0}: ", i);
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }

            list.Sort();

            Console.WriteLine("Sorted List");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void SortDictionary()
    {
        try
        {
            Console.Write("Enter the size of the Dictionary: ");
            int size = Convert.ToInt32(Console.ReadLine());

            if (size <= 0)
            {
                throw new Exception("The size cannot be zero or negative!");
            }

            Console.WriteLine("Enter the element of the Dictionary");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter key: ");
                int key = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter value: ");
                string value = Console.ReadLine();

                dictionary.Add(key, value);
            }

            Dictionary<int, string> sortedDictionary =
                dictionary.OrderBy(pair => pair.Key).ToDictionary(pair => pair.Key, pair => pair.Value);

            Console.WriteLine("Sorted Dictionary");
            foreach (KeyValuePair<int, string> item in sortedDictionary)
            {
                Console.Write(item.Key + item.Value);
            }
        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void SortArrayList()
    {
        try
        {
            Console.Write("Enter the size of the ArrayList: ");
            int size = Convert.ToInt32(Console.ReadLine());

            if (size <= 0)
            {
                throw new Exception("The size cannot be zero or negative!");
            }

            Console.WriteLine("Enter the element of the ArrayList");
            ArrayList arrayList = new ArrayList();

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter element {0}: ", i);
                arrayList.Add(Console.ReadLine());
            }

            arrayList.Sort();

            Console.WriteLine("Sorted ArrayList");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
        
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}