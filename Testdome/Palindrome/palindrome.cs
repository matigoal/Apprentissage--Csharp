using System;
using System.Linq;

// Début du programme Palindrome
public class Palindrome{ 
    public static bool IsPalindrome(string The_Word){//méthode retourne vrai ou faux.
        return The_Word.ToLower().SequenceEqual(The_Word.ToLower().Reverse());//Comparaison des deux séquences égales ou non
    }

    public static void Main(string[] args){ //Exécution du programme
    
        Console.WriteLine(Palindrome.IsPalindrome("Deleveled"));// Ecrire sur la console
    }

}
