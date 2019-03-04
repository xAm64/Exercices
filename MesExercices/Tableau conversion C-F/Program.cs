using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableau_conversion_C_F
{
    class Program
    {
        static double Tmin;
        static double Tmax;
        static double Progres;
        static string temp;
        static double tempCal;

        static void Main(string[] args)
        {
            bool restart;
            bool ok;
            restart = false;
            Console.WriteLine("Bonjour, l'ordinateur va effectuer un tableau de conversion Celcus <-> Farenight");
            do
            {
                Console.WriteLine("Quelle est l'unitée de temperature à calculer ? (C ou F)");
                string unit = Console.ReadLine();
                if (unit == "C" || unit == "F")
                {
                    do
                    {
                        Console.WriteLine("À quel temperature dois il commencer ?");
                        temp = Console.ReadLine();
                        ok = double.TryParse(temp, out Tmin);
                        if (!ok)
                        {
                            Console.WriteLine("Écrivez des chiffres, l'ordinateur n'est pas madame soleil !");
                        }
                    }
                    while (!ok);
                    do
                    {
                        Console.WriteLine("À quel temperature je dois il arrêter ?");
                        temp = Console.ReadLine();
                        ok = double.TryParse(temp, out Tmax);
                        if (!ok)
                        {
                            Console.WriteLine("Écrivez une valeur en chiffre, l'ordinateur n'est pas madame soleil !");
                        }
                    }
                    while (!ok);
                    if (Tmin > Tmax)
                    {
                        Console.WriteLine("Une fausse manip a été détecter, la valeur minimale doit être INFÉRIEURE à la valeur maximale !");
                        restart = true;
                    }
                    else
                    {
                        Console.WriteLine("De combien on monte à chaque lignes ?");
                        temp = Console.ReadLine();
                        ok = double.TryParse(temp, out Progres);
                        if (!ok)
                        {
                            Console.WriteLine("La valeur doit être en chiffres");
                        }
                        if (unit == "C")
                        {
                            Console.WriteLine("Appuyer sur une touche pour commencer le calcul");
                            double i;
                            Console.ReadLine();
                            for (i = Tmin; i <= Tmax; i +=Progres)
                            {
                                tempCal = (i * 9 / 5) + 32;
                                Console.WriteLine("{0}°{1} = {2}°F", i, unit, tempCal);
                            }
                            Console.WriteLine("Un nouveau calcul ?");
                            restart = Console.ReadKey().Key == ConsoleKey.O;
                        }
                        else
                        {
                            Console.WriteLine("Appuyer sur une touche pour commencer le calcul");
                            double i;
                            Console.ReadLine();
                            for (i = Tmin; i <= Tmax; i +=Progres)
                            {
                                tempCal = (i - 32) * 5 / 9;
                                Console.WriteLine("{0}°{1} = {2}°C", i, unit, tempCal);
                            }
                            Console.WriteLine("Un nouveau calcul ?");
                            restart = Console.ReadKey().Key == ConsoleKey.O;
                        }
                    }
                }
                else
                {

                    Console.WriteLine("À ce jour l'ordinateur na pas le pouvoir de lire dans vos pensées !");
                    restart = true;
                }

            }
            while (restart);
            Console.ReadLine();
        }
    }
}
