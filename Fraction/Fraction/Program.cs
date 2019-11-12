using System;

namespace Fraction
{
    class Program
    {
        #region Fonction
        #region Vérification
        public static int VerifInt (string _message)
        {
            int number;
            bool ok;
            do
            {
                Console.WriteLine (_message);
                string saisie = Console.ReadLine ();
                ok = int.TryParse (saisie, out number);
                if (!ok)
                {
                    throw new InvalidOperationException ("Écris moi des chiffres, je ne suis pas madame soleil");
                }
            } while (!ok);
            return number;
        }
        #endregion
        #region Vérification de fraction
        public static int VerifFrac (string _message)
        {
            int number;
            bool ok;
            do
            {
                Console.WriteLine (_message);
                string saisie = Console.ReadLine ();
                ok = int.TryParse (saisie, out number);
                if (!ok)
                {
                    throw new InvalidOperationException ("Écris moi des chiffres, je ne suis pas madame soleil");
                }
                if (number > numeroFraction || number <= 0)
                {
                    ok = false;
                    throw new InvalidProgramException ("La fraction saisie n'existe pas");
                }
            } while (!ok);
            return number;
        }
        #endregion
        #region Afficher
        public static string AfficherTout ()
        {
            string contenue = "--- --- Liste des Fractions --- ---\n";
            for (int i = 1; i < numeroFraction; i++)
            {
                if (lesFractions[i] != null)
                {
                    contenue += "Fraction numéro: " + i + ": " + lesFractions[i].Afficher() + "\n";
                }
            }
            contenue += "--- --- Fin de la liste des Fractions --- ---";
            return contenue;
        }
        #endregion
        #endregion

