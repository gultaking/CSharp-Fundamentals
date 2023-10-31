using System.Runtime.InteropServices.JavaScript;
using Microsoft.VisualBasic;
using System.Collections;

namespace CSharpFundamentals.Lesson6;

public class Task12
{
    public void ToList()
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

            List<string> clonedList = list.ToList();

            Console.WriteLine("Original List:");
            Console.WriteLine(String.Join(",", list));

            Console.WriteLine("Cloned List:");
            Console.WriteLine(String.Join(",", clonedList));
        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void ToDictionary()
    {
        try
        {
            Console.Write("Enter the size of the Dictionary: ");
            int size = Convert.ToInt32(Console.ReadLine());

            if (size <= 0)
            {
                throw new Exception("Size cannot be zero or negative!");
            }

            Console.WriteLine("Enter the elements of the Dictionary");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter key: ");
                int key = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter value: ");
                string value = Console.ReadLine();

                dictionary.Add(key, value);
            }

            Console.WriteLine("Original Dictionary");
            foreach (KeyValuePair<int, string> element in dictionary)
            {
                Console.WriteLine($"Key = {element.Key} , Value = {element.Value}");
            }

            Console.WriteLine("Cloned Dictionary");
            Dictionary<int, string> clonedDictionary = dictionary.ToDictionary(pair => pair.Key, pair => pair.Value);

            foreach (KeyValuePair<int, string> element in clonedDictionary)
            {
                Console.WriteLine($"Key = {element.Key} , Value = {element.Value}");
            }
        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void ToArray()
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
                arrayList.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine("Original ArrayList");
            foreach (int item in arrayList)
            {
                Console.WriteLine(item);
            }
            
            int[] array = (int[])arrayList.ToArray(typeof(int));

            Console.WriteLine("Cloned ArrayList");
            foreach (var item in array)
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