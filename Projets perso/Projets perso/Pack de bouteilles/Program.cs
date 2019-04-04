using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pack_de_bouteilles
{
    class Program
    {
        #region Parseur
        static bool Parseur (string saisie, ref int nombre)
        {
            bool ok = int.TryParse(saisie, out nombre);
            if (!ok)
            {
                Console.WriteLine("Écrit moi des chiffres, je ne suis pas madame soleil");
                nombre = 0;
            }
            return ok;
        }
        #endregion
        static void Main(string[] args)
        {
            Pack2Bouteilles pack = new Pack2Bouteilles();
            Bouteille eau = new Bouteille();
            EmbalagePack embal = new EmbalagePack();
            bool sortir = false;
            bool ok;
            int nombre;
            Console.WriteLine(pack);
            do
            {
                Console.WriteLine("Que voulez-vous faire\najouter ? retirer ¿ ouvrir ? fermer¿ vider? remplir¿ sortir?");
                string saisie = Console.ReadLine();
                #region Commandes
                if (saisie == "ajouter" || saisie == "retirer" || saisie == "ouvrir" || saisie == "fermer" || saisie == "vider" || saisie == "remplir" || saisie == "sortir")
                {
                    #region Ajouter
                    if (saisie == "ajouter")
                    {
                        do
                        {
                            nombre = 0;
                            Console.WriteLine("Combien on ajoute ?");
                            saisie = Console.ReadLine();
                            ok = int.TryParse(saisie, out nombre);
                            pack.Ajouter(nombre);
                        }
                        while (!ok);
                    }
                    #endregion
                    #region Retirer
                    if (saisie == "retirer")
                    {
                        do
                        {
                            nombre = 0;
                            Console.WriteLine("Combien en retire ?");
                            saisie = Console.ReadLine();
                            ok = int.TryParse(saisie, out nombre);
                            pack.Retirer(nombre);
                        }
                        while (!ok);
                    }
                    #endregion
                    #region Ouvrir
                    if (saisie == "ouvrir")
                    {
                        eau.Ouvrir();
                    }
                    #endregion
                    #region Fermer
                    if (saisie == "fermer")
                    {
                        eau.Fermer();
                    }
                    #endregion
                    #region Vider
                    if (saisie == "vider")
                    {
                        do
                        {
                            ok = true;
                            Console.WriteLine("De combien de % on vide ?");
                            saisie = Console.ReadLine();
                            ok = int.TryParse(saisie, out nombre);
                            if (nombre <= 0 || nombre >100)
                            {
                                Console.WriteLine("La valeur saisie dépasse la capacitée de la bouteille");
                                ok = false;
                            }
                        }
                        while(!ok) ;
                        eau.Vider(nombre);
                    }
                    #endregion
                    #region Remplir
                    if (saisie == "remplir")
                    {
                        do
                        {
                            Console.WriteLine("De combien de % on remplit ?");
                            saisie = Console.ReadLine();
                            ok = int.TryParse(saisie, out nombre);
                            if (nombre <= 0 || nombre >100)
                            {
                                Console.WriteLine("La valeur saisie dépasse la capacitée de la bouteille");
                                ok = false;
                            }
                        }
                        while (!ok);
                        eau.Remplir(nombre);
                    }
                    #endregion
                    #region Sortie
                    if (saisie == "sortir")
                    {
                        sortir = true;
                    }
                    #endregion
                }
                else
                {
                    Console.WriteLine("Vous avez écrit n'importe quoi !");
                }
                #endregion
                Console.WriteLine(pack);
                Console.WriteLine(eau);
            }
            while (sortir == false);
            Console.WriteLine("Au revoir");
            Console.ReadLine();
        }
    }
}
