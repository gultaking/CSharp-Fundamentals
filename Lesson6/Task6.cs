using System.Collections;

namespace CSharpFundamentals.Lesson6;

public class Task6
{
    public void Contains()
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
            ArrayList myList = new ArrayList();

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter element {0}: ", i);
                myList.Add(Console.ReadLine());
            }

            Console.Write("Enter an element to check: ");
            var element = Console.ReadLine();

            bool contains = myList.Contains(element);
            Console.Write($"The result of the searched element: {contains}");
        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void Find()
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
            List<string> list = new List<string>();

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter element {0}: ", i);
                list.Add(Console.ReadLine());
            }

            string findElement = list.Find(el => el.StartsWith("A"));
            Console.Write("The first element that matches the condition" + findElement);
        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void FindAll()
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
            List<string> list = new List<string>();

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter element {0}: ", i);
                list.Add(Console.ReadLine());
            }

            List<string> findAll = list.FindAll(el => el.StartsWith("S"));

            Console.WriteLine("All Searched elements");
            foreach (string item in findAll)
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