        #region Variables
        private static ConsoleKey touche = ConsoleKey.Spacebar;
        public static int numeroFraction = 0;
        public static Fraction[] lesFractions = new Fraction[25];
        public static int numero1, numero2;
        public static bool result;
        public static string message;
        #endregion
        // --- --- Programme --- ---
        static void Main (string[] args)
        {
            Console.WriteLine ("programme de fraction");
            Ecran ecran = new Ecran();
            lesFractions[numeroFraction] = new Fraction ();
            numeroFraction++;
            do
            {
                try
                {
                    Console.WriteLine (AfficherTout ());
                    Console.WriteLine ("Que voulez-vous faire ?\n" +
                        "Crée une nouvelle Fraction [C]\n" +
                        "Voir le PGCD [P]\n" +
                        "Réduire une fraction [R]\n"+
                        "Comparer si une fraction est : Inférieure [1 pavé num], Égal [2 pavé num], supérieure [3 pavé num], à une autre.\n"+
                        "Additionner [+ pavé num], soustraire [- pavé num], multiplier [* pavé num], diviser [/ pavé num], Faire une puissance [9 pané num], 2 fractions.\n" +
                        "Oposer une fraction [page suivante]" +
                        "Inverser une fraction [page précedente]" +
                        "Sortir du programme [Escap]");
                    touche = Console.ReadKey ().Key;
                    Console.Clear();
                    switch (touche)
                    {
                        #region Créer
                        case ConsoleKey.C:
                            numero1 = VerifInt ("Quel est le numérateur ?");
                            numero2 = VerifInt ("Quel est le dénominateur ?");
                            if (numero2 == 0)
                            {
                                throw new DivideByZeroException ("Impossible de diviser par 0");
                            }
                            lesFractions[numeroFraction] = new Fraction (numero1, numero2);
                            numeroFraction++;
                            break;
                        #endregion
                        #region PGCD
                        case ConsoleKey.P:
                            numero1 = VerifFrac ("Quel le numéro de la fraction où voir calculer le PGCD");
                            int pgcd = lesFractions[numero1].Pgcd ();
                            Console.WriteLine ("Le PGCD est de: " + lesFractions[numero1].Afficher() + " est: " + pgcd + " .");
                            break;
                        #endregion
                        #region Réduire
                        case ConsoleKey.R:
                            numero1 = VerifFrac ("Quel est le numéro de la fraction à réduire ?");
                            lesFractions[numero1].Reduire ();
                            Console.WriteLine ("La nouvelle valeur de la fraction est désormait de: " + lesFractions[numero1].Afficher ());
                            break;
                        #endregion
                        #region Comparer
                        #region Supérieur
                        case ConsoleKey.NumPad3:
                            numero1 = VerifInt ("Quel est le numéro de fraction à comparer ?");
                            numero2 = VerifInt ("À quel numéro de fraction la comparer ?");
                            result = lesFractions[numero1].Superieur (lesFractions[numero2]);
                            if (result)
                            {
                                message = "supérieure";
                            }
                            else
                            {
                                message = "non supérieure";
                            }
                            Console.WriteLine ("La fraction numéro: " + numero1 + " est: " + message + " à la fraction numéro: " + numero2 + ".");
                            break;
                        #endregion
                        #region Inférieure
                        case ConsoleKey.NumPad1:
                            numero1 = VerifFrac ("Quel est le numéro de la fraction à comparer ?");
                            numero2 = VerifFrac ("À quel numéro de fraction la comparer ?");
                            result = lesFractions[numero1].Inferieure (lesFractions[numero2]);
                            if (result)
                            {
                                message = "inférieure";
                            }
                            else
                            {
                                message = "non inférieure";
                            }
                            Console.WriteLine ("La fraction numéro: " + numero1 + " est: " + message + " à la fraction numéro: " + numero2 + ".");
                            break;
                        #endregion
                        #region Égal
                        case ConsoleKey.NumPad2:
                            numero1 = VerifFrac ("Quel est le numéro de la fraction à comparer ?");
                            numero2 = VerifFrac ("À quel numéro de fraction la comparer ?");
                            result = lesFractions[numero1].Egalite (lesFractions[numero2]);
                            if (result)
                            {
                                message = "égale";
                            }
                            else
                            {
                                message = "pas égale";
                            }
                            Console.WriteLine ("La fraction numéro: " + numero1 + " est " + message + " à la faction numéro: " + numero2 + ".");
                            break;
                        #endregion
                        #endregion
                        #region Additionner
                        case ConsoleKey.OemPlus:
                            int fr1, fr2;
                            fr1 = VerifFrac ("Quel est le numéro de la faction de base?");
                            lesFractions[0].SetNumerateur (lesFractions[fr1].GetNumerateur ());
                            lesFractions[0].SetDenominateur(lesFractions[fr1].GetDenominateur ());
                            fr2 = VerifFrac ("Quel est le numéro de la fraction a additionner ?");
                            lesFractions[0].Somme (lesFractions[fr2]);
                            Console.WriteLine ("Le résultat de: " + lesFractions[fr1].Afficher() + " + " + lesFractions[fr2].Afficher() + " est de : " + lesFractions[0].Afficher() + ".");
                            break;
                        #endregion
                        #region Différence
                        case ConsoleKey.OemMinus:
                            fr1 = VerifFrac ("Quel est le numéro de la fraction de base ?");
                            lesFractions[0].SetNumerateur (lesFractions[fr1].GetNumerateur ());
                            lesFractions[0].SetDenominateur (lesFractions[fr1].GetDenominateur ());
                            fr2 = VerifFrac ("Quel est le numéro de la fraction à soustraire");
                            lesFractions[0].Difference (lesFractions[fr2]);
                            Console.WriteLine ("Le résultat de: " + lesFractions[fr1].Afficher () + " - " + lesFractions[fr2].Afficher () + " est de: " + lesFractions[0].Afficher () + ".");
                            break;
                        #endregion
                        #region Produit
                        case ConsoleKey.Multiply:
                            fr1 = VerifFrac ("Quel est le numéro de la faction de base ?");
                            lesFractions[0].SetNumerateur (lesFractions[fr1].GetNumerateur ());
                            lesFractions[0].SetDenominateur (lesFractions[fr1].GetDenominateur ());
                            fr2 = VerifFrac ("Quel est le numéro de la fraction à multiplier ?");
                            lesFractions[0].Produit (lesFractions[fr2]);
                            Console.WriteLine ("Le résultat de: " + lesFractions[fr1].Afficher () + " × " + lesFractions[fr2].Afficher () + " est de: " + lesFractions[0].Afficher () + ".");
                            break;
                        #endregion
                        #region Quotient
                        case ConsoleKey.Divide:
                            fr1 = VerifFrac ("Quel est le numéro de la fraction de base ?");
                            lesFractions[0].SetNumerateur (lesFractions[fr1].GetNumerateur ());
                            lesFractions[0].SetDenominateur (lesFractions[fr1].GetDenominateur ());
                            fr2 = VerifFrac ("Quel est le numéro de la fraction à diviser ?");
                            lesFractions[0].Quotient (lesFractions[fr2]);
                            Console.WriteLine ("le résultat de: " + lesFractions[fr1].Afficher () + " ÷ " + lesFractions[fr2].Afficher () + " est de: " + lesFractions[0].Afficher () + ".");
                            break;
                        #endregion
                        #region Puissance
                        case ConsoleKey.NumPad9:
                            fr1 = VerifFrac ("Quel est le numéro de la fraction de base ?");
                            lesFractions[0].SetNumerateur (lesFractions[fr1].GetNumerateur ());
                            lesFractions[0].SetDenominateur (lesFractions[fr1].GetDenominateur ());
                            fr2 = VerifFrac ("Quel est le numéro de la fraction à mettre en puissance ?");
                            lesFractions[0].Puissance (lesFractions[fr2]);
                            Console.WriteLine ("Le résultat de: " + lesFractions[fr1].Afficher () + " ^ " + lesFractions[fr2].Afficher () + " est de: " + lesFractions[0].Afficher () + ".");
                            break;
                        #endregion
                        #region Oposé
                        case ConsoleKey.PageUp:
                            fr1 = VerifFrac ("Quel numéro de fraction on opose ?");
                            lesFractions[fr1].Opose ();
                            Console.WriteLine ("La fraction est désormait oposé, voici son résultat: " + lesFractions[fr1].Afficher () + ".");
                            break;
                        #endregion
                        #region Inverse
                        case ConsoleKey.PageDown:
                            fr1 = VerifFrac ("Quel est le numéro de la fraction à inverser ?");
                            lesFractions[fr1].Inverse ();
                            Console.WriteLine ("La fractrion est désormait inversé, voici le résultat: " + lesFractions[fr1].Afficher ());
                            break;
                        #endregion
                        #region Sortir
                        case ConsoleKey.Escape:
                            Console.WriteLine ("Le programme va se terminer");
                            break;
                        #endregion
                        default:
                            Console.WriteLine ("Cette touche n'est pas attribuée");
                            break;
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine ("Erreur: " + error.Message);
                }
            } while (ConsoleKey.Escape != touche);
            Console.WriteLine ("Bye");
            Console.ReadLine ();
        }
    }
}
