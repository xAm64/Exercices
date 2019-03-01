using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_avion
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] Tableau1 = new string[]//Avion
            {
                "Boing747",
                "AirbusA380",
                "Learjet45",
                "DC10",
                "Consorde",
                "Antonov32",
            };
            string[] Tableau2 = new string[]//code avion
            {
                "B0",
                "AB",
                "LJ",
                "DC",
                "CO",
                "AN",
            };
            int[] Tableau3 = new int[]//vitesse
            {
                800,
                950,
                700,
                900,
                1400,
                560,
             };
            int[] Tableau4 = new int[]//rayon d'action
            {
                10000,
                12000,
                4500,
                8000,
                16000,
                2500,
            };

            bool restart;
            restart = false;
            string codeAvion;

            do
            {
                Console.WriteLine("Entrez le code de l'avion");
                codeAvion = Console.ReadLine().Trim();
                if (string.IsNullOrEmpty(codeAvion))
                {
                    Console.WriteLine("Vous n'avez rien écrit !¡!");
                    restart = true;
                }
                else
                {
                    Console.WriteLine("Vous avez écrit {0} ", codeAvion);

                    foreach(string value in Tableau2)
                    {
                        if (value.ToLower() == codeAvion.ToLower())
                        {
                            Console.WriteLine("Avion {0} Vitesse X Rayon Y", Array.IndexOf(Tableau2, codeAvion));
                        }


                        

                    }
                    if()//si résultat = null
                    {
                        Console.WriteLine("Cet avion n'existe pas");
                        restart = true;
                    }

                }

            }
            while (restart);


            Console.ReadLine();
        }
    }
}
