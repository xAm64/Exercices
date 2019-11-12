using System;
using System.Collections.Generic;
using System.Text;

namespace Compte_Bancaire
{
    public class Bank
    {
        #region Variables
        private int nbComptes = 0;
        Compte[] LesComptes;
        // Variables ajoutés
        private static ConsoleKey inputKey = ConsoleKey.Spacebar;
        private static double montant;
        private static bool ok;
        private static int numeroSaisie;
        #endregion

        #region Fonction
        // Virement
        private void Virement (int _numeroDestinataire)
        {
            Console.WriteLine ("Quel le numéro du destinateire");
        }
        // crée un compte
        #region Ajouter compte
        private void AjouterCompte (Compte _unCompte)
        {
            LesComptes[NbComptes++] = _unCompte;
        }
        #endregion
        #endregion

        public Bank ()
        {
            LesComptes = new Compte[20];
            this.NbComptes = 0;
        }

        public int NbComptes
        {
            get
            {
                return nbComptes;
            }

            set
            {
                nbComptes = value;
            }
        }

        #region  initialation rapide
        //cette initiation sert uniquement de base
        public void Init ()
        {
            this.AjouterCompte (new Compte (NbComptes, "mage", 1000, -500));
            this.AjouterCompte (new Compte (NbComptes, "prêtre", 2000, -1000));
            this.AjouterCompte (new Compte (NbComptes, "titi", 400, -100));
            this.AjouterCompte (new Compte (NbComptes, "grominet", 4210, -100));
            this.AjouterCompte (new Compte (NbComptes, "bipbip", 431, -20));
            this.AjouterCompte (new Compte (NbComptes, "coyotte", 313, -10));
        }
        #endregion

        #region Interaction avec un compte
        public void InteractionCompte (int _numero)
        {
            if (_numero < NbComptes)
            {
                if (LesComptes[_numero] == null)
                {
                    throw new InvalidOperationException ("Le compte auquel vous essayer d'interagir n'existe plus");
                }
                do
                {
                    Console.WriteLine ("Vous êtes sur le compte numéro " + _numero + " " + LesComptes[_numero].Afficher () + " .Que voulez-vous faire ?\n[A] = Créditer, [R] Débiter, [V] Faire un Virement, [I] Afficher toutes les infos, [S] Sortir de ce compte.\n");
                    inputKey = Console.ReadKey ().Key;

                    switch (inputKey)
                    {
                        #region Crediter
                        case ConsoleKey.A:
                            montant = Program.VerifDouble ("On ajoute combien ?");
                            ok = LesComptes[_numero].Crediter (montant);
                            if (ok)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write ("L'opération est réussi: ");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write ("Échec de l'opéation: ");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            break;
                        #endregion
                        #region Débiter
                        case ConsoleKey.R:
                            montant = Program.VerifDouble ("On retire combien ?");
                            ok = LesComptes[_numero].Debiter (montant);
                            if (ok)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write ("L'opération à réussi: ");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write ("Échec de l'opération: ");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            break;
                        #endregion
                        #region Infos
                        case ConsoleKey.I:
                            Console.WriteLine (LesComptes[_numero].LookAll ());
                            break;
                        #endregion
                        #region Modifier découvert
                        case ConsoleKey.M:
                            montant = Program.VerifDouble ("Quel est le nouveau plafond ?");
                            LesComptes[_numero].SetDecouvert (montant);
                            Console.WriteLine ("Le nouveau plafond est désormait de: " + LesComptes[_numero].GetDecouvert () + "\n");
                            break;
                        #endregion
                        #region Virement
                        case ConsoleKey.V:
                            montant = Program.VerifDouble ("Quel est le montant à virer ?");
                            numeroSaisie = Program.VerifInt ("Quel est le numéro de compte du bénéficiaire ?");
                            ok = LesComptes[_numero].Transferer (montant, LesComptes[numeroSaisie]);
                            if (ok)
                            {
                                Console.WriteLine ("Opération réussi");
                                Console.WriteLine ("Le compte de: " + LesComptes[numeroSaisie].Afficher ());
                            }
                            else
                            {
                                Console.WriteLine ("Échec de l'opération");
                            }
                            break;
                            #endregion
                    }
                } while (ConsoleKey.S != inputKey);
            }
            else
            {
                Console.WriteLine ("Le compte demandée n'existe pas");
            }
        }
        #endregion
        
