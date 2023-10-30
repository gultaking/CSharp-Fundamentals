namespace CSharpFundamentals.Lesson6;

public class Task10
{
    public void TestOfAnyInList()
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
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }

            bool check1 = list.Any();
            Console.WriteLine(check1);

            bool check2 = list.Any(element => element % 2 == 0);
            Console.WriteLine(check2);
        }
        
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void AnyTest()
    {
        Console.Write("Enter the size of the Dictionary: ");
        int size = Convert.ToInt32(Console.ReadLine());

        if (size <= 0)
        {
            throw new Exception("Size cannot be zero or negative!");
        }

        Console.WriteLine("Enter the elements of the Dictionary");
        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter key: ");
            string key = Console.ReadLine();

            Console.Write("Enter value: ");
            string value = Console.ReadLine();

            dictionary.Add(key, value);
        }

        bool check1 = dictionary.Any();
        Console.WriteLine(check1);

        bool check2 = dictionary.Any(element => element.Value.StartsWith("S"));
        Console.WriteLine(check2);
    }
}