using System;
using System.Collections.Generic;
using System.Text;

namespace Jeu_du_421
{
    class De
    {
        #region Variables
        private int number;
        bool etat; //état du dé si vérouiller ou non
        #endregion
        #region Initiation
        public De ()
        {
            Random rand = new Random ();
            this.number = rand.Next (1, 7);
            this.etat = false;
        }
        #endregion
        #region Number
        public int GetNumber ()
        {
            return this.number;
        }
        public void SetNumber (int _number)
        {
            this.number = _number;
        }
        public void Lancer ()
        {
            Random rand = new Random ();
            this.number = rand.Next (1, 7);
        }
        #endregion
        #region Verouillage
        public bool GetEtat ()
        {
            return this.etat;
        }
        public void SetEtat ()
        {
            if (etat)
            {
                etat = false;
            }
            else
            {
                etat = true;
            }
        }
        public void Unlock ()
        {
            this.etat = false;
        }
        #endregion
    }
}
