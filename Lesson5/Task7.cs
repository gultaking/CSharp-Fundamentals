namespace CSharpFundamentals.Lesson5;

public class Task7
{
    public void StringTests()
    {
        Console.Write("Enter string: ");
        string str = Console.ReadLine();

        Console.Write("Entered string: " + str);

        Console.WriteLine();

        int alphabetCount = FindCountTheAlphabetInString(str);
        Console.Write("The number of letters in the string: " + alphabetCount);

        Console.WriteLine();

        int digitsCount = FindCountTheDigitsInString(str);
        Console.Write("The number of digits in the string: " + digitsCount);

        Console.WriteLine();

        int characterCount = FindCountTheCharacterInString(str);
        Console.Write("The number of special character in the string: " + characterCount);
    }

    int FindCountTheAlphabetInString(string str)
    {
        int alphabetCount = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
            {
                alphabetCount++;
            }
        }

        return alphabetCount;
    }

    int FindCountTheDigitsInString(string str)
    {
        int digitsCount = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] >= '0' && str[i] <= '9')
            {
                digitsCount++;
            }
        }

        return digitsCount;
    }

    int FindCountTheCharacterInString(string str)
    {
        int charactersCount = 0;

        char[] character = { '@', '#', '$', '!', '%', '^', '*', '(', ')', '-', '+', '{', '}', ']', '<', '>', '=',':'};

        for (int i = 0; i < str.Length; i++)
        {
            for (int j = 0; j < character.Length; j++)
            {
                if (str[i] == character[j])
                {
                    charactersCount++;
                }
            }
        }

        return charactersCount;
    }
}