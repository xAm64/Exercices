using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static float moyenne;
        static float nA;
        static float nB;

        static void Main(string[] args)
        {
            bool ok;
            do
            {
                Console.WriteLine("Quel est le nombre A ?");
                string NbA = Console.ReadLine();
                ok = float.TryParse(NbA, out nA);
            }
            while (!ok);
            do
            {
                Console.WriteLine("Quel est le nombre B ?");
                string NbB = Console.ReadLine();
                ok = float.TryParse(NbB, out nB);
            }
            while (!ok);

            moyenne = (nA + nB) /2;
            Console.WriteLine("Le premier nombre saisie est: " + nA + " Le 2ème chiffre saisie est: " + nB + " La moyenne de ces nombre est: " + moyenne);
            

            Console.ReadLine();
        }
    }
}
