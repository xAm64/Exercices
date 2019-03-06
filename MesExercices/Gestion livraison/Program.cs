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
                if (index < num_client.Length)//condition trouvé
                {

                    Console.WriteLine("Le numéro corespondant a été trouvé");
                    int numJour = jour[index];
                    int numMois = mois[index];
                    string diaz;
                    string mes;
                    if (numMois == 0)
                    {
                        mes = "livraison possible toute l'année";
                    }
                    else
                    {
                        mes = "Pas de livraison possible au mois de: " + month[numMois];
                    }
                    if (numJour == 0)
                    {
                        diaz = "livraison possible toute la semaine sauf le dimanche";
                    }
                    else
                    {
                        diaz = "Pas de livraison le: " + days[numJour] + " ni le dimanche";
                    }
                    Console.WriteLine("Numero {0} Nom : {1}. {2}. {3}.", saisie, noms[index], diaz, mes);//Recherche le nom et affiche les règles à ce point.

                    bool pass;
                    int dayLiv;
                    int monthLiv;
                    do //calcul du jour de livraison si possible ou pas.
                    {
                        pass = true;
                        dayLiv = 0;
                        Console.WriteLine("Quel jour de livraison souhaitez vous ?");
                        string jourLiv = Console.ReadLine().Trim();
                        if (days.Contains(jourLiv))//doit rechercher les jours, si pas trouvé passer en chiffres
                        {
                            while ((dayLiv <= days.Length) && (jourLiv != days[dayLiv]))
                            {
                                dayLiv++;
                            }
                        }
                        else
                        {
                            pass = int.TryParse(jourLiv, out dayLiv);//ok

                        }
                        if (!pass || dayLiv > days.Length || dayLiv == 0 || dayLiv == numJour)
                        {
                            if (!pass || dayLiv > days.Length)
                            {
                                Console.WriteLine("Il y a une erreur dans la saisie du jour, merci d'écrire le jour de la semaine ou le chiffre corespondant (1 à 6)");
                                Console.WriteLine("Appuyer sur une touche pour recommencer");
                                Console.ReadLine();
                            }
                            if (dayLiv == 0)
                            {
                                Console.WriteLine("La livraison n'est pas possible le dimanche");
                                pass = false;
                                Console.WriteLine("Appuyer sur entrée pour recommencer");
                                Console.ReadLine();
                            }
                            if (dayLiv == numJour)
                            {
                                Console.WriteLine(diaz);
                                pass = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("La livraison est possible");
                        }


                    }
                    while (!pass);

                    do //calcul du mois de livraison si possible ou pas.
                    {
                        pass = true;
                        monthLiv = 0;
                        Console.WriteLine("Quel mois pour la livraison ?");
                        string moisLiv = Console.ReadLine().Trim();
                        if (month.Contains(moisLiv))//doit rechercher les jours, si pas trouvé passer en chiffres
                        {
                            while ((monthLiv <= month.Length) && (moisLiv != month[monthLiv]))
                            {
                                monthLiv++;
                            }
                        }
                        else
                        {
                            pass = int.TryParse(moisLiv, out monthLiv);//ok

                        }
                        if (!pass || monthLiv > days.Length || monthLiv == 0 || monthLiv == numMois)
                        {
                            if (!pass || monthLiv > month.Length)
                            {
                                Console.WriteLine("Il y a une erreur dans la saisie, merci d'écrire le mois ou de mettre un chiffre corespondant entre 1 et 12");
                                Console.WriteLine("Appuyer sur une touche pour recommencer");
                                Console.ReadLine();
                            }
                            if (monthLiv == 0)
                            {
                                Console.WriteLine("La livraison n'est pas possible toute l'année");
                                pass = false;
                                Console.WriteLine("Appuyer sur entrée pour recommencer");
                                Console.ReadLine();
                            }
                            if (monthLiv == numMois)
                            {
                                Console.WriteLine(mes);
                                pass = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("La livraison est possible");
                        }
                    }
                    while (!pass);
                }
                else// client non trouvé
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