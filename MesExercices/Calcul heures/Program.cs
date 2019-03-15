using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        #region Fonction conversion en secondes
        static int ConvSec (int jour, int hr, int min, int sec)
        {
            int i;
            int compt = 0;
            for(i=jour; i > 0; i--)//conversion jour en secondes
            {
                compt += 86400;
            }
            for(i = hr; i > 0; i--)//conversion heures en secondes
            {
                compt += 3600;
            }
            for(i = min; i > 0; i--)//conversion minutes en secondes
            {
                compt += 60;
            }
            compt += sec;//ajout des secondes restantes
            return compt;
        }
        #endregion
        #region Procédure calcul secondes en temps
        static void CalculEnHrs (int value, ref int jour, ref int hrs, ref int min, ref int sec)
        {
            int i;
            for (i = value; i >= 86400; i -= 86400)//Conversion secondes en jours
            {
                jour++;
            }
            value = i;
            for (i=value; i>= 3600; i-=3600)//Conversion secondes en heures
            {
                hrs++;
            }
            value = i;
            for (i=value; i>=60; i-=60)//conversion secondes en minutes
            {
                min++;
            }
            sec = i;
        }
        #endregion
        static void Main(string[] args)
        {
            bool ok;
            Console.WriteLine("Je vais faire un calcul horraire");
            ConsoleKeyInfo recommencer;
            do//boucle du temps si l'utilisateur veut faire plusieurs calculs
            {
                int day = 0;//on met les compteur à 0 (dans le cas de plusieurs calculs)
                int hors = 0;
                int minutes = 0;
                int secondes = 0;
                string saisie;//saisie utilisateur à Parse
                #region Première valeur jour
                Console.WriteLine("Il y a il un ou des jour(s) dans le calcul ?");
                if (Console.ReadKey().Key == ConsoleKey.O)//Calcul des jours de bases si il y a, l'utilisateur le dit.
                {
                    do
                    {
                        Console.WriteLine("\nCombien de jour ?");
                        saisie = Console.ReadLine();
                        ok = int.TryParse(saisie, out day);
                        if (!ok)
                        {
                            Console.WriteLine("Indique moi une valeur en chiffre, je ne suis pas madame soleil !");
                        }
                    }
                    while (!ok);
                }
                else
                {
                    day = 0;
                }
                #endregion
                #region Première valeur heures
                do
                {
                    Console.WriteLine("Combien d'heure(s)");//heures de bases
                    saisie = Console.ReadLine();
                    ok = int.TryParse(saisie, out hors);
                    if (!ok)
                    {
                        Console.WriteLine("Écris moi une valeur en chiffres, je ne suis pas madame soleil !");
                    }
                    if (hors <0 || hors >23)
                    {
                        Console.WriteLine("Les heures ont une valeures entre 0 et 23 !");
                        ok = false;
                    }
                }
                while (!ok);
                #endregion
                #region Première valeur minutes
                do
                {
                    Console.WriteLine("Combien de minute(s)");//Minutes de bases
                    string minBase = Console.ReadLine();
                    ok = int.TryParse(minBase, out minutes);
                    if (!ok)
                    {
                        Console.WriteLine("Écris moi une valeur en chiffres, je ne suis pas madame soleil !");
                    }
                    if (minutes < 0 || minutes > 59)
                    {
                        Console.WriteLine("Les minutess ont une valeur entre 0 et 59 !");
                        ok = false;
                    }
                }
                while (!ok);
                #endregion
                #region Première valeur secondes
                do
                {
                    Console.WriteLine("Combien de seconde(s)");// secondes de base
                    string secBase = Console.ReadLine();
                    ok = int.TryParse(secBase, out secondes);
                    if (!ok)
                    {
                        Console.WriteLine("Écris moi une valeur en chiffres, je ne suis pas madame soleil !");
                    }
                    if (secondes < 0 || secondes > 59)
                    {
                        Console.WriteLine("Les secondes ont une valeur entre 0 et 59");
                        ok = false;
                    }
                }
                while (!ok);
                #endregion
                #region Formule de calcul
                int temps = ConvSec(day, hors, minutes, secondes);//Appel à la conversion en secondes
                day = 0;//remise des compteur à 0 pour le 2ème calcul
                hors = 0;
                minutes = 0;
                secondes = 0;
                #endregion
                #region 2ème valeur jour
                Console.WriteLine("Maintenant l'autre valeur");
                Console.WriteLine("il y a il un ou des jours ?");
                if (Console.ReadKey().Key == ConsoleKey.O)
                {
                    do
                    {
                        Console.WriteLine("\nCombien ?");
                        saisie = Console.ReadLine();
                        ok = int.TryParse(saisie, out day);
                        if (!ok)
                        {
                            Console.WriteLine("Indique moi une valeur en chiffre, je ne suis pas madame soleil !");
                        }
                    }
                    while (!ok);

                }
                #endregion
                #region 2ème valeur heures
                do
                {
                    Console.WriteLine("Combien d'heure(s)");
                    saisie = Console.ReadLine();
                    ok = int.TryParse(saisie, out hors);
                    if (!ok)
                    {
                        Console.WriteLine("Écris moi une valeur en chiffres, je ne suis pas madame soleil !");
                    }
                    if (hors < 0 || hors > 24)
                    {
                        Console.WriteLine("Les heures ont une valeur entre 0 et 23 !");
                        ok = false;
                    }
                }
                while (!ok);
                #endregion
                #region 2ème valeur minutes
                do
                {
                    Console.WriteLine("Combien de minute(s)");
                    saisie = Console.ReadLine();
                    ok = int.TryParse(saisie, out minutes);
                    if (!ok)
                    {
                        Console.WriteLine("Écris moi une valeur en chiffres, je ne suis pas madame soleil !");
                    }
                    if (minutes < 0 || minutes > 59)
                    {
                        Console.WriteLine("Les minutes ont une valeur entre 0 et 59.");
                        ok = false;
                    }
                }
                while (!ok);
                #endregion
                #region 2ème valeur secondes
                do
                {
                    Console.WriteLine("Et combien de seconde(s)");
                    saisie = Console.ReadLine();
                    ok = int.TryParse(saisie, out secondes);
                    if (!ok)
                    {
                        Console.WriteLine("Écris moi une valeur en chiffres, je ne suis pas madame soleil !");
                    }
                    if (secondes < 0 || secondes > 59)
                    {
                        Console.WriteLine("Les secondes ont une valeur entre 0 et 59");
                        ok = false;
                    }
                }
                while (!ok);
                #endregion
                #region calcul
                int temps2 = ConvSec(day, hors, minutes, secondes);//Appel à la conversion en secondes de la 2ème partie de l'opération
                int total = 0;
                do
                {
                    ok = true;
                    Console.WriteLine("On fait une Addition (touche +) ou une soustraction (touche -) de ces 2 valeurs ?");//demande l'opération du temps
                    string operation = Console.ReadLine();
                    if (operation == "+" || operation == "-")//L'utilisateur a choisis la bonne formule
                    {
                        if (operation == "-")//Calcul si soustraction
                        {
                            if (temps >= temps2)//Vérifie si la soustraction est possible
                            {
                                total = temps - temps2;
                            }
                            else //L'utilisateur c'est trompé de sens on inverse.
                            {
                                Console.WriteLine("Je vois que vous vous êtes tromper dans le sens de la soustraction je corrige cela");
                                total = temps2 - temps;
                            }
                        }
                        else
                        {
                            total = temps + temps2;
                        }
                    }
                    else//L'utilisateur c'est trompé ou a écris n'importe quoi
                    {
                        Console.WriteLine("Indique moi le symbole de l'opération à réaliser (+ ou -), je ne suis pas madame soleil !");
                        ok = false;
                    }
                }
                while (!ok);

                Console.WriteLine("Je vais maintenant calculer tout ça!");
                
                day = 0;//On remet à 0 pour afficher le total des 2
                hors = 0;
                minutes = 0;
                secondes = 0;
                CalculEnHrs(total, ref day, ref hors, ref minutes, ref secondes);//On appelle la Procédure.
                #endregion
                #region résultats
                //Variables écrites en español (sans accent) pour éviter les doublons
                string diaz;//Jour(s)
                string hoja;//Heure(s)
                string minutos;//Minute(s)
                string segundas;//Seconde(s)
                if (day > 1)//si il y a plus de 1 jour jour prend un "S"
                {
                    diaz = "jours";
                }
                else
                {
                    diaz = "Jour";
                }
                if (hors > 1)//Si il y a plus de 1 heure Heure prend un "s"
                {
                    hoja = "heures";
                }
                else
                {
                    hoja = "heure";
                }

                if (minutes > 1)// si il y a plus que 1 minute Minute prend un "s"
                {
                    minutos = "minutes";
                }
                else
                {
                    minutos = "minute";
                }
                if (secondes > 1)//Si il y a plus que 1 seconde seconde prend un "s"
                {
                    segundas = "secondes";
                }
                else
                {
                    segundas = "seconde";
                }
                //Affichage : 0 Numéro jour. 1 Écriture du jour. 2 Numéro heure. 3 Écriture heure. 4Numéro minute. 5 Écriture minute. 6 Numéro secondes. 7 Écriture secondes.
                Console.WriteLine("Le résultat est de {0} {1}, {2} {3}, {4} {5} et {6} {7}.", day, diaz, hors, hoja, minutes, minutos, secondes, segundas);//résultat sur une seul ligne avec la bonne orthographe (singulier et pluriels respecter)
                #endregion
                Console.WriteLine("Voulez-vous faire un nouveau calcul ?");
                recommencer = Console.ReadKey();
            }
            while (recommencer.Key == ConsoleKey.Y || recommencer.Key == ConsoleKey.O);//Revenir à la boucle du temps
            Console.WriteLine("\nAu revoir");
            Console.ReadLine();
        }
    }
}
