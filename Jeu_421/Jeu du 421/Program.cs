using System;

namespace Jeu_du_421
{
    class Program
    {
        #region Variables
        private static int numberOfTry;
        // mes variables
        private static ConsoleKey touche = ConsoleKey.Spacebar;
        #endregion

        #region Fonctions
        //Véfif entier
        public static int Verif (string _message)
        {
            bool ok;
            int number;
            do
            {
                ok = true;
                Console.WriteLine (_message);
                string saisie = Console.ReadLine ();
                ok = int.TryParse (saisie, out number);
                if (!ok)
                {
                    Console.WriteLine ("Écrit moi une valeur en chiffres, je ne suis pas madame soleil");
                }
                if (number <= 0)
                {
                    Console.WriteLine ("La valeur doit être supérieure à 0");
                }
            } while (!ok);
            
            return number;
        }
        #endregion

        static void Main (string[] args)
        {
            Games jeu = new Games ();
            Console.WriteLine ("┼┼┼┼┼┼┼▄▀▀▀▄▄▄▄▄▄▄▀▀▀▄┼┼┼┼┼┼\n" +
            "┼┼┼┼┼┼┼█▒▒░░░░░░░░░▒▒█┼┼┼┼┼┼\n" +
            "┼┼┼┼┼┼┼┼█░░█░░░░░█░░█┼┼┼┼┼┼┼\n" +
            "┼┼┼┼─▄▄──█░░░▀█▀░░░█──▄▄─┼┼┼\n" +
            "┼┼┼┼█░░█─▀▄░░░░░░░▄▀─█░░█┼┼┼\n" +
            "┼██░██░████░██░░░██░░░█████┼\n" +
            "┼██▄██░██▄▄░██░░░██░░░██░██┼\n" +
            "┼██▀██░██▀▀░██░░░██░░░██░██┼\n" +
            "┼██░██░████░████░████░█████┼\n" +
                "Jeu du 421\nLancer les dés, pour faire 421 et c'est gagné, mais attention aux nombres de tentatives, car plus il t'en restera moins tu gagneras de points, pas assez et tu perdra.");
            do
            {
                try
                {
                    numberOfTry = Verif ("Combien d'essais voulez-vous faire ?");
                    jeu.Partie (numberOfTry);

                    Console.WriteLine ("Pour sortir du jeux appuyer sur la touche [S]. Pour recommencer une nouvelle partie appuyer sur n'importe quelle touche.");
                    touche = Console.ReadKey ().Key;
                }
                catch (Exception error)
                {
                    Console.WriteLine ("Erreur: " + error.Message);
                }
            } while (ConsoleKey.S != touche);
            


            Console.ReadLine ();
        }
    }
}