        #region Créer un Compte
        // Automatique
        public void CrerCompte (int _numero, string _nom, double _solde, double _decouvertMaxi)
        {
            int numero2Compte = NbComptes;
            this.AjouterCompte (new Compte (_numero, _nom, _solde, _decouvertMaxi));
            Console.WriteLine ("Le compte numéro: " + numero2Compte + " de: " + _nom + " est crée, son solde est de: " + _solde + LesComptes[numero2Compte].Euro (_solde) + " (virtuel), le découvert maximum est de: " + _decouvertMaxi + LesComptes[numero2Compte].Euro (_decouvertMaxi) + " (virtuel), est crée et prêt à l'emploie.");
        }
        // Manuel
        public void CrerCompte ()
        {
            int numero2Compte = NbComptes;
            double decouvert, solde;
            string saisie;
            do
            {
                Console.WriteLine ("Quelle est le nom du propriétaire ?");
                saisie = Console.ReadLine ();
                solde = Program.VerifDouble ("Quelle est le solde du compte ?");
                decouvert = Program.VerifDouble ("Quelle est le plafond du découvert autorisé");
                Console.WriteLine ("Voici les paramètres saisies : Nom: " + saisie + " Solde du compte: " + solde + " Le découvert maximum de ce compte est de: " + decouvert + ". Ces informations sont elles correct ? [O] = oui, [N] = non.");
                inputKey = Console.ReadKey ().Key;
            } while (ConsoleKey.O != inputKey);
            this.AjouterCompte (new Compte (numero2Compte, saisie, solde, decouvert));
            Console.WriteLine ("Le compte numéro: " + numero2Compte + " de: " + saisie + " est crée, son solde est de: " + solde + LesComptes[numero2Compte].Euro(solde) + " (virtuel), le découvert maximum est de: " + decouvert + LesComptes[numero2Compte].Euro(decouvert) + " (virtuel), est crée et prêt à l'emploie.");
        }
        #endregion
        
        #region Supprimer un compte
        public bool Supprimer (int _numero)
        {
            bool ok = false;
            if (_numero > NbComptes)
            {
                throw new InvalidOperationException ("Ce numéro de compte n'existe pas");
            }
            if (LesComptes[_numero].GetSolde () < 0)
            {
                throw new OperationCanceledException ("Impossible de supprimmer " + LesComptes[_numero].Afficher () + ". Ce compte à une dette !");
            }
            if (LesComptes[_numero].GetSolde () > 0)
            {
                throw new OperationCanceledException ("Impossible de supprimmer " + LesComptes[_numero].Afficher () + " tant qu'il n'est pas vide");
            }
            if (LesComptes[_numero].GetSolde () == 0)
            {
                Console.WriteLine ("Êtes vous sur de vouloir supprimmer " + LesComptes[_numero].Afficher() + "?");
                inputKey = Console.ReadKey ().Key;
                switch (inputKey)
                {
                    case ConsoleKey.O:
                        LesComptes[_numero] = null;
                        ok = true;
                        break;
                }
            }
            return ok;
        }
        #endregion
        #region Afficher Bank
        public string AfficherBank ()
        {
            string chainBank = "------------- Début affichage Banque -------------\n";
            for (int i = 0; i < NbComptes; i++)
            {
                if (LesComptes[i] != null)
                {
                    chainBank += "Compte numéro: " + i + " " + LesComptes[i].Afficher ();
                }
            }
            chainBank += "------------- Fin affichage banque -------------";
            return chainBank;
        }
        #endregion
        #region supérieure
        public void Superieure (int _numero1, int _numero2)
        {
            string resultat;
            if (_numero1 > NbComptes || _numero2 > NbComptes)
            {
                throw new InvalidOperationException ("Un des numéros de compte saisies n'existe pas");
            }
            if (_numero1 == _numero2)
            {
                throw new InvalidOperationException ("Vous ne pouvez pas comparer le même compte");
            }
            if (LesComptes[_numero1] == null || LesComptes[_numero2] == null)
            {
                throw new InvalidOperationException ("Un des comptes à compater n'existe plus");
            }
            bool sup = LesComptes[_numero1].Superieur (LesComptes[_numero2]);
            
            if (sup)
            {
                resultat = "supérieur";
            }
            else
            {
                resultat = "inférieur";
            }
            Console.WriteLine ("Le compte de: " + LesComptes[_numero1].GetNom () + " numéro: " + _numero1 + " est: " + resultat + " à celui de: " + LesComptes[_numero2].GetNom ()+ " numéro: " + _numero2 + ".");
        }
        #endregion
    }
}
