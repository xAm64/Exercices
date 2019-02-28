using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcul_d_un_cercle
{
    class Program
    {
        static readonly float pi = 3.1415926535898f;
        static float circonf;
        static double surface;

        static void Main(string[] args)
        {
            Console.WriteLine("Quel est le rayon du cercle ?");
            string rayon = Console.ReadLine();
            int ray = int.Parse(rayon);
            circonf = (2 * pi * ray);
            surface = pi * Math.Pow(ray,2);
            Console.WriteLine("Quel unité de mesure utilisont nous ?");
            string unite = Console.ReadLine();
            Console.WriteLine("Le rayon du cercle est: " + rayon + unite);
            Console.WriteLine("La circonférence du cercle est: " + circonf + unite);
            Console.WriteLine("La surface du cercle est: " + surface + unite + "²");
            Console.ReadLine();
        }
    }
}
