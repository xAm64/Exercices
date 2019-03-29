using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projets_perso
{
    class Program
    {
        #region Tirage
        static void Tirage(ref int ent)
        {
            Random rand = new Random();
            ent = rand.Next(1, 49);
        }
        #endregion
        #region Tirage comp
        static void Complementaire(ref int ent)
        {
            Random rand = new Random();
            ent = rand.Next(1, 10);
        }
        #endregion
        #region Parse
        static bool Parseur(string saisie, ref int numero)
        {
            bool ok;
            do
            {
                ok = true;
                ok = int.TryParse(saisie, out numero);
                if (numero < 1 || numero > 49)
                {
                    Console.WriteLine("Vous voulez vraiment perdre, si vous choisissez un numéro qui n'existe pas vous ne pouvez pas gagner");
                    ok = false;
                }
                if (!ok)
                {
                    numero = 255;
                    Console.WriteLine("Écrit moi un chiffre, je ne suis pas madame soleil");
                }
                return ok;
            }
            while (!ok);
        }
        #endregion

        static void Main(string[] args)
        {
            bool restart, ok, refaire;
            string saisie;
            int n1, n2, n3, n4, n5, nc;
            do
            {
                restart = false;
                refaire = false;
                Console.WriteLine("Jouons au loto ensemble");
                Console.WriteLine("Rappel des règles : le joueur choisis 5 numéros (entre 1 à 49) et un numéro chance (entre 1 et 10), je tire les numéro et on verra si vous avez de la chance\nRappel important l'argent de ce programme est virtuel");
                #region Le jour choisit les 5 numéros
                do
                {
                    #region Saisie Numero 1
                    do
                    {
                        ok = true;
                        n1 = 0;
                        Console.WriteLine("Commençons par le premier numéro");
                        saisie = Console.ReadLine();
                        ok = Parseur(saisie, ref n1);
                    }
                    while (!ok);
                    #endregion
                    #region Saisie numero 2
                    do
                    {
                        ok = true;
                        n2 = 0;
                        Console.WriteLine("Le 2ème numéro");
                        saisie = Console.ReadLine();
                        ok = Parseur(saisie, ref n2);
                        if (n2 == n1)
                        {
                            Console.WriteLine("Vous ne pouvez pas mettre 2fois le même numéro");
                            ok = false;
                        }
                    }
                    while (!ok);
                    #endregion
                    #region Saisie numero 3
                    do
                    {
                        ok = true;
                        n3 = 0;
                        Console.WriteLine("Le 3ème numéro");
                        saisie = Console.ReadLine();
                        ok = Parseur(saisie, ref n3);
                        if (n3 == n1 || n3 == n2)
                        {
                            Console.WriteLine("Vous ne pouvez pas mettre 2 fois le même numéro");
                            ok = false;
                        }
                    }
                    while (!ok);
                    #endregion
                    #region Saisie numero 4
                    do
                    {
                        ok = true;
                        n4 = 0;
                        Console.WriteLine("Le 4ème numéro");
                        saisie = Console.ReadLine();
                        ok = Parseur(saisie, ref n4);
                        if (n4 == n1 || n4 == n2 || n4 == n3)
                        {
                            Console.WriteLine("Vous ne pouvez pas jouer 2 fois le même numéro");
                            ok = false;
                        }

                    }
                    while (!ok);
                    #endregion
                    #region Saisie numéro 5
                    do
                    {
                        ok = true;
                        n5 = 0;
                        Console.WriteLine("enfin le 5ème numéro");
                        saisie = Console.ReadLine();
                        ok = Parseur(saisie, ref n5);
                        if (n5 == n1 || n5 == n2 || n5 == n3 || n5 == n4)
                        {
                            Console.WriteLine("Vous ne pouvez pas choisir 2 fois le même numéro");
                            ok = false;
                        }
                    }
                    while (!ok);
                    #endregion
                    #endregion
                    #region Numéro chance
                    do
                    {
                        ok = true;
                        nc = 0;
                        Console.WriteLine("Maintenant choisissez le numéro chance");
                        saisie = Console.ReadLine();
                        ok = int.TryParse(saisie, out nc);
                        if (nc < 1 || nc > 10)
                        {
                            Console.WriteLine("Vous voulez vraiment perdre, si vous écrivez un numéro qui n'existe pas vous ne pouvez pas gagner");
                            ok = false;
                        }
                        if (!ok)
                        {
                            Console.WriteLine("Écrit moi un chiffre, je ne suis pas madame soleil");
                        }
                    }
                    while (!ok);
                    #endregion
                    Console.WriteLine("Vous avez choisis les chiffres suivants {0}, {1}, {2}, {3}, {4} et en numéro chance {5}\nValidez vous ce choix ?", n1, n2, n3, n4, n5, nc);
                    refaire = Console.ReadKey().Key == ConsoleKey.N;
                }
                while (refaire == true);
                #region tirage
                Console.WriteLine("Très bien maintenant, je vérouille vos chiffres et procède au tirage, c'est parti !");
                int t1, t2, t3, t4, t5, tc;
                #region Tirage num1
                t1 = 0;
                Tirage(ref t1);
                Console.WriteLine("Le premier numéro est : {0}", t1);
                #endregion
                #region Tirage num 2
                t2 = 0;
                do
                {
                    ok = true;
                    Tirage(ref t2);
                    if (t2 == t1)
                    {
                        ok = false;
                    }
                    else
                    {
                        Console.WriteLine("Le 2ème numéro est: {0}", t2);
                    }
                }
                while (!ok);
                #endregion
                #region Tirage num 3;
                t3 = 0;
                do
                {
                    ok = true;
                    Tirage(ref t3);
                    if (t3 == t1 || t3 == t2)
                    {
                        ok = false;
                    }
                    else
                    {
                        Console.WriteLine("Le 3ème numéro est: {0}", t3);
                    }
                }
                while (!ok);
                #endregion
                #region Tirage num 4;
                t4 = 0;
                do
                {
                    ok = true;
                    Tirage(ref t4);
                    if (t4 == t1 || t4 == t2 || t4 == t3)
                    {
                        ok = false;
                    }
                    else
                    {
                        Console.WriteLine("Le 4ème numéro est: {0}", t4);
                    }
                }
                while (!ok);
                #endregion
                #region Tirage num 5;
                t5 = 0;
                do
                {
                    ok = true;
                    Tirage(ref t5);
                    if (t5 == t1 || t5 == t2 || t5 == t3 || t5 == t4)
                    {
                        ok = false;
                    }
                    else
                    {
                        Console.WriteLine("Le 5ème numéro est: {0}", t5);
                    }
                }
                while (!ok);
                #endregion
                #region Tirage num chance
                tc = 0;
                Complementaire(ref tc);
                Console.WriteLine("Le numéro chance est: {0}", tc);
                #endregion
                #endregion
                #region gains
                byte nbNum = 0;
                bool nCHance = false;
                Console.WriteLine("Voici les numéros tirés: {0}, {1}, {2}, {3}, {4}, et le numéro chance {5}\nVous avez joué: {6}, {7}, {8}, {9}, {10} et le numéro chance {11}", t1, t2, t3, t4, t5, tc, n1, n2, n3, n4, n5, nc);
                if (n1 == t1 || n1 == t2 || n1 == t3 || n1 == t4 || n1 == t5)
                {
                    nbNum++;
                }
                if (n2 == t1 || n2 == t2 || n2 == t3 || n2 == t4 || n2 == t5)
                {
                    nbNum++;
                }
                if (n3 == t1 || n2 == t2 || n3 == t3 || n3 == t4 || n3 == t5)
                {
                    nbNum++;
                }
                if (n4 == t1 || n4 == t2 || n4 == t3 || n4 == t4 || n4 == t5)
                {
                    nbNum++;
                }
                if (n5 == t1 || n5 == t2 || n5 == t3 || n5 == t4 || n5 == t5)
                {
                    nbNum++;
                }
                if (nc == tc)
                {
                    nCHance = true;
                }
                int gain = 0;
                if (nCHance == true)
                {
                    gain += 5;
                }
                if (nbNum == 3)
                {
                    if (nCHance == true)
                    {
                        gain += 500;
                    }
                    else
                    {
                        gain += 100;
                    }
                }
                if (nbNum == 4)
                {
                    if (nCHance == true)
                    {
                        gain += 3000;
                    }
                    else
                    {
                        gain += 1000;
                    }
                }
                if (nbNum == 5)
                {
                    if (nCHance == true)
                    {
                        gain += 5000000;
                    }
                    else
                    {
                        gain += 1000000;
                    }
                }
                #endregion
                #region Affichage du gain
                if (nbNum <= 1)
                {
                    if (nCHance == true)
                    {
                        Console.WriteLine("Vous avez trouvé {0} bon numéro, mais vous avez trouvé le numéro chance: {1}. Vous gagnez {2} Euros",nbNum, tc, gain);
                    }
                    else
                    {
                        Console.WriteLine("Vous n'avez pas trouvé assez de numéros, vous gagner {0} Euro", gain);
                    }
                }
                else
                {
                    if (nCHance == true)
                    {
                        Console.WriteLine("Vous avez troués: {0} numéros et le numéro chance, vous avez gagné {1} Euros", nbNum, gain);
                    }
                    else
                    {
                        Console.WriteLine("Vous avez troués: {0} numéros, vous avez gagnés {1} Euros", nbNum, gain);
                    }
                }
                #endregion
                Console.WriteLine("Un nouvel essaie ?");
                restart = Console.ReadKey().Key == ConsoleKey.O;
            }
            while (restart == true);
            Console.WriteLine("\nAu revoir");
            Console.ReadLine();
        }
    }
}
