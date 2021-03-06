﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Jeu_du_421
{
    class Lance
    {
        #region Variables
        double score;
        // Variables suplémentaires
        #endregion
        #region Fonction
        public string EtatVerou (De _identifiant)
        {
            string afficher;
            if (_identifiant.GetEtat ())
            {
                afficher = "vérouiller";
            }
            else
            {
                afficher = "déverouiller";
            }
            return afficher;
        }
        #endregion

        De de1 = new De ();
        De de2 = new De ();
        De de3 = new De ();

        #region Score
        public double GetScore ()
        {
            return this.score;
        }
        public void SetScore (int _lances)
        {
            this.score = (_lances);
        }
        #endregion
        #region Lancer les dés
        public void Lancer ()
        {
            if (!de1.GetEtat())
            {
                de1.Lancer ();
            }
            if (!de2.GetEtat())
            {
                de2.Lancer ();
            }
            if (!de3.GetEtat())
            {
                de3.Lancer ();
            }
            if ( de1.GetEtat() && de2.GetEtat() && de3.GetEtat())
            {
                Console.WriteLine("Impossible de lancer quand, les 3 dés sont vérouillés");
            }
            score -= 1;
        }
        #endregion
        #region Intervertir
        public void Intervertir (int _x, int _y)
        {
            int deZ;
            if (_x == 1)
            {
                deZ = de1.GetNumber ();
            }
            else if (_x == 2)
            {
                deZ = de2.GetNumber ();
            }
            else
            {
                deZ = de3.GetNumber ();
            }
            // 1x
            if (_x == 1 && _y == 2)
            {
                de1.SetNumber (de2.GetNumber ());
                de2.SetNumber (deZ);
            }
            if (_x == 1 && _y == 3)
            {
                de1.SetNumber (de3.GetNumber ());
                de3.SetNumber (deZ);
            }
            // 2x
            if (_x == 2 && _y == 1)
            {
                de2.SetNumber (de1.GetNumber ());
                de1.SetNumber (deZ);
            }
            if (_x == 2 && _y == 3)
            {
                de2.SetNumber (de3.GetNumber ());
                de3.SetNumber (deZ);
            }
            // 3x
            if (_x == 3 && _y == 1)
            {
                de3.SetNumber (de1.GetNumber ());
                de1.SetNumber (deZ);
            }
            if (_x == 3 && _y == 2)
            {
                de3.SetNumber (de2.GetNumber ());
                de2.SetNumber (deZ);
            }
        }
        #endregion

        #region Afficher dés
        public string AfficherD ()
        {
            string afficher = "Dé 1: " + de1.GetNumber () + " est: " + EtatVerou(de1) + ".\n" +
                "Dé 2: " + de2.GetNumber () + " est: " + EtatVerou(de2) + ".\n" +
                "Dé 3: " + de3.GetNumber () + " est : " + EtatVerou(de3);
            return afficher;        }
        #endregion
        #region Verouiller
        public void LockInverser1 ()
        {
            de1.SetEtat ();
        }
        public void LockInverser2 ()
        {
            de2.SetEtat ();
        }
        public void LockInverser3 ()
        {
            de3.SetEtat ();
        }
        #endregion
        #region Tout débloquer
        public void StartGame ()
        {
            de1.Unlock (); de1.Lancer ();
            de2.Unlock (); de2.Lancer ();
            de3.Unlock (); de3.Lancer ();
        }
        #endregion
        #region Fin du jeu
        public bool GameOver ()
        {
            bool gameOver = false;
            if (de1.GetNumber () == 4 && de2.GetNumber () == 2 && de3.GetNumber () == 1)
            {
                double divpoints = score / 10;
                this.score = (9 / divpoints);
                Console.Clear ();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine ("_________o$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$o\n"+
"________o$$$$$$$$$_$$$$$$$$$$$$$$$$$_$$$$$$$$$$$o\n"+
"_______o$$$$$$$$$____$$$$$$$$$$$$$____$$$$$$$$$$o\n"+
"_____$$$$$$$$$$$______$$$$$$$$$$$______$$$$$$$$$$$$$\n"+
"____$$$$$$$$$$$$$____$$$$$$$$$$$$$____$$$$$$$$$$$$$$\n"+
"___$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$\n"+
"__$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$\n"+
"__$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$\n"+
"___$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$\"_\"$$$$$\n"+
"___$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$___o$$$$\n"+
"___$$$___$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$_____$$$$$\n"+
"____$$____\"$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$\"______o$$$\n"+
"_____\"$$$o_____\"\"\"$$$$$$$$$$$$$$$$$$\"$$\"_________$$$\n"+
"_______$$$o__________\"$$\"\"$$$$$$\"\"\"\"___________o$$$\n"+
"_______$$$$o________________________________o$$$\"\n"+
"________\"$$$$o_____o$$$$$$o\"$$$$o________o$$$$\n"+
"_________-\"$$$$$oo_____\"\"$$$$o$$$$$o___o$$$$\"\"\n"+
"____________\"\"$$$$$oooo__\"$$$o$$$$$$$$$\"\"\"\n"+
"_______________\"\"$$$$$$$oo $$$$$$$$$$\n"+
"__________________________$$$$$$$$$$$\n"+
"__________________________$$$$$$$$$$$\n"+
"__________________________\"$$$$$$$$$$\"\n"+
"___________________________\"$$$$$$$$\"\n"+
                    "Félicitations vous avez réussi à faire 421, votre score est de: " + score);
                Console.ForegroundColor = ConsoleColor.White;
                gameOver = true;
            }
            if (score <= 0)
            {
                Console.Clear ();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine ("´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´\n"+
"´´´´´´´´´´´´´´´´´´´´´$$$$$$$$$$$$$$$$$´´´´´´´´´´´´´´´´´´´´´\n"+
"´´´´´´´´´´´´´´´´´$$$$$´´´´´´´´´´´´´$$$$$$$$´´´´´´´´´´´´´´´´\n"+
"´´´´´´´´´´´´´´$$$$´´´´´´´´´´´´´´´´´´´´´´´$$$$´´´´´´´´´´´´´´\n"+
"´´´´´´´´´´´´´$$$´´´´´´´´´´´´´´´´´´´´´´´´´´´$$$´´´´´´´´´´´´´\n"+
"´´´´´´´´´´´´$$´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´$$´´´´´´´´´´´´\n" +
"´´´´´´´´´´´$$´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´$$´´´´´´´´´´´\n" +
"´´´´´´´´´´$$´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´$$´´´´´´´´´´\n" +
"´´´´´´´´´´$$´$$$´´´´´´´´´´´´´´´´´´´´´´´´´´´´$$´$$´´´´´´´´´´\n" +
"´´´´´´´´´´$$´$$´´´´´´´´´´´´´´´´´´´´´´´´´´´´´$$´´$´´´´´´´´´´\n" +
"´´´´´´´´´´$$´$$´´´´´´´´´´´´´´´´´´´´´´´´´´´´´$$´´$´´´´´´´´´´\n" +
"´´´´´´´´´´$$´´$$´´´´´´´´´´´´´´´´´´´´´´´´´´´´$$´´$´´´´´´´´´´\n" +
"´´´´´´´´´´$$´´$$´´´´´´´´´´´´´´´´´´´´´´´´´´´$$´´$$´´´´´´´´´´\n" +
"´´´´´´´´´´´$$´$$´´´$$$$$$$$´´´´´´$$$$$$$´´´$$´$$´´´´´´´´´´´\n" +
"´´´´´´´´´´´´$$$$´$$$$$$$$$$´´´´´$$$$$$$$$$´$$$$$´´´´´´´´´´´\n" +
"´´´´´´´´´´´´´$$$´$$$$$$$$$$´´´´´$$$$$$$$$$´$$$´´´´´´´´´´´´´\n" +
"´´´´$$$´´´´´´´$$´´$$$$$$$$´´´´´´´$$$$$$$$$´´$$´´´´´´$$$$´´´\n" +
"´´´$$$$$´´´´´$$´´´$$$$$$$´´´$´$´´´$$$$$$$´´´$$´´´´´$$$$$$´´\n" +
"´´$$´´´$$´´´´$$´´´´´$$$´´´´$$$$$´´´´$$$´´´´´$$´´´´$$´´´$$´´\n" +
"´$$$´´´´$$$$´´$$´´´´´´´´´´$$$´$$$´´´´´´´´´´$$´´$$$$´´´´$$$´\n" +
"$$$´´´´´´´´´$$$$$$$´´´´´´´$$$´$$$´´´´´´´$$$$$$$$$´´´´´´´´$$\n" +
"$$$$$$$$$´´´´´$$$$$$$$´´´´$$$´$$$´´´´$$$$$$$$´´´´´´$$$$$$$$\n" +
"´´$$$$´$$$$$´´´´´´$$$$$´´´´´´´´´´´´´´$$$´$$´´´´´$$$$$$´$$$´\n" +
"´´´´´´´´´´$$$$$$´´$$$´$$´´´´´´´´´´´$$´$$$´´$$$$$$´´´´´´´´´´\n" +
"´´´´´´´´´´´´´´$$$$$$´$´´$$$$$$$$$$$´$$´$$$$$$´´´´´´´´´´´´´´\n" +
"´´´´´´´´´´´´´´´´´´$$´$´$$´$$´$´$$$$$$$´$$´´´´´´´´´´´´´´´´´´\n" +
"´´´´´´´´´´´´´´´´$$$$´$$´$´$$´$´$$´$´$$´$$$$$´´´´´´´´´´´´´´´\n" +
"´´´´´´´´´´´´$$$$$´$$´´´$$$$$$$$$$$$$´´´$$´$$$$$´´´´´´´´´´´´\n" +
"´´´´$$$$$$$$$$´´´´´$$´´´´´´´´´´´´´´´´´$$´´´´´´´$$$$$$$´´´´´\n" +
"´´$$$$$$´´´´´´´´$$$$$$$´´´´´´´´´´´´$$$$´´´´´´´´´´$$$$$$$´´´\n" +
"´´´$$$$$´´´´´´´$$$$$$´´´´´´´´´´´´´´´´$$$´´´´´´´$$$$$$$´´´´´\n" +
"´´´´´´´$$$$´´$$$$$´´´´´´´´´´´´´´´´´´´´´$$$´´´´$$$$$´´´´´´´´ \n"+
                    "Le nombre de tentatives restantes est écoulé");
                Console.ForegroundColor = ConsoleColor.White;
                gameOver = true;
            }
            return gameOver;
        }
        #endregion
    }
}
