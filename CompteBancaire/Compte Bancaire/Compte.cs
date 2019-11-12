using System;
using System.Collections.Generic;
using System.Text;

namespace Compte_Bancaire
{
    public class Compte
    {
        #region Variables
        private int number;
        private string nomProprio;
        private double solde;
        private double decouvertAutorise;
        #endregion

        #region initiation
        // Basique -----------------------------------
        public Compte ()
        {
            Random monAleas = new Random();
            this.number = monAleas.Next(100000, 999999999);
            this.nomProprio = "No Name";
            this.solde = 0;
            this.decouvertAutorise = 0;
        }
        //Complète ------------------------------------------
        public Compte (int _id, string _nom, double _solde, double _decouvertAutorise)
        {
            this.number = _id;
            this.nomProprio = _nom;
            this.solde = _solde;
            this.decouvertAutorise = _decouvertAutorise;
        }
        #endregion
        // ------ Fonction -------
        #region Fonction
        //permet d'écrire Euro si le nombre est inférieure à 2
        public string Euro (double _value)
        {
            string euro;
            if (_value < 2 && _value > -2)
            {
                euro = "Euro";
            }
            else
            {
                euro = "Euros";
            }
            return euro;
        }
        #endregion
        // ------ Variables ------
        #region Nom
        public string GetNom ()
        {
            return nomProprio;
        }
        public void SetNom (string _name)
        {
            this.nomProprio = _name;
        }
        #endregion
        #region decouvert autorisé
        public double GetDecouvert ()
        {
            return decouvertAutorise;
        }
        public void SetDecouvert (double _value)
        {
            if (_value > 0)
            {
                throw new InvalidOperationException ("La valeur maximale est de 0");
            }
            if (solde < _value)
            {
                throw new ApplicationException ("L'utilisateur a moins d'argent que le plafond");
            }
            this.decouvertAutorise = _value;
        }
        #endregion
        #region Solde
        public double GetSolde ()
        {
            return solde;
        }
        #endregion
        #region ID
        public int GetID ()
        {
            return number;
        }
        public void SetID (int _value)
        {
            this.number = _value;
        }
        #endregion
        #region Afficher
        //Affichage Basic
        public string Afficher ()
        {
            string message = "Le compte de: " + nomProprio + " a un solde de: " + solde + Euro(solde) + "(virtuel).\n";
            return message;
        }
        //Affichage complet
        public string LookAll ()
        {
         string message = "Le compte de: " + nomProprio + " a un solde de: " + solde + Euro(solde) + " (virtuel), son numéro est: " + number + " Le découvert maximum est de: " + decouvertAutorise + Euro(decouvertAutorise) + " (virtuel).([M] = changer les paramètres du découvert)\n";
         return message;
        }
        #endregion
        //------ Méthodes ------
        #region Crediter
        public bool Crediter (double _value)
        {
            bool ok = true;
            if (_value < 0)
            {
                ok = false;
                throw new ArgumentException ("La valeur doit être positive");
            }
            solde += _value;
            return ok;
        }
        #endregion
        #region Débiter
        public bool Debiter (double _value)
        {
            bool ok;

            if (_value < 0)
            {
                ok = false;
                throw new ArgumentException ("La valeur doit être positive");
            }
            else if ((solde - _value) < decouvertAutorise)
            {
                ok = false;
                throw new ApplicationException ("Vous dépasser le découvert autorisé");
            }
            else
            {
                solde -= _value;
                ok = true;
            }
            return ok;
        }
        #endregion
        #region Virement
        public bool Transferer (double _montant, Compte _beneficiaire)
        {
            if (_beneficiaire == null)
            {
                throw new InvalidOperationException ("Le compte du bénéficiaire n'existe plus");
            }
            bool ok = true;
            ok = this.Debiter (_montant);
            if (ok)
            {
                ok = _beneficiaire.Crediter(_montant);
            }
            return ok;
        }
        #endregion
        #region Supérieur
        public bool Superieur (Compte _compte)
        {
            bool sup;
            if (_compte.GetSolde() > solde)
            {
                sup = true;
            }
            else
            {
                sup = false;
            }
            return sup;
        }
        #endregion
    }
}
