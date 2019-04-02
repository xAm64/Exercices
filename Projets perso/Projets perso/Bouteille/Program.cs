using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouteille
{
    class Programme
    {

        #region Parseur
        static bool Parseur (string saisie, ref byte nombre)
        {
            bool ok = byte.TryParse(saisie, out nombre);
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
            

            bool sortir = false;
            bool ok;
            byte pourcent = 0;
            LaBouteille eau = new LaBouteille();

                string saisie;
                Console.WriteLine(eau);
            do
            {
                Console.WriteLine("Que voulez-vous faire ?\nouvrir ? fermer ? remplir? vider? sortir ?");
                saisie = Console.ReadLine();
                if (saisie == "ouvrir" || saisie == "fermer" || saisie == "remplir" || saisie == "vider" || saisie == "sortir")
                {
                    if (saisie == "ouvrir")
                    {
                        eau.Ouvrir();
                    }
                    if (saisie == "fermer")
                    {
                        eau.Fermer();
                    }
                    if (saisie == "remplir")
                    {
                        do
                        {
                            ok = true;
                            Console.WriteLine("De combien de % on remplit ?");
                            saisie = Console.ReadLine();
                            ok = Parseur(saisie, ref pourcent);
                            if (pourcent == 0 || pourcent > 100)
                            {
                                Console.WriteLine("Vous ne pouvez pas saisir une valeur au delà de la capacitée de la bouteille");
                                ok = false;
                            }
                        }
                        while (!ok);
                        eau.Remplir(pourcent);
                    }
                    if (saisie == "vider")
                    {
                        do
                        {
                            ok = true;
                            Console.WriteLine("De combien de % on vide ?");
                            saisie = Console.ReadLine();
                            ok = byte.TryParse(saisie, out pourcent);
                            if (pourcent == 0 || pourcent > 100)
                            {
                                Console.WriteLine("Vous ne pouvez pas saisir uen valeur supérieur à la capacitée de la bouteille");
                                ok = false;
                            }
                        }
                        while (!ok);
                        eau.Vider(pourcent);
                    }
                    if (saisie == "sortir")
                    {
                        sortir = true;
                    }
                }
                else
                {
                    Console.WriteLine("Vous avez écrit n'impote quoi");
                }
                Console.WriteLine(eau);
            }
            while (sortir == false);
            Console.WriteLine("Au revoir");
            Console.ReadLine();
        }
    }
}
