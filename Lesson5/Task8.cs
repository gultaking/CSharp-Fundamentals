namespace CSharpFundamentals.Lesson5;

public class Task8
{
    public void StringTests()
    {
        try
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();

            Console.Write("Entered string: " + str);

            Console.WriteLine();

            int vowelsCount = FindCountVowels(str);
            Console.Write("Number of vowels: " + vowelsCount);

            Console.WriteLine();

            int consonantsCount = FindCountConsonants(str);
            Console.Write("Number of consonants: " + consonantsCount);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    int FindCountVowels(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            throw new Exception("String is null or empty!");
        }

        int vowelCount = 0;
        for (int i = 0; i < str.Length; i++)
        {
            switch (str[i])
            {
                case 'a':
                case 'o':
                case 'u':
                case 'i':
                case 'e':
                    vowelCount++;
                    break;
            }
        }

        return vowelCount;
    }

    int FindCountConsonants(string str)
    {
        int consonantsCount = 0;

        for (int i = 0; i < str.Length; i++)
        {
            switch (str[i])
            {
                case 'b':
                case 'c':
                case 'd':
                case 'f':
                case 'g':
                case 'h':
                case 'j':
                case 'k':
                case 'l':
                case 'm':
                case 'n':
                case 'p':
                case 'q':
                case 'r':
                case 's':
                case 't':
                case 'v':
                case 'w':
                case 'x':
                case 'y':
                case 'z':
                    consonantsCount++;
                    break;
            }
        }

        return consonantsCount;
    }
}