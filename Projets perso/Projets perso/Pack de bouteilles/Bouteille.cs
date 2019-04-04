using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Bouteille
{
    private double contenue;
    private bool ouvert;
    private double prix;

    #region Message de la bouteille
    static string MessageBottle(bool ouvert)
    {
        string message;
        if (ouvert == true)
        {
            message = "ouverte";
        }
        else
        {
            message = "fermée";
        }
        return message;
    }
    #endregion

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
                if (contenue >0)
                {
                    Console.WriteLine("La bouteille n'était pas assez remplis et n'a pas pu satisfaire votre besoin");
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
        if (contenue >=100)
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
                    Console.WriteLine("La bouteille a débordée et vous vous en êtes mit partout");
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

    #region Ouvrir
    public bool Ouvrir()
    {
        if (ouvert == true)
        {
            Console.WriteLine("La bouteille est déjà ouverte");
        }
        else
        {
            ouvert = true;
        }
        return ouvert;
    }
    #endregion

    #region Fermer
    public bool Fermer()
    {
        if (ouvert == false)
        {
            Console.WriteLine("La bouteille est déjà fermee");
        }
        else
        {
            ouvert = false;
        }
        return ouvert;
    }
    #endregion

    #region Bouteille
    public Bouteille()
    {
        ouvert = false;
        contenue = 100;
        prix = 0.30;
	}

	public Bouteille(bool _ouvert, double _contenue, double _prix)
    {
        ouvert = _ouvert;
        contenue = _contenue;
        prix = _prix;
    }
    #endregion

    #region Message de l'étant de la bouteille
    public override string ToString()
    {
        string message = MessageBottle(ouvert);
        return "La bouteille est: "+message+" elle est remplie à: "+ contenue +"%";
	}
    #endregion
}