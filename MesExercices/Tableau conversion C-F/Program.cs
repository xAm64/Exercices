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
                        Console.WriteLine("Temperature de départ ?");
                        temp = Console.ReadLine();
                        ok = double.TryParse(temp, out Tmin);
                        if (!ok)
                        {
                            Console.WriteLine("Écrivez la valeur en chiffres! ceci est un ordinateur, pas une voyante !");
                            Console.WriteLine("Appuyer sur la touche entrée pour recommencer");
                            Console.ReadLine();
                        }
                    }
                    while (!ok);
                    do
                    {
                        Console.WriteLine("À quel temperature doit il arrêter ?");
                        temp = Console.ReadLine();
                        ok = double.TryParse(temp, out Tmax);
                        if (!ok)
                        {
                            Console.WriteLine("Écrivez la valeur en chiffre, l'ordinateur n'est pas madame soleil !");
                            Console.WriteLine("Appuyer sur la touche entrée pour recommencer");
                            Console.ReadLine();
                        }
                    }
                    while (!ok);
                    if (Tmin > Tmax)
                    {
                        Console.WriteLine("Une inversion a été détecter entre la temperature minimale et maximale !");
                        Console.WriteLine("Appuyer sur la touche entrée pour recommencer");
                        Console.ReadLine();

                        restart = true;
                    }
                    else
                    {
                        do
                        {
                            Console.WriteLine("De combien on monte à chaque lignes ?");
                            temp = Console.ReadLine();
                            ok = double.TryParse(temp, out Progres);
                            if (!ok)
                            {
                                Console.WriteLine("À ce jour l'ordinateur n'a pas le don de lire dans vos pensées, mais il sait bien calculer si on lui donne des chiffres !");
                                Console.WriteLine("Appuyer sur la touche entrée pour recommencer");
                                Console.ReadLine();
                            }
                        }
                        while (!ok);
                        
                        if (unit == "C")
                        {
                            Console.WriteLine("Appuyer sur entrée (le coussin entrée est accépter) pour commencer le calcul");
                            double i;
                            Console.ReadLine();
                            for (i = Tmin; i <= Tmax; i +=Progres)
                            {
                                tempCal = (i * 9 / 5) + 32;
                                Console.WriteLine("{0}°{1} = {2}°F", i, unit, tempCal);
                            }
                            Console.WriteLine("Si vous souhaiter faire un nouveau calcul appuyer sur la touche O");
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
                            Console.WriteLine("Si vous souhaiter faire un nouveau calcul appuyer sur la touche O");
                            restart = Console.ReadKey().Key == ConsoleKey.O;
                        }
                    }
                }
                else
                {

                    Console.WriteLine("À ce jour l'ordinateur na pas le pouvoir de lire dans vos pensées !");
                    Console.WriteLine("Écrivez les unités de temperature en °C (touche C) ou °F (touche F)");
                    Console.WriteLine("Appuyer sur entrée pour recommencer");
                    Console.ReadLine();

                    restart = true;
                }

            }
            while (restart);
            Console.ReadLine();
        }
    }
}
