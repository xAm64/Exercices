using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcul_aire_triangle
{
    class Program
    {

        static double CalculAire(double _a, double _b, double _c)
        {
            double p = _a + _b + _c;
            double aire = Math.Sqrt(p/2 * (p / 2 - _a) * (p / 2 - _b) * (p / 2 - _c));
            return aire;
        }

        static void Main(string[] args)
        {

            
            Console.WriteLine("Je vais calculer le périmètre d'un triangle");
            bool restart = false;
            bool ok;
            do
            {
                double vA;
                double vB;
                double vC;
                Console.WriteLine("Écrivez l'unité de mesure utiliser");
                string unite = Console.ReadLine();
                do
                {
                    
                    Console.WriteLine("Écrivez la valeur A");
                    string a = Console.ReadLine();
                    ok = double.TryParse(a, out vA);
                    if (!ok)
                    {
                        Console.WriteLine("Écriver une valeur en chiffres, je ne suis pas madame soleil !");
                    }
                }
                while (!ok);
                do
                {
                    
                    Console.WriteLine("Écrivez la valeur B");
                    string b = Console.ReadLine();
                    ok = double.TryParse(b, out vB);
                    if (!ok)
                    {
                        Console.WriteLine("Écriver une valeur en chiffres, je ne suis pas madame soleil !");
                    }
                }
                while (!ok);
                do
                {
                    Console.WriteLine("Écrivez la valeur C");
                    string c = Console.ReadLine();
                    ok = double.TryParse(c, out vC);
                    if (!ok)
                    {
                        Console.WriteLine("Écriver une valeur en chiffres, je ne suis pas madame soleil !");
                    }
                }
                while (!ok);
                Console.WriteLine("Très bien je vais passer au calcul");
                double aire = CalculAire(vA, vB, vC);
                Console.WriteLine("Un triangle de : {0} {1}, {2} {1} et {3} {1}.", vA, unite, vB, vC);
                Console.WriteLine("À un aire de {0} {1}²", aire, unite);
                Console.ReadLine();

                Console.WriteLine("Un autre calcul ?");
                restart = Console.ReadKey().Key == ConsoleKey.O;
            }
            while (restart);


            Console.ReadLine();
        }

    }
}
