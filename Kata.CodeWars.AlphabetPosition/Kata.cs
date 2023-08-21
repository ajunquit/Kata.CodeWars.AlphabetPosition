using System.Linq;

public static class Kata
{
    public static string AlphabetPosition(string text)
    {
        var alphabet = "abcdefghijklmnopqrstuvwxyz";
        List<int> letters = new List<int>();

        foreach (var letter in text.ToLower())
        {
            int index = alphabet.IndexOf(letter) + 1;
            if (index > 0)
                letters.Add(index);
        }

        return string.Join(" ", letters);
    }
}