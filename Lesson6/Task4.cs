namespace CSharpFundamentals.Lesson6;

public class Task4
{
    public void Remove()
    {
        try
        {
            Console.Write("Enter the size of the List: ");
            int size = Convert.ToInt32(Console.ReadLine());

            if (size <= 0)
            {
                throw new Exception("Size cannot be zero or negative!");
            }

            Console.WriteLine("Enter elements of the List");
            List<string> myList = new List<string>();

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter element {0}: ", i);
                myList.Add(Console.ReadLine());
            }

            Console.Write("Enter the element to delete: ");
            string element = Console.ReadLine();

            if (element == null || !myList.Contains(element))
            {
                throw new Exception("Element cannot be null or element not found in List!");
            }

            if (myList.Remove(element))
            {
                Console.WriteLine($"Element is removed: {element}");
            }
            else
            {
                Console.WriteLine($"Element is not removed: {element}");
            }

            Console.WriteLine("Element of the List");
            foreach (string item in myList)
            {
                Console.WriteLine(item);
            }
        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void RemoveAt()
    {
        try
        {
            Console.Write("Enter the size of the List: ");
            int size = Convert.ToInt32(Console.ReadLine());

            if (size <= 0)
            {
                throw new Exception("Size cannot be zero or negative!");
            }

            Console.WriteLine("Enter elements of the List");
            List<int> myList = new List<int>();

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter element {0}: ", i);
                myList.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.Write("Enter index: ");
            int index = Convert.ToInt32(Console.ReadLine());

            if (index >= myList.Count || index < 0)
            {
                throw new Exception("Index cannot be less than zero or greater than or equal to Count");
            }

            myList.RemoveAt(index);
            Console.WriteLine($"Element with index {index} has been removed");
            
            Console.WriteLine("Element of the List");
            foreach (int item in myList)
            {
                Console.WriteLine(item);
            }
        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void Dequeue()
    {
        Console.Write("Enter the size of Queue: ");
        int size = Convert.ToInt32(Console.ReadLine());

        if (size <= 0)
        {
            throw new Exception("Size cannot be zero or negative!");
        }

        Console.WriteLine("Enter the element of the Queue");
        Queue<int> queue = new Queue<int>();

        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter element: ");
            queue.Enqueue(Convert.ToInt32(Console.ReadLine()));
        }

        queue.Dequeue();

        Console.WriteLine("Elements of the Queue");
        foreach (int element in queue)
        {
            Console.WriteLine(element);
        }
    }

    public void Pop()
    {
        Console.Write("Enter the size of Stack: ");
        int size = Convert.ToInt32(Console.ReadLine());

        if (size <= 0)
        {
            throw new Exception("Size cannot be zero or negative!");
        }

        Console.WriteLine("Enter the element of the Stack");
        Stack<double> stack = new Stack<double>();

        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter element: ");
            stack.Push(Convert.ToDouble(Console.ReadLine()));
        }

        stack.Pop();

        Console.WriteLine("Element of the Stack");
        foreach (double element in stack)
        {
            Console.WriteLine(element);
        }
    }
}