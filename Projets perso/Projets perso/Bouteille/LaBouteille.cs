using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bouteille
{
    public class LaBouteille
    {
        private bool ouvert = false;
        string etatBout = "fermée";
        private double contenue = 100;

        #region vider
        public double Vider(double valeur)
        {
            if (contenue == 0)
            {
                Console.WriteLine("La bouteille est déjà vide");
            }
            else
            {
                if (ouvert == true)
                {
                    contenue -= valeur;
                    if (contenue <0)
                    {
                        Console.WriteLine("La bouteille n'étais pas assez remplie et n'a pas pu satisfaire votre besoin");
                        contenue = 0;
                    }
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
        public double Remplir(double valeur)
        {
            if (contenue >= 100)
            {
                Console.WriteLine("La bouteille est déjà pleine");
            }
            else
            {
                if (ouvert == true)
                {
                    contenue += valeur;
                    if (contenue >100)
                    {
                        Console.WriteLine("La bouteille a débordé et vous vous en êtes mit partout");
                        contenue = 100;
                    }
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
                etatBout = "ouverte";
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
                etatBout = "fermée";
                return ouvert;
            }
        }
        #endregion

        #region Message
        public override string ToString()
        {
            return "La bouteille est: "+etatBout+" est remplie à " +contenue+ "%";
        }
        #endregion
    }
}