using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcul_aire_cercle
{
    class Program
    {

        static double CalculAire (double _ray, double _an)
        {
            double aire = Math.PI * (_ray * _ray) * _an / 360;
            return aire;
        }

        static void Main(string[] args)
        {
            double aire;
            double Ray;
            double an;
            ConsoleKeyInfo recommencer;
            bool ok;
            do
            {
                Console.WriteLine("Je vais calculer l'aire d'un cercle, pour commencer quel utités utilisons nous ?");
                string unit = Console.ReadLine();
                do
                {

                    Console.WriteLine("Quel est le rayon du cercle ?");
                    string rayon = Console.ReadLine();
                    ok = double.TryParse(rayon, out Ray);
                }
                while (!ok);
                do
                {
                    do
                    {

                        Console.WriteLine("quel est son angle ?");
                        string angle = Console.ReadLine();
                        ok = double.TryParse(angle, out an);
                        if(an >360)
                        {
                            Console.WriteLine("Une erreur à été détecter, un cercle ne peux pas faire plus de 360°");
                        }

                    }
                    while (an > 360);
                }
                while (!ok);

                Console.WriteLine("Un instant je calcule tout ça...");
                aire = CalculAire(Ray, an);
                Console.WriteLine("L'aire du secteur du cercle est de: {0}{1}²", aire, unit);
                Console.WriteLine("Voulez vous faire un autre calcul ?");
                recommencer = Console.ReadKey();
                
            }
            while (recommencer.Key == ConsoleKey.Y || recommencer.Key == ConsoleKey.O);
            Console.WriteLine("À bientôt");
            Console.ReadLine();
        }
    }
}
