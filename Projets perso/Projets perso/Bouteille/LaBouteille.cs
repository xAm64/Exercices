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
            if (contenue == 0)
            {
                Console.WriteLine("La bouteille est déjà vide");
            }
            else
            {
                if (ouvert == true)
                {
                    contenue = 0;
                }
                else
                {
                    Console.WriteLine("La bouteille n'est pas ouverte");
                }
            }
            return contenue;
        }
        #endregion

        #region Remplir
        public double Remplir()
        {
            if (contenue == 1)
            {
                Console.WriteLine("La bouteille est déjà pleine");
            }
            else
            {
                if (ouvert == true)
                {
                    contenue = 1;
                }
                else
                {
                    Console.WriteLine("La bouteille n'est pas ouverte");
                }
            }
            return contenue;
        }
        #endregion

        #region ouvrir
        public bool Ouvrir()
        {
            if (ouvert == true)
            {
                Console.WriteLine("La bouteille est déjà ouverte");
                return ouvert;
            }
            else
            {
                ouvert = true;
                return ouvert;
            }
        }
        #endregion

        #region fermer
        public bool Fermer()
        {
            if (ouvert == false)
            {
                Console.WriteLine("La bouteille est déjà fermée");
                return ouvert;
            }
            else
            {
                ouvert = false;
                return ouvert;
            }
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