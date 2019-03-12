using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcul_Moyenne_2nbrs
{
    class Program
    {
        static double Moyenne (int a, int b)
        {
            double moy = (a + b) / 2;
            return moy;
        }

        static void Main(string[] args)
        {
            int nA;
            int nB;
            bool ok;
            bool restart;
            Console.WriteLine("Donne moi 2 chiffres et je vais calculer leur moyenne");
            do
            {
                do
                {
                    Console.WriteLine("Écris le premier chiffre");
                    string _a = Console.ReadLine();
                    ok = int.TryParse(_a, out nA);
                    if (!ok)
                    {
                        Console.WriteLine("Écris moi une valeur en chiffre, je ne suis pas madame soleil !");
                    }
                }
                while (!ok);
                do
                {
                    Console.WriteLine("Écris le 2ème chiffre");
                    string _b = Console.ReadLine();
                    ok = int.TryParse(_b, out nB);
                    if (!ok)
                    {
                        Console.WriteLine("Écris moi une valeur en chiffre, je ne suis pas madama soleil ");
                    }
                }
                while (!ok);

                Console.WriteLine("C'est partie pour le calcul");
                double moy = Moyenne(nA, nB);
                Console.WriteLine("La moyenne de {0} et {1} est de: {2}", nA, nB, moy);
                Console.ReadLine();
                Console.WriteLine("Un autre essaie ?");
                restart = Console.ReadKey().Key == ConsoleKey.O;
            }
            while (restart);
            Console.WriteLine("au revoir");
            Console.ReadLine();
        }
    }
}
