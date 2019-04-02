using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouteille
{
    class Programme
    {
        static void Main(string[] args)
        {
            bool restart = false;
            LaBouteille eau = new LaBouteille();

                string saisie;
                Console.WriteLine(eau);
            do
            {
                Console.WriteLine("Que voulez-vous faire ?\nouvrir ? fermer ? remplir? vider?");
                saisie = Console.ReadLine();
                if (saisie == "ouvrir" || saisie == "fermer" || saisie == "remplir" || saisie == "vider")
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
                        eau.Remplir();
                    }
                    if (saisie == "vider")
                    {
                        eau.Vider();
                    }
                }
                else
                {
                    Console.WriteLine("Vous avez écrit n'impote quoi");
                }
                Console.WriteLine(eau);
                Console.WriteLine("On arrête là ?");
                restart = Console.ReadKey().Key == ConsoleKey.O;
            }
            while (restart == false);
            Console.WriteLine("Au revoir");
            Console.ReadLine();
        }
    }
}
