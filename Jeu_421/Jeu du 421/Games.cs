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
                Console.WriteLine ("Voici les options :\n" +
                    "[I] Pour intervertir 2 dés\n" +
                    "Touche numérique [1],[2],[3] pour vérouiller le dé de votre choix\n" +
                    "[L] pour lancer les dés");
                touche = Console.ReadKey ().Key;
                switch (touche)
                {
                    #region Dés
                    case ConsoleKey.D1:
                        lancer.LockInverser1 ();
                        break;
                    case ConsoleKey.D2:
                        lancer.LockInverser2 ();
                        break;
                    case ConsoleKey.D3:
                        lancer.LockInverser3 ();
                        break;
                    #endregion
                    #region Intervertir
                    case ConsoleKey.I:
                        bool ok1, ok2;
                        int inv1, inv2;
                        do
                        {
                            do
                            {
                                ok1 = false;
                                inv1 = Program.Verif ("Quel est le premier dé a intervertir ?");
                                if (inv1 >= 1 && inv1 <= 3)
                                {
                                    ok1 = true;
                                }
                                else
                                {
                                    Console.WriteLine ("Le jeux ne compte que 3 dés");
                                }
                            } while (!ok1);
                            do
                            {
                                ok1 = false;
                                inv2 = Program.Verif ("On le change avec quel dé ?");
                                if (inv2 >= 1 && inv2 <= 3)
                                {
                                    ok1 = true;
                                }
                            } while (!ok1);
                            if (inv1 == inv2)
                            {
                                ok2 = false;
                                Console.WriteLine ("Vous me demander de déplacer le même dé");
                                ok2 = false;
                            }
                            else
                            {
                                lancer.Intervertir (inv1, inv2);
                                ok2 = true;
                            }
                        } while (!ok2);
                        break;
                    #endregion
                    #region Lancer
                    case ConsoleKey.L:
                        lancer.Lancer ();
                        break;
                    #endregion
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
