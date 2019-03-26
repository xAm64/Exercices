using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reste_modulo
{
    class Program
    {
        static void Main(string[] args)
        {
            string saisie;
            int na, nb, reste;
            bool ok;
            do
            {
                Console.WriteLine("Écrire le nombre A");
                saisie = Console.ReadLine();
                ok = int.TryParse(saisie, out na);
            }
            while (!ok);
            do
            {
                Console.WriteLine("Écrire le nombre B");
                saisie = Console.ReadLine();
                ok = int.TryParse(saisie, out nb);
            }
            while (!ok);
            reste = (na + nb) % 2;
            if (reste == 0)
            {
                Console.WriteLine("Le joueur A a gagné");
            }
            else
            {
                Console.WriteLine("Le joueur B a gagné");
            }
            Console.ReadLine();
        }
    }
}
