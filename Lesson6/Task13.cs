namespace CSharpFundamentals.Lesson6;

public class Task13
{
    public void Concat()
    {
        try
        {
            Console.Write("Enter the size of the List: ");
            int size = Convert.ToInt32(Console.ReadLine());

            if (size <= 0)
            {
                throw new Exception("Size cannot be zero or negative!");
            }

            Console.WriteLine("Enter the elements of the List1");
            List<string> list1 = new List<string>();

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter element {0}: ", i);
                list1.Add(Console.ReadLine());
            }

            Console.WriteLine("Enter the elements of the List2");
            List<string> list2 = new List<string>();

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter element {0}: ", i);
                list2.Add(Console.ReadLine());
            }

            Console.WriteLine("Concatenation of two lists");
            IEnumerable<string> concat = list1.Concat(list2);
            
            foreach (string element in concat)
            {
                Console.WriteLine(element);
            }
        }
        
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
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