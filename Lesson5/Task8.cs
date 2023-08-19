namespace CSharpFundamentals.Lesson5;

public class Task8
{
    public void StringTests()
    {
        try
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();

            if (string.IsNullOrEmpty(str))
            {
                throw new Exception("String is null or empty!");
            }

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
        int vowelCount = 0;

        foreach (char symbol in str)
        {
            if (IsVowel(symbol))
            {
                vowelCount++;
            }
        }

        return vowelCount;
    }

    bool IsVowel(char symbol)
    {
        bool isVowel = false;

        switch (symbol.ToString().ToLower())
        {
            case "a":
            case "o":
            case "u":
            case "i":
            case "e":
                isVowel = true;
                break;
        }

        return isVowel;
    }

    bool IsLetter(char symbol)
    {
        char loweredSymbol = symbol.ToString().ToLower()[0];
        
        for (char i = 'a'; i <= 'z'; i++)
        {
            if (i == loweredSymbol)
            {
                return true;
            }
        }

        return false;
    }
    
    int FindCountConsonants(string str)
    {
        int consonantsCount = 0;

        foreach (char symbol in str)
        {
            if (IsLetter(symbol) && !IsVowel(symbol))
            {
                consonantsCount++;
            }
        }

        return consonantsCount;
    }
}