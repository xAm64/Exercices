using System;

namespace Tri_à_bulles
{
    class Program
    {
        static void Main (string[] args)
        {
            int[] formations = new int[10];
            int compteur = 0;

            do
            {
                Console.WriteLine ("Veuillez saisir l'effectif, pour la formation numéro: " + (compteur +1));
                int res = int.Parse (Console.ReadLine ());
                formations[compteur] = res;
                compteur++;
            } while (compteur < 10);

            Console.WriteLine ("--- --- Début de tableau (non trié) --- ---\n");
            for (int i = 0; i < formations.Length; i++)
            {
                Console.WriteLine ("Effectif formation: " + (i + 1) + " - " +formations[i]);
            }
            Console.WriteLine ("\n--- --- Fin de tableau --- ---");

            // Tri à bulle
            bool verif;
            do
            {
                verif = false;
                for (int i = 0; i < formations.Length -1; i++)
                {
                    if (formations[i] > formations[i + 1])
                    {
                        int temp = formations[i + 1];
                        formations[i + 1] = formations[i];
                        formations[i] = temp;
                        verif = true;
                    }
                }
            } while (verif);

            Console.WriteLine ("--- --- Début de tableau (trié) --- ---\n");
            for (int i = 0; i < formations.Length; i++)
            {
                Console.WriteLine ("Effectif formation: " + (i + 1) + " - " + formations[i]);
            }
            Console.WriteLine ("\n--- --- Fin de tableau --- ---");

            Console.ReadKey ();
        }
    }
}
