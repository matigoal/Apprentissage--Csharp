using System;
using System.Linq;
// Début du programme MergesNames
public class MergeNames
{
    public static string[] UniqueNames(string[] array1, string[] array2)
    {
       
    return array1.Concat(array2).Distinct().ToArray();//utilisation des méthodes concat(concaténation) et distinct(distinction d'élément dans une séquence)
     
      
    }
    
    public static void Main(string[] args)
    {
        string[] array1 = new string[] {"Ava", "Emma", "Olivia"};//initialisation des tableaux(liste)
        string[] array2 = new string[] {"Olivia", "Sophia", "Emma"};
        Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(array1, array2))); // output : Ava, Emma, Olivia, Sophia
    }
}
