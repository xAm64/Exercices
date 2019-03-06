using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_livraison
{
    class Program
    {
        static string saisie;

        static void Main(string[] args)
        {
            string[] num_client = new string[]
            {
                "43A", "54A", "62B", "74B", "85B", "93C", "27C", "33D", "45D", "56F",
            };
            string[] noms = new string[]
            {
                "Aristide Barnit", "Joseph Loseille", "Léon Nidas", "Gaston Choconnou", "Louise Chimelle", "Justin Bribou", "Nicolas Metrel", "Léonite Caravane", "Albert Etbasque", "Jules Moche",
            };
            int[] jour = new int[]
            {
                6, 6, 1, 6, 1, 2, 1, 6, 6, 1,
            };
            int[] mois = new int[]
            {
                8, 7, 9, 8, 7, 0, 0, 8, 7, 9,
            };
            string[] days = new string[]
            {
                "Dimanche", "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi",
            };
            string[] month = new string[]
            {
                "Aucun", "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre",
            };

            bool restart = false;
            do
            {
                Console.WriteLine("Numéro du client");
                saisie = Console.ReadLine();

                int index = 0;
                while ((index < num_client.Length)&&(saisie != num_client[index]))
                {
                    index++;
                }
                if(index < num_client.Length)//condition trouvé
                {

                    Console.WriteLine("Le numéro corespondant a été trouvé");
                    int numJour = jour[index];
                    int numMois = mois[index];
                    if(numMois == 0)
                    {
                        Console.WriteLine("Numero {0} Nom : {1} Pas de livraison le {2} Livraison possible toute l'année", saisie, noms[index], days[numJour]);
                    }
                    else
                    {
                        Console.WriteLine("Numero {0} Nom : {1} Pas de livraison le {2} ni au mois de {3}", saisie, noms[index], days[numJour], month[numMois]);
                    }
                    

                }
                else//non trouvé
                {
                    Console.WriteLine("Ce client n'existe pas !");
                    Console.ReadLine();
                }
                Console.WriteLine("Un autre essaie ?");
                restart = Console.ReadKey().Key == ConsoleKey.O;
            }
            while (restart);

            Console.WriteLine("Au revoir");
            Console.ReadLine();
        }
    }
}