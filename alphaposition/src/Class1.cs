using System.Collections.Generic;

namespace AlphabetKata;
public static class Alphabet
{

    public static string AlphabetPosition(string text)
    {
        var arrayText = text.Where(char.IsLetter)
            .Select(char.ToUpper)
            .ToArray();
        var position = 0;
        text = String.Empty;

        foreach (char letter in arrayText)
        {
            position = DictionaryAlphabet.FirstOrDefault(x => x.Key == letter).Value;
            text += $"{position} ";
        }


        return text.TrimEnd();
    }

    private static Dictionary<char, int> DictionaryAlphabet
    {
        get
        {
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            var dictionaryAlphabet = new Dictionary<char, int>();

            var position = 1;

            foreach (char letter in alpha)
            {
                dictionaryAlphabet.Add(letter, position++);

            }

            return dictionaryAlphabet;
        }
    }
}
