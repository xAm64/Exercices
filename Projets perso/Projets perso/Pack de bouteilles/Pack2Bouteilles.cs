using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pack_de_bouteilles
{
    public class Pack2Bouteilles
    {
        private List<Bouteille> bouteilles;
        private EmbalagePack embalage;
        public int nombre;
        private double CalculPrix;

        #region Nombre de bouteilles
        public Pack2Bouteilles()
        {
            nombre = 6;
        }
        #endregion

        #region Ajouter
        public int Ajouter(int valeur)
        {
            nombre += valeur;
            return valeur;
        }
        #endregion

        #region Retirer
        public int Retirer(int valeur)
        {
            if (nombre == 0)
            {
                Console.WriteLine("Le pack est vide");
            }
            else
            {
                nombre -= valeur;
                if (nombre < 0)
                {
                    Console.WriteLine("Le nombre de bouteille n'était pas suffisant pour satisfaire votre besoin");
                    nombre = 0;
                }
            }
            return nombre;
        }
        #endregion

        #region Message du nombre de bouteilles
        public string MotBouteille(int valeur)
        {
            valeur = nombre;
            string message;
            if (nombre >= 1)
            {
                message = "bouteille";
            }
            else
            {
                message = "bouteilles";
            }
            return message;
        }

        public override string ToString()
        {
            string bouteille = MotBouteille(nombre);
            return "Il reste: " + nombre + " " + bouteille + " dans le pack";
        }
        #endregion
    }
}