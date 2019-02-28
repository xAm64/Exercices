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
                            Console.WriteLine("La terre n'est pas plate, mais ronde. Sa latitude est entre 90° pour le pôle nord et -90° pour le pôle sud");
                        }
                    }
                    while (lat <-90 || lat >90);

                }
                while (!ok);
                latCalc = (90 - lat);
                june = latCalc + angle;
                december = latCalc - angle;
                Console.WriteLine("Sous la latitude de: {0}° le soleil est incliné à: {1}° le 21 Juin et à: {2}° le 21 décembre. (0° représente l'horison sud)", lat, june, december);
                Console.WriteLine("Voulez vous faire un nouveau clacul ?");
                recommencer = Console.ReadKey();

            }
            while(recommencer.Key == ConsoleKey.Y || recommencer.Key == ConsoleKey.O);
            

            Console.ReadLine();
        }
    }
}
