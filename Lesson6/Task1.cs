using System.Collections;
namespace CSharpFundamentals.Lesson6;
using System.Collections.Generic;

public class Task1
{
    public void CollectionsTests()
    {
        List<int> list = new List<int>();

        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>();

        SortedList<int, string> sortedList = new SortedList<int, string>();

        Stack<bool> stack = new Stack<bool>();

        Queue<byte> queue = new Queue<byte>();

        Hashtable hashtable = new Hashtable();

        HashSet<int> hashSet = new HashSet<int>();
    }
}