using System.Collections;

namespace CSharpFundamentals.Lesson6;

public class Task9
{
    public void ElementsCountInList()
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
            List<string> list = new List<string>();

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter element {0}: ", i);
                list.Add(Console.ReadLine());
            }

            int elementsCount = list.Count;
            Console.WriteLine("The count of elements in the List: " + elementsCount);

            Console.WriteLine("The capacity of the elements in the List: " + list.Capacity);
        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void ElementsCountInHashTable()
    {
        try
        {
            Console.Write("Enter the size of the HashTable: ");
            int size = Convert.ToInt32(Console.ReadLine());

            if (size <= 0)
            {
                throw new Exception("Size be cannot zero or negative!");
            }

            Console.WriteLine("Enter the elements of the HashTable");
            Hashtable hashtable = new Hashtable();

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter key: ");
                int key = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter value: ");
                string value = Console.ReadLine();

                hashtable.Add(key, value);
            }

            int elementsCount = hashtable.Count;
            Console.WriteLine("The count of elements in the HashTable: " + elementsCount);
        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void ElementsCountInArrayList()
    {
        try
        {
            Console.Write("Enter the size of the ArrayList: ");
            int size = Convert.ToInt32(Console.ReadLine());

            if (size <= 0)
            {
                throw new Exception("Size cannot be zero or negative!");
            }

            Console.WriteLine("Enter the elements of the ArrayList");
            ArrayList arrayList = new ArrayList();

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter element {0}: ", i);
                arrayList.Add(Console.ReadLine());
            }

            int elementsCount = arrayList.Count;
            Console.WriteLine("The count of elements in the ArrayList: " + elementsCount);
        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void ElementsCountInHashSet()
    {
        try
        {
            Console.Write("Enter the size of the HashSet: ");
            int size = Convert.ToInt32(Console.ReadLine());

            if (size <= 0)
            {
                throw new Exception("Size cannot be zero or negative!");
            }

            Console.WriteLine("Enter the elements of the HashSet");
            HashSet<int> hashSet = new HashSet<int>();

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter elements {0}: ", i);
                hashSet.Add(Convert.ToInt32(Console.ReadLine()));
            }

            int elementsCount = hashSet.Count;
            Console.WriteLine("The count of the elements in the HashSet: " + elementsCount);
        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}