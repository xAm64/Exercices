using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    class Program
    {
        static string Calendar (int _a, int _m, int _j)
        {
            DateTime dateValue = new DateTime(_a, _m, _j);
            string day = dateValue.ToString("dddd");
            return day;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Donne moi une date et je te dirais quel jour ça tombe");
            bool restart;
            bool ok;
            int years;
            int months;
            int days;
            do
            {
                do
                {
                    
                    Console.WriteLine("Écris le numéro du jour");
                    string jour = Console.ReadLine();
                    ok = int.TryParse(jour, out days);
                    if (!ok)
                    {
                        Console.WriteLine("Écris moi une valeur en chiffres, je ne suis pas madame soleil !");
                    }
                    else
                    {
                        if (days <= 0 || days > 31)
                        {
                            Console.WriteLine("Je te demande le numéro d'un jour dans un mois, pas de jouer à madame soleil avec moi!");
                            ok = false;
                        }
                    }
                    
                }
                while (!ok);
                do
                {
                    
                    Console.WriteLine("Écris le numéro du mois");
                    string mois = Console.ReadLine();
                    ok = int.TryParse(mois, out months);
                    if (!ok)
                    {
                        Console.WriteLine("Écris moi une valeur en chiffres, je ne suis pas madame soleil !");
                    }
                    else
                    {
                        if (months <= 0 || months > 12)
                        {
                            Console.WriteLine("Je te demande le numéro d'un mois dans l'année pas de jouer à madame soleil avec moi!");
                            ok = false;
                        }
                    }
                    
                }
                while (!ok);
                do
                {
                    
                    Console.WriteLine("Et maintenant l'année");
                    string annee = Console.ReadLine();
                    ok = int.TryParse(annee, out years);
                    if (!ok)
                    {
                        Console.WriteLine("Écris moi une valeur en chiffres, je ne suis pas madame soleil !");
                    }
                }
                while (!ok);
                string jourDeLaSemaine = Calendar(years, months, days);

                Console.WriteLine("Le {0}/{1}/{2} est un {3}",days ,months, years, jourDeLaSemaine);
                Console.ReadLine();
                Console.WriteLine("Un autre essaie ?");
                restart = Console.ReadKey().Key == ConsoleKey.O;
            }
            while (restart);
            Console.WriteLine("Au revoir");
            Console.ReadLine();
        }
    }
}
