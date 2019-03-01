using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] cities = new string[]
            {
            "Lille",
            "Paris",
            "Bordeaux",
            "Biarritz",
            "Perpignan",
            "Lyon",
            "Mulhouse",
            "Nice",
            };

            bool restart = false;
            string search;
            do
            {
                Console.WriteLine("Écrivez un nom à rechercher");
                search = Console.ReadLine().Trim();//trim supprime les espaces

                if (string.IsNullOrEmpty(search))
                {
                    Console.WriteLine("Vous n'avez rien écrit");
                    restart = true;
                }
                else
                {
                    Console.WriteLine("{0}Vous recherchez la ville de: {1}", Environment.NewLine, search);

                    foreach (string value in cities)
                    {
                        if(value.ToLower() == search.ToLower())
                        {
                            Console.WriteLine("La ville de: {0} existe", search);
                            Console.WriteLine("Elle se situe à la position: {0}", Array.IndexOf(cities, search));
                            break;
                        }
                    }
                    Console.WriteLine("\n Nouvelle recherche ?");

                    restart = Console.ReadKey().Key == ConsoleKey.O;
                }

            }
            while (restart);


            Console.ReadLine();
        }
    }
}
