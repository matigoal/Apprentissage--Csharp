using System;

 
namespace TriparBubble
{
    public  class Program
    {
      public  static void Main(string[] args)
        {
            const int MaxTableau = 8;
            int K,L,I,J;
            int[] Tableau = { 15, 10, 23, 2, 8, 9, 14, 16 };//Tableau désordonnées
            Console.Write("BEFORE:");// écriture dans la console
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
            Console.Write("AFTER:");
            for(L = 0; L < MaxTableau; L++) {
                Console.Write(", " + Tableau[L]);
            }
            Console.WriteLine(); 
        }
    }
}
