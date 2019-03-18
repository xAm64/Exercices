using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Année_bissextile
{
    class Program
    {
        #region Formule de calcul
        static bool Bissextile (int _a)
        {
            bool sortie;
            if (_a %4 == 0)
            {
                if (_a %100 == 0 && _a %400 != 0)
                {
                    sortie = false;
                }
                else
                {
                    sortie = true;
                }
            }
            else
            {
                sortie = false;
            }
            return sortie;
        }
        #endregion

        static void Main(string[] args)
        {
            
            bool ok;
            bool reset;
            int year;
            bool Bixt;

            do
            {
                #region Partie text
                do
                {
                    Console.WriteLine("Entrer une année");
                    string annee = Console.ReadLine();
                    ok = int.TryParse(annee, out year);
                    if (!ok)
                    {
                        Console.WriteLine("Donne moi des chiffres, je ne suis pas madame soleil !");
                    }
                }
                while (!ok);
                Bixt = Bissextile(year);
                if (Bixt)
                {
                    Console.WriteLine("L'année {0} est bissextile !",year);
                }
                else
                {
                    Console.WriteLine("L'année {0} n'est pas bissextile", year);
                }
                Console.WriteLine("Un autre essaie ?");
                reset = Console.ReadKey().Key == ConsoleKey.O;
                #endregion
            }
            while (reset);
            Console.WriteLine("Au revoir");
            Console.ReadLine();
            
        }
    }
}
