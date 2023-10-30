namespace CSharpFundamentals.Lesson6;

public class Task11
{
    public void ClearMethodInList()
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

            list.Clear();

            Console.WriteLine("The count of elements in the List: " + list.Count);
            Console.WriteLine("Elements in the list have been deleted.");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}