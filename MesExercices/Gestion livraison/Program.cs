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
            #region Tableaux
            string[] num_client = new string[]//numéro du client
            {
                "43A", "54A", "62B", "74B", "85B", "93C", "27C", "33D", "45D", "56F", "64B",
            };
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
                "Dimanche", "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi",
            };
            string[] month = new string[]//noms des mois
            {
                "Aucun", "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre",
            };
            #endregion
            bool restart = false;
            do
            {
                Console.WriteLine("Numéro du client");//recherche du client
                saisie = Console.ReadLine();

                int index = 0;
                while ((index < num_client.Length)&&(saisie != num_client[index]))//recherche du numéro client
                {
                    index++;
                }

                if (index < num_client.Length)//condition trouvé
                {
                    #region Indique les règles de livraison
                    Console.WriteLine("Le numéro corespondant a été trouvé");
                    int numJour = jour[index];//recherche le jour interdit
                    int numMois = mois[index];//recherche le mois interdit
                    string diaz;//message du jour
                    string mes;//message du mois
                    if (numMois == 0)//si le mois est = à 0 il n'y a pas de restriction
                    {
                        mes = "livraison possible toute l'année";
                    }
                    else//On indique les restrictions
                    {
                        mes = "Pas de livraison possible au mois de: " + month[numMois];
                    }
                    if (numJour == 0)//si le jour est 0 il n'y a pas de restriction sur le jour.
                    {
                        diaz = "livraison possible toute la semaine sauf le dimanche";
                    }
                    else//on indique les restrictions
                    {
                        diaz = "Pas de livraison le: " + days[numJour] + " ni le dimanche";
                    }
                    Console.WriteLine("Numero {0} Nom : {1}. {2}. {3}.", saisie, noms[index], diaz, mes);//Message des restrictions selon les conditions du client.
                    #endregion

                    bool pass;
                    int dayLiv;//jour de livraison
                    int monthLiv;//mois de livraison
                    #region choix du jour de livraison
                    do //calcul du jour de livraison si possible ou pas.
                    {
                        pass = true;
                        dayLiv = 0;
                        Console.WriteLine("Quel jour de livraison souhaitez vous ?");
                        string jourLiv = Console.ReadLine().Trim();
                        if (days.Contains(jourLiv))//recherche les jour en lettres
                        {
                            while ((dayLiv <= days.Length) && (jourLiv != days[dayLiv]))
                            {
                                dayLiv++;
                            }
                        }
                        else
                        {
                            pass = int.TryParse(jourLiv, out dayLiv);//N'a pas trouvé en lettre recherche en chiffre

                        }
                        if (!pass || dayLiv > days.Length || dayLiv == 0 || dayLiv == numJour)//conditions des erreurs.
                        {
                            if (!pass || dayLiv > days.Length)//Correction l'utilisateur à écrit n'importe quoi
                            {
                                Console.WriteLine("Il y a une erreur dans la saisie du jour, merci d'écrire le jour de la semaine ou le chiffre corespondant (1 à 6)");
                                Console.WriteLine("Appuyer sur une touche pour recommencer");
                                Console.ReadLine();
                            }
                            if (dayLiv == 0)//correction l'utilisateur demande le dimanche
                            {
                                Console.WriteLine("La livraison n'est pas possible le dimanche");
                                pass = false;
                                Console.WriteLine("Appuyer sur entrée pour recommencer");
                                Console.ReadLine();
                            }
                            if (dayLiv == numJour)//correction l'utilisateur demande le jour interdit
                            {
                                Console.WriteLine(diaz);
                                pass = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("La livraison est possible");//l'utilisateur a écrit une saisie correct
                        }


                    }
                    while (!pass);
                    #endregion
                    #region Choix du mois de livraison
                    do //calcul du mois de livraison si possible ou pas.
                    {
                        pass = true;
                        monthLiv = 0;
                        Console.WriteLine("Quel mois pour la livraison ?");//l'utilisateur choisis le mois de livraison
                        string moisLiv = Console.ReadLine().Trim();
                        if (month.Contains(moisLiv))//recherche dans la liste des mois le nom
                        {
                            while ((monthLiv <= month.Length) && (moisLiv != month[monthLiv]))
                            {
                                monthLiv++;
                            }
                        }
                        else
                        {
                            pass = int.TryParse(moisLiv, out monthLiv);//recherche le mois à partir du chiffre

                        }
                        if (!pass || monthLiv > month.Length || monthLiv == 0 || monthLiv == numMois)//les cas d'erreur avec les corrections
                        {
                            if (!pass || monthLiv > month.Length)//l'utilisateur à écrit n'importe quoi
                            {
                                Console.WriteLine("Il y a une erreur dans la saisie, merci d'écrire le mois ou de mettre un chiffre corespondant entre 1 et 12");
                                Console.WriteLine("Appuyer sur une touche pour recommencer");
                                Console.ReadLine();
                            }
                            if (monthLiv == 0)//l'utilisateur demande toute l'année
                            {
                                Console.WriteLine("La livraison n'est pas possible toute l'année");
                                pass = false;
                                Console.WriteLine("Appuyer sur entrée pour recommencer");
                                Console.ReadLine();
                            }
                            if (monthLiv == numMois)//l'utilisateur demande el mois interdit
                            {
                                Console.WriteLine(mes);
                                pass = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("La livraison est possible");//l'utilisateur demande un mois non interdit
                        }
                    }
                    while (!pass);
                    #endregion
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