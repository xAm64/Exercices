using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pack_de_bouteilles
{
    class Program
    {
        #region Parseur
        static bool Parseur (string saisie, ref int nombre)
        {
            bool ok = int.TryParse(saisie, out nombre);
            if (!ok)
            {
                Console.WriteLine("Écrit moi des chiffres, je ne suis pas madame soleil");
                nombre = 0;
            }
            return ok;
        }
        #endregion

        static void Main(string[] args)
        {
            Pack2Bouteilles pack = new Pack2Bouteilles();
            Bouteille eau = new Bouteille();
            bool sortir = false, finBouteille;
            bool ok;
            int nombre, numberBout = 0;
            string depasse = "La valeur saisie dépasse la capacitée de la bouteille";
            Emballage emballage = Emballage.carton;
            Console.WriteLine(pack);
            #region Choix de l'emballage
            do
            {
                ok = true;
                Console.WriteLine("Choississez l'embalage\n(P)lastique (C)arton (F)ilet");
                ConsoleKey s = Console.ReadKey().Key;
                if (s == ConsoleKey.P || s == ConsoleKey.C || s == ConsoleKey.F)
                {
                    if (s == ConsoleKey.P)
                    {
                        emballage = Emballage.plastique;
                    }
                    if (s == ConsoleKey.C)
                    {
                        emballage = Emballage.carton;
                    }
                    if (s == ConsoleKey.F)
                    {
                        emballage = Emballage.filet;
                    }
                }
                else
                {
                    Console.WriteLine("Vous n'avez pas appuyer sur la bonne touche");
                    ok = false;
                }
            }
            while (!ok);
            #endregion

            do
            {
                Console.WriteLine("L'embalage en "+emballage.ToString()+" est ouvert");
                Console.WriteLine("Que voulez-vous faire\najouter ? retirer interagir ? sortir?");
                string saisie = Console.ReadLine();
                #region Commandes
                if (saisie == "ajouter" || saisie == "retirer" || saisie == "interagir" || saisie == "sortir")
                {
                    #region Ajouter
                    if (saisie == "ajouter")
                    {
                        do
                        {
                            nombre = 0;
                            Console.WriteLine("Combien on ajoute ?");
                            saisie = Console.ReadLine();
                            ok = Parseur(saisie, ref nombre);
                            pack.Ajouter(nombre);
                        }
                        while (!ok);
                    }
                    #endregion

                    #region Retirer
                    if (saisie == "retirer")
                    {
                        do
                        {
                            nombre = 0;
                            Console.WriteLine("Combien en retire ?");
                            saisie = Console.ReadLine();
                            ok = Parseur(saisie, ref nombre);
                            pack.Retirer(nombre);
                            numberBout += nombre;
                        }
                        while (!ok);
                    }
                    #endregion

                    #region Interaction avec une bouteille
                    if (saisie == "interagir")
                    {
                        if (numberBout == 0)
                        {
                            Console.WriteLine("Vous n'avez pas de bouteille avec lesqueles interagir");
                        }
                        else
                        {
                            Console.WriteLine(eau);
                            finBouteille = false;
                            do
                            {
                                Console.WriteLine(eau);
                                Console.WriteLine("Que voules-vous faire ?\nouvrir ? fermer ? remplir ? vider ? jeter ?");
                                saisie = Console.ReadLine();
                                if (saisie == "ouvrir" || saisie == "fermer" || saisie == "remplir" || saisie == "vider" || saisie == "jeter")
                                {
                                    #region Ouvrir
                                    if (saisie == "ouvrir")
                                    {
                                        eau.Ouvrir();
                                    }
                                    #endregion

                                    #region Fermer
                                    if (saisie == "fermer")
                                    {
                                        eau.Fermer();
                                    }
                                    #endregion

                                    #region Remplir
                                    if (saisie == "remplir")
                                    {
                                        do
                                        {
                                            ok = true;
                                            nombre = 0;
                                            Console.WriteLine("De combien de % on remplie");
                                            saisie = Console.ReadLine();
                                            ok = Parseur(saisie, ref nombre);
                                            if (nombre <1 || nombre >100)
                                            {
                                                Console.WriteLine(depasse);
                                                ok = false;
                                            }
                                            else
                                            {
                                                eau.Remplir(nombre);
                                            }
                                        }
                                        while (!ok);
                                    }
                                    #endregion

                                    #region Vider
                                    if (saisie == "vider")
                                    {
                                        do
                                        {
                                            ok = true;
                                            nombre = 0;
                                            Console.WriteLine("De combien de % on vide");
                                            saisie = Console.ReadLine();
                                            ok = Parseur(saisie, ref nombre);
                                            if (nombre < 1 || nombre > 100)
                                            {
                                                Console.WriteLine(depasse);
                                                ok = false;
                                            }
                                            else
                                            {
                                                eau.Vider(nombre);
                                            }
                                        }
                                        while (!ok);
                                    }
                                    #endregion

                                    #region Jeter
                                    if (saisie == "jeter")
                                    {
                                        finBouteille = true;
                                        numberBout--;
                                    }
                                    #endregion
                                }
                                else
                                {
                                    Console.WriteLine("Vous avez écrit n'importe quoi");
                                }
                            }
                            while (finBouteille == false);
                            
                        }
                    }
                    #endregion

                    #region sortir
                    if (saisie == "sortir")
                    {
                        sortir = true;
                    }
                    #endregion
                }
                
                else
                {
                    Console.WriteLine("Vous avez écrit n'importe quoi !");
                }
                #endregion
                Console.WriteLine(pack);
            }
            while (sortir == false);
            Console.WriteLine("Au revoir");
            Console.ReadLine();
        }
    }
}
//if (saisie == "ajouter" || saisie == "retirer" || saisie == "ouvrir" || saisie == "fermer" || saisie == "vider" || saisie == "remplir" || saisie == "sortir")
//{
//    #region Ajouter
//    if (saisie == "ajouter")
//    {
//        do
//        {
//            nombre = 0;
//            Console.WriteLine("Combien on ajoute ?");
//            saisie = Console.ReadLine();
//            ok = int.TryParse(saisie, out nombre);
//            pack.Ajouter(nombre);
//        }
//        while (!ok);
//    }
//    #endregion
//    #region Retirer
//    if (saisie == "retirer")
//    {
//        do
//        {
//            nombre = 0;
//            Console.WriteLine("Combien en retire ?");
//            saisie = Console.ReadLine();
//            ok = int.TryParse(saisie, out nombre);
//            pack.Retirer(nombre);
//        }
//        while (!ok);
//    }
//    #endregion
//    #region Ouvrir
//    if (saisie == "ouvrir")
//    {
//        eau.Ouvrir();
//    }
//    #endregion
//    #region Fermer
//    if (saisie == "fermer")
//    {
//        eau.Fermer();
//    }
//    #endregion
//    #region Vider
//    if (saisie == "vider")
//    {
//        do
//        {
//            ok = true;
//            Console.WriteLine("De combien de % on vide ?");
//            saisie = Console.ReadLine();
//            ok = int.TryParse(saisie, out nombre);
//            if (nombre <= 0 || nombre >100)
//            {
//                Console.WriteLine("La valeur saisie dépasse la capacitée de la bouteille");
//                ok = false;
//            }
//        }
//        while(!ok) ;
//        eau.Vider(nombre);
//    }
//    #endregion
//    #region Remplir
//    if (saisie == "remplir")
//    {
//        do
//        {
//            Console.WriteLine("De combien de % on remplit ?");
//            saisie = Console.ReadLine();
//            ok = int.TryParse(saisie, out nombre);
//            if (nombre <= 0 || nombre >100)
//            {
//                Console.WriteLine("La valeur saisie dépasse la capacitée de la bouteille");
//                ok = false;
//            }
//        }
//        while (!ok);
//        eau.Remplir(nombre);
//    }
//    #endregion
//    #region Sortie
//    if (saisie == "sortir")
//    {
//        sortir = true;
//    }
//    #endregion
//}
