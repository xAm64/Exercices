using System;
using System.Collections.Generic;
using System.Text;

namespace Fraction
{
    class Fraction
    {
        #region Variables
        private int numerateur;
        private int denominateur;
        #endregion

        #region Initiation
        // complète
        public Fraction (int _numerateur, int _denominateur)
        {
            if (_denominateur != 0)
            {
                this.numerateur = _numerateur;
                this.denominateur = _denominateur;
            }
            else
            {
                throw new InvalidOperationException ("Le denominateur ne peux pas être de 0");
            }
            
        }
        //vide
        public Fraction ()
        {
            this.numerateur = 0;
            this.denominateur = 1;
        }
        // partiel
        public Fraction (int _numerateur)
        {
            this.numerateur = _numerateur;
            this.denominateur = 1;
        }
        #endregion

        #region Numerateur
        public int GetNumerateur ()
        {
            return numerateur;
        }
        public void SetNumerateur (int _chiffre)
        {
            this.numerateur = _chiffre;
        }
        #endregion
        #region Denominateur
        public int GetDenominateur ()
        {
            return denominateur;
        }
        public void SetDenominateur (int _chiffre)
        {
            this.denominateur = _chiffre;
        }
        #endregion
        // méthodes
        #region PGCD
        public int Pgcd ()
        {
            int a = numerateur, b = denominateur, pgcd = 1;
            if (a < 0) a = -a;
            if (b < 0) b = -b;
            while (a != b)
            {
                if (a < b)
                {
                    b -= a;
                }
                else
                {
                    a -= b;
                }
                pgcd = a;
            }
            return pgcd;
        }
        #endregion
        #region Réduire
        public void Reduire ()
        {
            int pgcd = Pgcd ();
            this.numerateur = numerateur / pgcd;
            this.denominateur = denominateur / pgcd;
        }
        public void Reduire (ref int n, ref int d)
        {
            int pgcd = Pgcd ();
            n = n / pgcd;
            d = d / pgcd;
        }
        #endregion
        #region Supérieure
        public bool Superieur (Fraction _identifiant)
        {
            bool sup;
            double a = numerateur / denominateur, b = _identifiant.GetNumerateur () / _identifiant.GetDenominateur ();
            if (a > b)
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
        #region Inférieure
        public bool Inferieure (Fraction _identifiant)
        {
            bool inf;
            double a = numerateur / denominateur, b = _identifiant.GetNumerateur () / _identifiant.GetDenominateur ();
            if (a < b)
            {
                inf = true;
            }
            else
            {
                inf = false;
            }
            return inf;
        }
        #endregion
        #region Égalité
        public bool Egalite (Fraction _identifiant)
        {
            bool egal;
            double a = numerateur / denominateur;
            double b = _identifiant.GetNumerateur () / _identifiant.GetDenominateur ();
            if (a == b)
            {
                egal = true;
            }
            else
            {
                egal = false;
            }
            return egal;
        }
        #endregion
        #region Somme
        public Fraction Somme (Fraction _identfiant)
        {
            numerateur = (numerateur * _identfiant.GetDenominateur ()) + (_identfiant.GetNumerateur() * _identfiant.GetDenominateur());
            denominateur = (denominateur * _identfiant.GetDenominateur ());
            if (denominateur == 0)
            {
                throw new DivideByZeroException ("Fraction est impossible: 0 n'est pas danbs le dommaine de définition");
            }
            Reduire (ref numerateur, ref denominateur);
            Fraction resultat = new Fraction (numerateur, denominateur);
            return resultat;
        }
        #endregion
        #region Différence
        public Fraction Difference (Fraction _identifiant)
        {
            numerateur = (numerateur * _identifiant.GetDenominateur()) - (_identifiant.GetNumerateur()*_identifiant.GetDenominateur());
            denominateur = denominateur * _identifiant.GetDenominateur();
            if (denominateur == 0)
            {
                throw new InvalidOperationException ("Cette opération est impossible");
            }
            Reduire (ref numerateur, ref denominateur);
            Fraction resultat = new Fraction (numerateur, denominateur);
            return resultat;
        }
        #endregion
        #region Produit
        public Fraction Produit (Fraction _identifiant)
        {
            numerateur = this.numerateur * _identifiant.GetNumerateur ();
            denominateur = this.denominateur * _identifiant.GetDenominateur ();
            if (denominateur == 0)
            {
                throw new DivideByZeroException ("Fraction impossible: 0 n'est pas dans la dommaine de définition");
            }
            Reduire (ref numerateur, ref denominateur);
            Fraction resultat = new Fraction (numerateur, denominateur);
            return resultat;
        }
        #endregion
        #region Quotient
        public Fraction Quotient (Fraction _identifiant)
        {
            numerateur = (this.numerateur * _identifiant.GetDenominateur ());
            int denominateur = (this.denominateur * _identifiant.GetNumerateur ());
            if (denominateur == 0)
            {
                throw new DivideByZeroException ("Fraction impossible: 0 n'est pas dans le dommaine de définition");
            }
            Reduire (ref numerateur, ref denominateur);
            Fraction resultat = new Fraction (numerateur, denominateur);
            return resultat;
        }
        #endregion
        #region Puissance
        public Fraction Puissance (Fraction _identifiant)
        {
            numerateur = (int)-Math.Pow (numerateur * _identifiant.GetDenominateur (), _identifiant.GetNumerateur() * _identifiant.GetDenominateur());
            denominateur = (int)Math.Pow (denominateur, _identifiant.GetDenominateur ());
            if (denominateur == 0)
            {
                throw new DivideByZeroException ("Fraction est impossible: 0 n'est pas dans le domaine de définition");
            }
            Reduire (ref numerateur, ref denominateur);
            Fraction resultat = new Fraction (numerateur, denominateur);
            return resultat;
        }
        #endregion
        #region Oposé
        public void Opose ()
        {
            numerateur = numerateur * -1;
        }
        #endregion
        #region Inverse
        public void Inverse ()
        {
            if (numerateur != 0)
            {
                int x = numerateur;
                numerateur = denominateur;
                denominateur = x;
            }
            else
            {
                throw new FormatException ("Division par 0");
            }
        }
        #endregion
        //Fonction
        #region Afficher
        public string Afficher ()
        {
            string afficher = numerateur + " / " + denominateur;
            return afficher;
        }
        #endregion
    }
}
