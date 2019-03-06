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
                "43A", "54A", "62B", "74B", "85B", "93C", "27C", "33D", "45D", "56F", "64B",
            };
            string[] noms = new string[]
            {
                "Aristide Barnit", "Joseph Loseille", "Léon Nidas", "Gaston Choconnou", "Louise Chimelle", "Justin Bribou", "Nicolas Metrel", "Léonite Caravane", "Albert Etbasque", "Jules Moche", "Etchgaray Manex",
            };
            int[] jour = new int[]
            {
                6, 6, 1, 6, 1, 2, 1, 6, 6, 1, 0,
            };
            int[] mois = new int[]
            {
                8, 7, 9, 8, 7, 0, 0, 8, 7, 9, 11,
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
                    string txtJour;
                    string txtMois;
                    if(numMois == 0)
                    {
                        txtMois = "livraison possible toute l'année";
                    }
                    else
                    {
                        txtMois = "Pas de livraison possible au mois de: " +month[numMois];
                    }
                    if(numJour == 0)
                    {
                        txtJour = "livraison possible toute la semaine sauf le dimanche";
                    }
                    else
                    {
                        txtJour = "Pas de livraison le: " + days[numJour] +"ni le dimanche";
                    }
                    Console.WriteLine("Numero {0} Nom : {1}. {2}. {3}.", saisie, noms[index], txtJour, txtMois);

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