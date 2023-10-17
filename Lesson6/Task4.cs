namespace CSharpFundamentals.Lesson6;

public class Task4
{
    public void RemoveElementInList()
    {
        Console.Write("Enter the size of the List: ");
        int size = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter elements of the List");
        List<string> myList = new List<string>();

        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter element {0}: ", i);
            myList.Add(Console.ReadLine());
        }

        
        Console.Write("Enter the element to delete: ");
        string element = Console.ReadLine();

        Console.WriteLine(element != null && myList.Remove(element) ? "Element is removed!" : "Element is not removed!");

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(myList[i]);
        }
    }
}