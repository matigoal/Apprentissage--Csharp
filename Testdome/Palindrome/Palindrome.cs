using System;
using System.Linq;

public class Palindrome
{
    public static bool IsPalindrome(string note) //type booléen
    {
        return note.ToLower().SequenceEqual(note.ToLower().Reverse());//function d'inversion
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(Palindrome.IsPalindrome("Deleveled"));
    }
}
