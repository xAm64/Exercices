using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_Calendrier
{
    class Program
    {
        #region Fonction Parse
        static bool Parse (string saisie, ref byte sortie)
        {
            bool ok = byte.TryParse(saisie, out sortie);
            if (!ok)
            {
                sortie = 255;
            }
            return ok;
        }
        #endregion
        #region Tableau des jours
        static string[] jour = new string[]
        {
            "samedi", "dimanche", "lundi", "mardi", "mercredi", "jeudi", "vendredi",
        };
        #endregion
        #region Calcul des mois
        static byte CalculMois(byte saisie)
        {
            byte[] tableMois = new byte[]
            {
            1,4,4,0,2,5,0,3,6,1,4,6,
            };
            saisie--;
            byte month = tableMois[saisie];
            return month;
        }
        #endregion

        static void Main(string[] args)
        {
            bool restart, ok;
            string saisie;
            byte day, refMonth, year;
            do
            {
                restart = false;
                #region Jour
                do
                {
                    day = 0;
                    Console.WriteLine("Écrire le jour");
                    saisie = Console.ReadLine();
                    ok = Parse(saisie, ref day);
                    if (!ok || (day <1 || day >31))
                    {
                        Console.WriteLine("Une erreur de saisie a été détecter, merci de recommencer");
                        ok = false;
                    }
                }
                while (!ok);
                #endregion
                #region mois
                do
                {
                    refMonth = 0;
                    Console.WriteLine("Écrire le mois");
                    saisie = Console.ReadLine();
                    ok = Parse(saisie, ref refMonth);
                    if (!ok || (refMonth <1 || refMonth > 12))
                    {
                        Console.WriteLine("Une erreur de saisie a été détecter, merci de recommencer");
                        ok = false;
                    }
                }
                while (!ok);
                byte month = CalculMois(refMonth);
                #endregion
                #region année
                do
                {
                    year = 0;
                    Console.WriteLine("Écrire l'année");
                    saisie = Console.ReadLine();
                    ok = Parse(saisie, ref year);
                    if (!ok || (year < 1 || year > 99))
                    {
                        Console.WriteLine("Une erreur de saisie a été détecter, merci de recommencer");
                        ok = false;
                    }
                }
                while (!ok);
                #endregion
                #region calcul du résultat
                int resultat4 = year/4;
                if ((year %4) == 0 && (refMonth == 1 || refMonth == 2))
                {
                    month--;
                }
                int reste7 = (year + resultat4 + month + day) % 7;
                #endregion
                Console.WriteLine("le {0}/{1}/{2} tombe un {3}",day, refMonth, year, jour[reste7]);

                Console.WriteLine("Un autre essaie ?");
                restart = Console.ReadKey().Key == ConsoleKey.O;
            }
            while (restart == true);
            Console.WriteLine("Au revoir");
            Console.ReadLine();
        }
    }
}
