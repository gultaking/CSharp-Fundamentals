namespace CSharpFundamentals.Lesson3;

public class Task7
{
    bool IsVowel(char character)
    {
        bool isVowel = false;

        if (character < 65 || character > 122)
        {
            throw new Exception("Enter only letter, please!");
        }

        switch (character.ToString().ToLower())
        {
            case "a":
            case "e":
            case "i":
            case "o":
            case "u":
                isVowel = true;
                break;
        }

        return isVowel;
    }

    public void FindCharacterTest()
    {
        try
        {
            Console.Write("Enter letter: ");
            char letter = Convert.ToChar(Console.Read());

            bool isVowel = IsVowel(letter);
            Console.WriteLine(isVowel ? "Letter is vowel" : "Letter is consonant");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}