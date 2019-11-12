using System;
using System.Collections.Generic;
using System.Text;

namespace Jeu_du_421
{
    class Games
    {
        Lance lancer = new Lance ();
        private static ConsoleKey touche = ConsoleKey.Spacebar;

        #region partie
        public void Partie (int _nombresTentatives)
        {
            lancer.SetScore (_nombresTentatives);
            lancer.StartGame ();
            do
            {
                Console.Clear();
                Console.WriteLine ("Il vous reste: " + lancer.GetScore() + " " + Tentative(lancer.GetScore()));
                Console.WriteLine ("État des dés:\n" + lancer.AfficherD ());
                Console.WriteLine ("Voici les options :\nPour vérouiller le dé utiliser les touches numériques : [1],[2],[3]\nUne fois le verouillage choisis appuyer sur [L] pour lancer les dés");
                touche = Console.ReadKey ().Key;
                switch (touche)
                {
                    case ConsoleKey.D1:
                        lancer.LockInverser1 ();
                        break;
                    case ConsoleKey.D2:
                        lancer.LockInverser2 ();
                        break;
                    case ConsoleKey.D3:
                        lancer.LockInverser3 ();
                        break;
                    case ConsoleKey.L:
                        lancer.Lancer ();
                        break;
                    default:
                        Console.WriteLine ("cette touche n'existe pas");
                        break;
                }

            } while (!lancer.GameOver());
        }
        #endregion
        #region Fonction
        private string Tentative (double _nbre)
        {
            string mot;
            if (_nbre > 1)
            {
                mot = "tentative";
            }
            else
            {
                mot = "tentatives";
            }
            return mot;
        }
        #endregion
    }
}
