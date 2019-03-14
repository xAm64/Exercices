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

            bool restart = false;
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
                    int index =0;
                    while ((index < Tableau2.Length)&&( codeAvion != Tableau2[index]))
                    {
                        index++;
                    }

                    if(index < Tableau2.Length)
                    {
                        Console.WriteLine("Avion {0} Vitesse {1} Rayon {2}", Tableau1[index], Tableau3[index], Tableau4[index]);
                        Console.WriteLine("Voulez-vous faire une autre recherche ?");
                        restart = Console.ReadKey().Key == ConsoleKey.O;
                    }
                    else
                    {
                        Console.WriteLine("Cet avion n'existe pas !");
                        restart = true;
                    }
                    


                }


            }
            while (restart);

            Console.WriteLine("{0}Au revoir", Environment.NewLine);
            Console.ReadLine();
        }



            
    }
}
