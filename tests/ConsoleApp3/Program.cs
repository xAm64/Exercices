using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static double tmpCal;
        static double tmin;
        static double tmax;


        static void Main(string[] args)
        {
            bool ok;

            do
            {
                do
                {
                    Console.WriteLine("Quel est la temperature de départ ?");
                    string temperature = Console.ReadLine();
                    ok = double.TryParse(temperature, out tmin);
                    if (!ok)
                    {
                        Console.WriteLine("Une erreur a été détecter je ne prend que des chiffres");
                    }
                }
                while (!ok);
                do
                {
                    Console.WriteLine("Quel est la temperature de fin ?");
                    string temperature = Console.ReadLine();
                    ok = double.TryParse(temperature, out tmax);
                    if (!ok)
                    {
                        Console.WriteLine("Une erreur a été détecter je ne prend que des chiffres");
                    }
                }
                while (!ok);
                
                if(tmin > tmax)
                {
                    Console.WriteLine("Une erreur est détecter, la valeur de la temperature minimale doit être inférieur à celel de la temperature maximale");
                }

            }
            while (tmin > tmax);
            string value;
            do
            {
                Console.WriteLine("Écriver la valeur de la temperature C (pour celcus) ou F (pour Fareneight)");
                value = Console.ReadLine();
                if (value == "C")
                {
                    Console.WriteLine("Très bien je commence");
                    for(double i = tmin; i <= tmax; i +=0.5)
                    {
                        tmpCal = i * 9 / 5 + 32;
                        Console.WriteLine("{0}°{1} = {2}°F",i ,value, tmpCal);
                    }
                }
                else
                {
                    if (value == "F")
                    {
                        Console.WriteLine("Très bien je commence");
                        for(double i = tmin; i<= tmax; i++)
                        {
                            tmpCal = (i - 32) * 5 / 9;
                            Console.WriteLine("{0}°{1} = {2}°C",i ,value, tmpCal);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Une erreur a été détecter, il n'existe que 2 unités de mesures Celcus ou Farenight");
                    }
                    
                }
                
            }
            
            while (value != "C" && value != "F");

            Console.ReadLine();
        }
    }
}
