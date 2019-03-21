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

        #region Saisie de l'utilisateur
        static bool NumeroCLient (ref int placementIndex, string saisie)
        {
            bool pass;
            string[] num_client = new string[]
            {
                "43A", "54A", "62B", "74B", "85B", "93C", "27C", "33D", "45D", "56F", "64B",
            };

            int index = 0;
            while((index < num_client.Length) && (saisie != num_client[index]))
            {
                index++;
            }
            if (index < num_client.Length)
            {
                placementIndex = index;
                pass = true;
            }
            else
            {
                pass = false;
            }
            return pass;
        }
        #endregion

        #region Indication des règles
        static string ReglesLivraison (int indexClient, string nomClient, ref int jourInterdit, ref int moisInterdit)
        {
            string[] noms = new string[]//nom du client
            {
                "Aristide Barnit", "Joseph Loseille", "Léon Nidas", "Gaston Choconnou", "Louise Chimelle", "Justin Bribou", "Nicolas Metrel", "Léonite Caravane", "Albert Etbasque", "Jules Moche", "Etchgaray Manex",
            };
            int[] jour = new int[]//jour de la semaine
            {
                6, 6, 1, 6, 1, 2, 1, 6, 6, 1, 0,
            };
            int[] mois = new int[]//mois de l'année
            {
                8, 7, 9, 8, 7, 0, 0, 8, 7, 9, 11,
            };
            string[] days = new string[]//noms des jours
            {
                "dimanche", "lundi", "mardi", "mercredi", "jeudi", "vendredi", "samedi",
            };
            string[] month = new string[]//noms des mois
            {
                "aucun", "janvier", "février", "mars", "avril", "mai", "juin", "juillet", "août", "septembre", "octobre", "novembre", "décembre",
            };
            jourInterdit = jour[indexClient];
            moisInterdit = mois[indexClient];
            string nomJourInterdit;
            string nomMoisInterdit;
            nomClient = noms[indexClient];
            if (jourInterdit == 0)
            {
                nomJourInterdit = "Dimanche";
            }
            else
            {
                nomJourInterdit = days[jourInterdit] + " et le dimanche";
            }
            if (moisInterdit == 0)
            {
                nomMoisInterdit = "livraison possible toute l'année";
            }
            else
            {
                nomMoisInterdit = "ni au mois de: " + month[moisInterdit];
            }
            string sortie = "Le client: " + nomClient + ", pas de livraison le: " + nomJourInterdit + ", " + nomMoisInterdit + ".";
            return sortie;
        }
        #endregion

        #region recherche jour demandé
        static bool JourDemande (string saisie, ref int jourDemande)
        {
            bool pass = true;
            string[] days = new string[]//noms des jours
            {
                "dimanche", "lundi", "mardi", "mercredi", "jeudi", "vendredi", "samedi",
            };
            if (days.Contains(saisie))
            {
                jourDemande = 0;
                while ((jourDemande <= days.Length) && (saisie != days[jourDemande]))
                {
                    jourDemande++;
                }
            }
            else
            {
                pass = int.TryParse(saisie, out jourDemande);
                if (!pass)
                {
                    jourDemande = 99;
                }
            }
            return pass;
        }
        #endregion

        #region Recherch du mois demandé
        static bool MoisDemande (string saisie, ref int moisDemande)
        {
            bool pass = true;
            string[] month = new string[]//noms des mois
            {
                "aucun", "janvier", "février", "mars", "avril", "mai", "juin", "juillet", "août", "septembre", "octobre", "novembre", "décembre",
            };
            if (month.Contains(saisie))
            {
                moisDemande = 0;
                while ((moisDemande <= month.Length)&&(saisie != month[moisDemande]))
                {
                    moisDemande++;
                }
            }
            else
            {
                pass = int.TryParse(saisie, out moisDemande);
                if (!pass)
                {
                    moisDemande = 99;
                }
            }
            return pass;
        }
        #endregion

        static void Main(string[] args)
        {
            bool restart = false;
            do
            {
                #region Recherche du client
                int place = 0;
                bool pass = true;
                do
                {
                    Console.WriteLine("Écrire le numéro du client");
                    saisie = Console.ReadLine();
                    pass = NumeroCLient(ref place, saisie);
                    if (!pass)
                    {
                        Console.WriteLine("Le client n'existe pas");
                    }
                }
                while (!pass);
                #endregion

                #region Indique les règles de livraison
                string nomClient = "";
                int jourInterdit = 0;
                int moisInterdit = 0;
                string regles = ReglesLivraison(place, nomClient, ref jourInterdit, ref moisInterdit);
                Console.WriteLine(regles);
                #endregion

                #region choix du jour de livraison
                int jourDemande = 0;
                do
                {
                    Console.WriteLine("Quel jour de livraison ?");
                    saisie = Console.ReadLine();
                    pass = JourDemande(saisie, ref jourDemande);
                    if (!pass || jourDemande < 1 || jourDemande > 6 || jourDemande == jourInterdit || jourDemande == 99)
                    {
                        pass = false;
                        Console.WriteLine("L'erreur suivate à été détecter: ");
                        if (!pass && jourDemande == 99)
                        {
                            Console.Write("Vous avez écrit n'importe quoi");
                        }
                        if ((jourDemande < 1 || jourDemande > 6) && jourDemande != 99)
                        {
                            Console.Write("il y a que 7 jours dans une semaine et personne en travaille un dimanche");
                        }
                        if (jourDemande == jourInterdit)
                        {
                            Console.Write("La livraison n'est pas possible ce jour la: {0}", regles);
                        }
                    }
                    else
                    {
                        Console.WriteLine("La livraison est possible ce jour");
                        pass = true;
                    }
                }
                while (!pass);
                #endregion

                #region Choix du mois de livraison
                int moisDemande = 0;
                do
                {
                    pass = true;
                    Console.WriteLine("Quel est le mois de livraison ?");
                    saisie = Console.ReadLine();
                    pass = MoisDemande(saisie, ref moisDemande);
                    if (!pass || moisDemande < 1 || moisDemande > 12 || moisDemande == moisInterdit || moisDemande == 99)
                    {
                        Console.WriteLine("J'ai détecter l'erreur suivante: ");
                        pass = false;
                        if (!pass && moisDemande == 99)
                        {
                            Console.Write("Le mois écrit n'existe pas, merci d'écrire le mois ou son numéro (1 à 12)");
                        }
                        if ((moisDemande < 1 || moisDemande > 12) && moisDemande != 99)
                        {
                            Console.Write("Il y a 12 mois dans l'année merci de reformuler le nom ou le numéro du mois corecpondant");
                        }
                        if (moisDemande == moisInterdit)
                        {
                            Console.Write("La livraison n'est pas possible: {0}", regles);
                        }
                    }
                    else
                    {
                        Console.WriteLine("La livraison est possible");
                    }
                }
                while (!pass);
                #endregion

                Console.WriteLine("Un autre essaie ?");
                restart = Console.ReadKey().Key == ConsoleKey.O;
            }
            while (restart);

            Console.WriteLine("\nAu revoir");
            Console.ReadLine();
        }
    }
}