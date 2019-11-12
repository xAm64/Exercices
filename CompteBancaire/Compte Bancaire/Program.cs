using System;

namespace Compte_Bancaire
{
    class Program
    {
        #region Variables
        private static ConsoleKey inputKey = ConsoleKey.Spacebar;
        private static int number;
        #endregion

        #region Fonctions
        //Verif double
        public static double VerifDouble (string _message)
        {
            string saisie;
            double number;
            bool ok = false;

            do
            {
                Console.WriteLine (_message);
                saisie = Console.ReadLine ();
                ok = double.TryParse (saisie, out number);
                if (!ok)
                {
                    throw new InvalidOperationException ("Écrivez moi des chiffres, je ne suis pas madame soleil");
                }
            } while (!ok);
            return number;
        }
        // Vérif int
        public static int VerifInt (string _message)
        {
            string saisie;
            int number;
            bool ok = false;

            do
            {
                Console.WriteLine (_message);
                saisie = Console.ReadLine ();
                ok = int.TryParse (saisie, out number);
                if (!ok)
                {
                    throw new InvalidOperationException ("Écrivez moi des chiffres, je ne suis pas madame soleil");
                }
            } while (!ok);
            return number;
        }
        #endregion

        static void Main (string[] args)
        {
            Console.WriteLine ("Programme de simulation de Banque.");
            Bank myBank = new Bank ();
            myBank.Init ();
            do
            {
                try
                {
                    Console.WriteLine ("Que voulez-vous faire ?\nCrée un compte [C], Interagir avec un compte [I], Voir tout les comptes [T], Fermer un compte [F], Comparer de comptes [F1], Quitter le programme [Escap]");
                    inputKey = Console.ReadKey ().Key;
                    Console.Clear ();
                    switch (inputKey)
                    {
                        #region Créer
                        case ConsoleKey.C:
                            myBank.CrerCompte ();
                            break;
                        #endregion
                        #region Interagir
                        case ConsoleKey.I:
                            number = VerifInt ("\nIndiquer le numéro du compte");
                            myBank.InteractionCompte (number);
                            break;
                        #endregion
                        #region Tout voir
                        case ConsoleKey.T:
                            Console.WriteLine(myBank.AfficherBank ());
                            break;
                        #endregion
                        #region Sortie
                        case ConsoleKey.Escape:
                            Console.WriteLine ("\nLe programme va se terminer");
                            break;
                        #endregion
                        #region Supprimer un compte
                        case ConsoleKey.F:
                            number = VerifInt ("\nQuel est le numéro du compte à supprimer ?");
                            bool ok = myBank.Supprimer (number);
                            if (!ok)
                            {
                                Console.WriteLine ("Le compte numéro "+ number +" est supprimmer");
                            }
                            else
                            {
                                Console.WriteLine ("Échec de l'opération");
                            }
                            break;
                        #endregion
                        #region Comparer
                        case ConsoleKey.F1:
                            number = VerifInt ("Écriver le numéro du compte principale");
                            int number2 = VerifInt ("Écrivez le numéro du compte à comparer");
                            myBank.Superieure (number, number2);
                            break;
                        #endregion
                        #region Humour
                            //cette fonction est une petite touche d'humour, ceci ne changera rien au bon fonctionnement du programme, mais fera rire.
                        case ConsoleKey.B:
                            Console.WriteLine ("La banque viens d'être braquer !!!\nTous les comptes ont été pillés.\nHeureusement l'assurance a rembourser tous les utilisateurs");
                            break;
                        #endregion
                        default:
                            Console.WriteLine ("\nCette touche n'est pas attribuée");
                            break;
                    }
                }
                catch (Exception error)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine ("ERREUR: " + error.Message);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine ("Concentrez-vous et recommencez...\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            } while (ConsoleKey.Escape != inputKey);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine ("Bye");
            Console.ReadLine ();
        }
    }
}
