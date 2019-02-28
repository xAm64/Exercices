using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static double temp;
        static double tmpCal;

        static void Main(string[] args)
        {
            ConsoleKeyInfo recommencer;
            bool ok;
            do
            {
                Console.WriteLine("Écriver la valeur de temperature C (pour celcus) ou F (pour Farenight)");
                string valeur = Console.ReadLine();
                if (valeur == "C")
                {
                    do
                    {
                        Console.WriteLine("Quelle est la temperateure ?");
                        string temperature = Console.ReadLine();
                        ok = double.TryParse(temperature, out temp);
                        tmpCal = temp * 9 / 5 + 32;
                        Console.WriteLine(temperature + "°" + valeur + " fait " + tmpCal + "°F");
                        Console.WriteLine("Voulez vous faire un autre calcul ?");
                        recommencer = Console.ReadKey();
                    }
                    while (!ok);
                }
                else
                {
                    if (valeur == "F")
                    {
                        do
                        {
                            Console.WriteLine("Quelle est la temperature ?");
                            string temperature = Console.ReadLine();
                            ok = double.TryParse(temperature, out temp);
                            tmpCal = (temp - 32) * 5 / 9;
                            Console.WriteLine(temperature + "°" + valeur + " fait " + tmpCal + "°C");
                            Console.WriteLine("Voulez vous faire un autre calcul ?");
                            recommencer = Console.ReadKey();
                        }
                        while (!ok);
                    }

                    else
                    {
                        Console.WriteLine("À ce jour je ne dispose pas de la la technologie nécéssaire pour lire dans vos pensées");
                        Console.WriteLine("Voulez vous réessayer ?");
                        recommencer = Console.ReadKey();
                    }
                }
            }
                while (recommencer.Key == ConsoleKey.Y || recommencer.Key == ConsoleKey.O);
            
                Console.ReadLine();
            }
    }
}
