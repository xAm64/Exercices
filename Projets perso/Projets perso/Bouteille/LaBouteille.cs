using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bouteille
{
    public class LaBouteille
    {
        private bool ouvert = false;
        private double contenue = 1;

        #region vider
        public double Vider()
        {
            contenue = 0;

            return contenue;
        }
        #endregion

        #region Remplir
        public double Remplir()
        {
            contenue = 1;
            return contenue;
        }
        #endregion

        #region ouvrir
        public bool Ouvrir()
        {
            ouvert = true;

            return ouvert;
        }
        #endregion

        #region fermer
        public bool Fermer()
        {
            ouvert = false;
            return ouvert;
        }
        #endregion

        #region Message
        public override string ToString()
        {
            return "État de la bouteille: ouvert= " +ouvert+ " contenue= " +contenue;
        }
        #endregion
    }
}