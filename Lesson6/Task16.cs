namespace CSharpFundamentals.Lesson6;

public class Task16
{
    public void Intersect()
    {
        try
        {
            Console.Write("Enter the size of the List1: ");
            int size1 = Convert.ToInt32(Console.ReadLine());

            if (size1 <= 0)
            {
                throw new Exception("Size cannot be zero or negative!");
            }

            Console.WriteLine("Enter the elements of the List1");
            List<int> list1 = new List<int>();

            for (int i = 0; i < size1; i++)
            {
                Console.Write("Enter element {0}: ", i);
                list1.Add(Convert.ToInt32(Console.ReadLine()));
            }
        
            Console.Write("Enter the size of the List2: ");
            int size2 = Convert.ToInt32(Console.ReadLine());

            if (size2 <= 0)
            {
                throw new Exception("Size cannot be zero or negative!");
            }
        
            Console.WriteLine("Enter the elements of the List2");
            List<int> list2 = new List<int>();

            for (int i = 0; i < size2; i++)
            {
                Console.Write("Enter element {0}: ", i);
                list2.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine("Common elements from both collections");
            IEnumerable<int> result = list1.Intersect(list2);

            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
        }
        
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void Except()
    {
        Console.Write("Enter the size of the HashSet1: ");
        int size1 = Convert.ToInt32(Console.ReadLine());

        if (size1 <= 0)
        {
            throw new Exception("Size cannot be zero or negative!");
        }
        
        Console.WriteLine("Enter the elements of the HashSet1");
        HashSet<string> hashSet1 = new HashSet<string>();

        for (int i = 0; i < size1; i++)
        {
            Console.Write("Enter element {0}: ", i);
            hashSet1.Add(Console.ReadLine());
        }
        
        Console.Write("Enter the size of the HashSet2: ");
        int size2 = Convert.ToInt32(Console.ReadLine());

        if (size2 <= 0)
        {
            throw new Exception("Size cannot be zero or negative!");
        }
        
        Console.WriteLine("Enter the elements of the HashSet2");
        HashSet<string> hashSet2 = new HashSet<string>();

        for (int i = 0; i < size2; i++)
        {
            Console.Write("Enter element {0}: ", i);
            hashSet2.Add(Console.ReadLine());
        }

        Console.WriteLine("Common elements from both collections");
        IEnumerable<string> enumerable = hashSet1.Except(hashSet2);
        
        foreach (string item in enumerable)
        {
            Console.WriteLine(item);
        }
    }
    
    public void Union()
    {
        try
        {
            Console.Write("Enter the size of the Stack: ");
            int size = Convert.ToInt32(Console.ReadLine());

            if (size <= 0)
            {
                throw new Exception("Size cannot be zero or negative!");
            }

            Console.WriteLine("Enter the element of the Stack1");
            Stack<string> stack1 = new Stack<string>();

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter element: ");
                stack1.Push(Console.ReadLine());
            }

            Console.WriteLine("Enter the element of the Stack2");
            Stack<string> stack2 = new Stack<string>();

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter element: ");
                stack2.Push(Console.ReadLine());
            }

            Console.WriteLine("Concatenation of two Stack");
            IEnumerable<string> union = stack1.Union(stack2);
            
            foreach (string item in union)
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