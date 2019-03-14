using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcul_inclinaison_solaire
{
    class Program
    {
        static readonly double angle = 23.27f;
        static double june;
        static double december;
        static double latCalc;
        static double lat;

        static void Main(string[] args)
        {
            bool ok;
            ConsoleKeyInfo recommencer;
            do
            {
                do
                {
                    do
                    {
                        Console.WriteLine("Quelle latitude dois-je calculer ?");
                        string latitude = Console.ReadLine();
                        ok = double.TryParse(latitude, out lat);
                        if(lat<-90 || lat >90)
                        {
                            Console.WriteLine("La latitude de la terre est comprise entre 90° pour le pôle nord et -90° pour le pôle sud");
                        }
                        if(!ok)
                        {
                            Console.WriteLine("Indique moi une valeur en chiffres, je ne suis pas madame soleil");
                        }
                    }
                    while (lat <-90 || lat >90);

                }
                while (!ok);
                latCalc = (90 - lat);
                june = latCalc + angle;
                december = latCalc - angle;
                Console.WriteLine("Sous la latitude de: {0}° le soleil est incliné à: {1}° le 20Mars et 22 Septembre {2}° le 21 Juin et à: {3}° le 21 décembre.",lat, latCalc, june, december);
                Console.WriteLine("Voulez vous faire un nouveau clacul ?");
                recommencer = Console.ReadKey();

            }
            while(recommencer.Key == ConsoleKey.Y || recommencer.Key == ConsoleKey.O);

            Console.WriteLine("Au revoir");
            Console.ReadLine();
        }
    }
}
