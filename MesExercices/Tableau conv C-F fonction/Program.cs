using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableau_conversion_C_F
{
    class Program
    {
        #region Convertisseur Celsius en Fahrenheit
        static double ConversionC (double valCelsius)
        {
            double fahrenheit = (valCelsius * 9 / 5) + 32;//convertis les Celsius en Fahrenheit
            return fahrenheit;
        }
        #endregion
        #region Convertisseur Fahrenheit en Celsius
        static double ConversionF (double valFahrenheit)
        {
            double Celsius = (valFahrenheit - 32) * 5 / 9;//convertis les Fahrenheit en Celsius
            return Celsius;
        }
        #endregion
        #region Procedure de Parse
        static double Parseur (string message)
        {
            double numParser;
            bool ok;
            do
            {
                Console.WriteLine(message);
                string saisie = Console.ReadLine();
                ok = double.TryParse(saisie, out numParser);
                if (!ok)
                {
                    Console.WriteLine("Écris moi une valeur en chiffres, je ne suis pas madame soleil !");
                }
            }
            while (!ok);
            return numParser;
        }
        #endregion

        static void Main(string[] args)
        {
            double tMin = 0;
            double tMax = 0;
            double pas = 0;
            double tempCal;
            bool restart;
            restart = false;
            Console.WriteLine("Bonjour, l'ordinateur va effectuer un tableau de conversion Celcus <-> Farenight");
            do
            {
                Console.WriteLine("Quelle est l'unitée de temperature à calculer ? (C ou F)");//On demande à l'utilisateur de choisir le calcul
                string unit = Console.ReadLine();
                if (unit == "C" || unit == "F")//L'utilisateur a fait la bonne saisie
                {
                    #region Collecte d'info temperatures.
                    tMin = Parseur("Temperature de départ");
                    tMax = Parseur("Temperature d'arrêt");
                    #endregion
                    #region Erreur inversion des temperatures
                    if (tMin > tMax)
                    {
                        Console.WriteLine("Une inversion a été détecter entre la temperature minimale et maximale !");
                        Console.WriteLine("Appuyer sur la touche entrée pour recommencer");
                        Console.ReadLine();

                        restart = true;
                    }
                    #endregion
                    else
                    {
                        #region Collecte du pas
                        pas = Parseur("Quel est le pas de montée");
                        #endregion
                        #region Calcul de °C > °F
                        if (unit == "C")
                        {
                            Console.WriteLine("Appuyer sur entrée (le coussin entrée est accépter) pour commencer le calcul");
                            double i;
                            Console.ReadLine();
                            for (i = tMin; i <= tMax; i += pas)
                            {
                                tempCal = ConversionC(i);
                                Console.WriteLine("{0}°{1} = {2}°F", i, unit, tempCal);
                            }
                            Console.WriteLine("Si vous souhaiter faire un nouveau calcul appuyer sur la touche O");
                            restart = Console.ReadKey().Key == ConsoleKey.O;
                        }
                        #endregion
                        #region Calcul de °F > °C
                        else
                        {
                            Console.WriteLine("Appuyer sur une touche pour commencer le calcul");
                            double i;
                            Console.ReadLine();
                            for (i = tMin; i <= tMax; i += pas)
                            {
                                tempCal = ConversionF(i);
                                Console.WriteLine("{0}°{1} = {2}°C", i, unit, tempCal);
                            }
                            Console.WriteLine("Si vous souhaiter faire un nouveau calcul appuyer sur la touche O");
                            restart = Console.ReadKey().Key == ConsoleKey.O;
                        }
                        #endregion
                    }
                }
                else//L'utilisateur c'est trompé dans la demande de calcul
                {

                    Console.WriteLine("À ce jour l'ordinateur na pas le pouvoir de lire dans vos pensées !");
                    Console.WriteLine("Écrivez les unités de temperature en °C (touche C) ou °F (touche F)");
                    Console.WriteLine("Appuyer sur entrée pour recommencer");
                    Console.ReadLine();

                    restart = true;
                }

            }
            while (restart);
            Console.WriteLine("Au revoir");
            Console.ReadLine();
        }
    }
}
