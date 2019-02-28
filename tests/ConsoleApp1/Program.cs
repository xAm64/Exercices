using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int Jour;
        static int Hr1;
        static int Min1;
        static int sec1;

        static void Main(string[] args)
        {
            bool ok;
            int Base = 0;
            Console.WriteLine("Je vais faire un calcul horraire");
            ConsoleKeyInfo recommencer;
            do
            {
                do
                {
                    Console.WriteLine("Commençons par le nombre d'heure(s)");//heures de bases
                    string hrsBase = Console.ReadLine();
                    ok = int.TryParse(hrsBase, out Hr1);
                    if (!ok)
                    {
                        Console.WriteLine("Une erreur est détecter j'attends une valeur avec que des chiffres !");
                    }
                }
                while (!ok);
                do
                {
                    Console.WriteLine("Et maintenant: le nombre de minute(s)");//Minutes de bases
                    string minBase = Console.ReadLine();
                    ok = int.TryParse(minBase, out Min1);
                    if (!ok)
                    {
                        Console.WriteLine("Une erreur est détecter j'attends une valeur avec que des chiffres !");
                    }
                    if (Min1 > 0 || Min1 > 59)
                    {
                        Console.WriteLine("Une erreur est détécter, les minutes sont comprises entre 0 et 59");
                    }
                }
                while (!ok || Min1 < 0 || Min1 > 59);
                do
                {
                    Console.WriteLine("Enfin le nombre de seconde(s)");// secondes de base
                    string secBase = Console.ReadLine();
                    ok = int.TryParse(secBase, out sec1);
                    if (!ok)
                    {
                        Console.WriteLine("Une erreur est détecter j'attends une valeur avec que des chiffres !");
                    }
                    if (sec1 < 0 || sec1 > 59)
                    {
                        Console.WriteLine("Une erreur à été détecter, les secondes sont entre 0 et 59");
                    }
                }
                while (!ok || sec1 < 0 || sec1 > 59);
                Console.WriteLine("Maintenant le temps a additionner");

                while (Hr1 > 0)//Calcul heures
                {
                    Base += 3600;
                    Hr1--;
                }
                while (Min1 > 0)//Calcul minutes
                {
                    Base += 60;
                    Min1--;
                }
                Base = Base + sec1;//Calcul secondes

                do
                {
                    Console.WriteLine("Maintenant le nombre d'heure(s) à ajouter");//Heures additionnels
                    string hrsBase = Console.ReadLine();
                    ok = int.TryParse(hrsBase, out Hr1);
                    if (!ok)
                    {
                        Console.WriteLine("Une erreur est détecter j'attends une valeur avec que des chiffres !");
                    }
                }
                while (!ok);
                do
                {
                    Console.WriteLine("Le nombre de minute(s) à additionner");//Minutes additionnes
                    string minBase = Console.ReadLine();
                    ok = int.TryParse(minBase, out Min1);
                    if (!ok)
                    {
                        Console.WriteLine("Une erreur est détecter j'attends une valeur avec que des chiffres !");
                    }
                    if (Min1 < 0 || Min1 > 59)
                    {
                        Console.WriteLine("Une erreur de chiffre a été détecter, les minutes ne peuvent être comprises entre 0 et 59.");
                    }
                }
                while (!ok || Min1 < 0 || Min1 > 59);
                do
                {
                    Console.WriteLine("Et pour terminer le nombre de seconde(s)");//Secondes additionnels
                    string secBase = Console.ReadLine();
                    ok = int.TryParse(secBase, out sec1);
                    if (!ok)
                    {
                        Console.WriteLine("Une erreur est détecter j'attends une valeur avec que des chiffres !");
                    }
                    if (sec1 < 0 || sec1 > 59)
                    {
                        Console.WriteLine("Une erreur a été détécter, les secondes ne peuvent sont entre 0 et 59");
                    }
                }
                while (!ok || sec1 < 0 || sec1 > 59);

                Console.WriteLine("Je vais maintenant calculer tout ça!");

                while (Hr1 > 0)//Addition heures
                {
                    Base += 3600;
                    Hr1--;
                }
                while (Min1 > 0)//Addition minutes
                {
                    Base += 60;
                    Min1--;
                }
                Base = Base + sec1;//Addition secondes
                // Calcul

                while (Base >= 86400)//Addition fina jours
                {
                    Jour++;
                    Base -= 86400;
                }
                while (Base >= 3600)//Addition final heures
                {
                    Hr1++;
                    Base -= 3600;
                }
                while (Base >= 60)//Addition final minutes
                {
                    Min1++;
                    Base -= 60;
                }
                Base = Base + sec1;//Adition final secondes
                Console.WriteLine("Le résultat total est de :");
                if (Jour > 1)
                {
                    Console.WriteLine("{0}Jours", Jour);
                }
                else
                {
                    if (Jour == 1)
                    {
                        Console.WriteLine("1Jour");
                    }
                }
                if (Hr1 > 1)
                {
                    Console.WriteLine("{0}Heures", Hr1);
                }
                else
                {
                    if (Hr1 <= 1);
                    {
                        Console.WriteLine("{0}Heure", Hr1);
                    }
                }

                if (Min1 > 1)
                {
                    Console.WriteLine("{0}Minutes", Min1);
                }
                else
                {
                    if (Min1 <= 1)
                    {
                        Console.WriteLine("{0}Minute",Min1);
                    }
                    if (Min1 == 0)
                    {

                    }
                }
                if (sec1 > 1)
                {
                    Console.WriteLine("et {0}Secondes", sec1);
                }
                else
                {
                    if (sec1 <= 1)
                    {
                        Console.WriteLine("et {0}Seconde",sec1);
                    }

                }
                Console.WriteLine("Voulez-vous faire un nouveau clacul ?");
                recommencer = Console.ReadKey();
            }
            while (recommencer.Key == ConsoleKey.Y || recommencer.Key == ConsoleKey.O);
            
            Console.ReadLine();
        }
    }
}
