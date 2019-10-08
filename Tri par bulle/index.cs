using System;

 
namespace TriBubble
{
  public class Program
    {
       public static void Main(string[] args)
        {
            const int MaxTableau = 13;//définition taille du tableau
            int K,L,I,J;
            int[] Tableau = { 9, 12, 26, 6, 86, 34, 14, 16, 23, 43, 56, 78, 99};// Valeur initial tableau(désordonnées)
            Console.Write("Before:");
            for(K = 0; K < MaxTableau; K++) Console.Write(Tableau[K] + ", ");
 
            for(I = MaxTableau - 2;I >= 0; I--) {
                for(J = 0; J <= I; J++) {
                    if(Tableau[J + 1] < Tableau[J]) {
                        int t = Tableau[J + 1];
                        Tableau[J + 1] = Tableau[J];
                        Tableau[J] = t;
                    }
                }
            }
            Console.WriteLine();
            Console.Write("After:");
            for(L = 0; L < MaxTableau; L++) {
                Console.Write(", " + Tableau[L]);
            }
            Console.WriteLine(); 
        }
    }
}
