using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fonction
{
    class Program
    {

        static double Multiplier (double _a,double _b)
        {
            double resultat;
            resultat = _a * _b;
            return resultat;
        }

        static void Main(string[] args)
        {
            bool ok;
            string chifA;
            string chifB;
            do
            {
                double _a = 0;
                ok = true;
                Console.WriteLine("Écrire le premier chiffre");
                chifA = Console.ReadLine();
                ok = double.TryParse(chifA, out _a);
                if (!ok)
                {
                    Console.WriteLine("Merci d'écrire des chiffres");
                }
            }
            while (!ok);
            do
            {
                double _b = 0;
                ok = true;
                Console.WriteLine("Écrire le multiplicateur");
                chifB = Console.ReadLine();
                ok = double.TryParse(chifB, out _b);
                if (!ok)
                {
                    Console.WriteLine("Merci d'écrire des chiffres");
                }
            }
            while (!ok);
            Console.WriteLine("{0} × {1} = {2}", chifA, chifB, resultat);

            Console.ReadLine();
        }
    }
}
