using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {

        static void Main(string[] args)
        {
            bool restart;
            do
            {
                restart = false;
                Console.WriteLine("Écrire un mot ou une phrase (Maximun 255 caractères)");
                string saisie;
                string voyelles = "aeiouyAEIOUY";
                string consones = "bcdfghjklmnpqrstvwxzBCDFGHJKLMNPQRSTVWXZ";
                string space = " ";
                string acents = "àáâèéêìíîòóôùúûýÀÁÂÈÉÊÌÍÎÒÓÔÙÚÛÝ";
                string chiffres = "0123456789";
                string tirets = "-";
                int compCar = 0;
                int voyCar = 0;
                int conCar = 0;
                int spaceC = 0;
                int carAct = 0;
                int speCar = 0;
                int nbrs = 0;
                int motComp = 0;

                saisie = Console.ReadLine();

                for (int i = 0; i < saisie.Length; i++)//boucle for
                {
                    compCar++;
                    char c = saisie[i];
                    if (voyelles.Contains(c))
                    {
                        voyCar++;
                    }
                    if (consones.Contains(c))
                    {
                        conCar++;
                    }
                    if (space.Contains(c))
                    {
                        spaceC++;
                    }
                    if (acents.Contains(c))
                    {
                        carAct++;
                    }
                    if (chiffres.Contains(c))
                    {
                        nbrs++;
                    }
                    if (tirets.Contains(c))
                    {
                        motComp++;
                    }
                    
                }
                speCar = compCar - voyCar - conCar - spaceC - carAct - nbrs - motComp;
                spaceC++;
                if (compCar <= 1)//nombre de caractères
                {
                    Console.WriteLine("La ligne {0} compte {1} caractère", saisie, compCar);
                }
                else
                {
                    Console.WriteLine("La ligne {0} compte {1} caractères", saisie, compCar);
                }

                if (conCar <= 1)//nombre de consonnes
                {
                    Console.WriteLine("{0} consone", conCar);
                }
                else
                {
                    Console.WriteLine("{0} consonnes", conCar);
                }

                if (voyCar <= 1)//nombre de voyelles
                {
                    Console.WriteLine("{0} voyelle", voyCar);
                }
                else
                {
                    Console.WriteLine("{0} voyelles", voyCar);
                }
                if (spaceC <= 1)
                {
                    Console.WriteLine("{0} mot", spaceC);
                }
                else
                {
                    Console.WriteLine("{0} mots", spaceC);
                }
                if (carAct <= 1)
                {
                    Console.WriteLine("{0} caractère accentué", carAct);
                }
                else
                {
                    Console.WriteLine("{0} caractères accentués", carAct);
                }
                if (motComp <= 1)
                {
                    Console.WriteLine("{0} mot composé", motComp);
                }
                else
                {
                    Console.WriteLine("{0} mots composés", motComp);
                }
                if (nbrs <= 1)
                {
                    Console.WriteLine("{0} chiffre", nbrs);
                }
                else
                {
                    Console.WriteLine("{0} chiffres", nbrs);
                }
                if (speCar <= 1)
                {
                    Console.WriteLine("{0} caractère spécial", speCar);
                }
                else
                {
                    Console.WriteLine("{0} caractères spéciaux", speCar);
                }

                Console.WriteLine("Voulez-vous refaire un nouveau ?");
                restart = Console.ReadKey().Key == ConsoleKey.O;

            }
            while (restart);

            Console.ReadLine();
        }
    }
}
